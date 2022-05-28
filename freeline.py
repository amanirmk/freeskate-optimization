import numpy as np
import animate as a

# arbitrarily chosen quantities
# that result in reasonably-looking physics
MU = 1 # friction coefficient
SKATEMASS = 7
SKATEINERTIA = 5
WEIGHT = 10
LEG = 5 # length of leg
# don't make too small or will take long to run
# don't make too large or accuracy decreases
DT = 0.05 # increment of time

script = [[]]
camerapos = []

def angle(x, y):
    """Takes an X and Y component and returns their angle from 0 to 2pi"""
    if x == 0:
        if y > 0:
            return np.pi/2
        else:
            return -np.pi/2
    else:
        angle = np.arctan(y/x)
        if x < 0:
            angle += np.pi
        return angle

def angle_diff(theta, phi):
    """Takes in two angles and returns their difference from 0 to pi"""
    return np.arccos(np.cos(theta-phi))

class Skate:
    def __init__(self, index, x, y, theta, animate=False):
        self.animate = animate
        self.id = index
        # positional
        self.position = [x,y]
        self.velocity = [0,0]
        self.acceleration = [0,0]
        # angular
        self.theta = theta
        self.omega = 0
        self.alpha = 0
        if self.animate:
            global script
            a.write(script, "skate" + str(self.id) + " = Instantiate("+ ("left" if index == 0 else "right") +"skate," + a.vf([x,y,0]) + "," + a.qf(self.theta) + ");")

    def updateSkate(self, outwardForce, downForce, torque): 
        # compute friction components
        perpForce = outwardForce * np.cos(self.theta)
        motion_theta = angle(*self.velocity)
        # if slipping
        if angle_diff(self.theta, motion_theta) > 0.01 and np.dot(self.velocity, self.velocity) > 0.01: 
            # kinetic friction
            friction = downForce*MU
            friction_angle = self.theta + np.pi/2 if angle_diff(self.theta + np.pi/2, motion_theta) > np.pi/2 else self.theta - np.pi/2
            friction_x = friction * np.cos(friction_angle)
            friction_y = friction * np.sin(friction_angle)
        else: 
            # static friction
            friction = -np.sign(perpForce)*min(np.abs(perpForce), downForce*MU)
            friction_x = friction * np.sin(self.theta)
            friction_y = friction * np.cos(self.theta)
      
        # use forces to update accelerations
        self.acceleration[0] = friction_x/SKATEMASS
        self.acceleration[1] = (outwardForce + friction_y)/SKATEMASS
        self.alpha = torque / SKATEINERTIA

        # use accelerations to update velocities
        self.velocity[0] += self.acceleration[0]*DT
        self.velocity[1] += self.acceleration[1]*DT
        self.omega += self.alpha*DT

        # use velocities to update positions
        self.position[0] += self.velocity[0]*DT
        self.position[1] += self.velocity[1]*DT
        self.theta += self.omega*DT

        if self.animate:
            global script
            a.write(script, "skate" + str(self.id) + ".transform.position = " + a.vf(self.position + [0]) + ";")
            a.write(script, "skate" + str(self.id) + ".transform.rotation = " + a.qf(self.theta) + ";")
            a.write(script, "Destroy(forceline" + str(self.id) + ");")
            a.write(script, "Destroy(moveline" + str(self.id) + ");")
            friction_theta = angle(friction_x, friction_y)
            # note: dividing forces by 5 for visualization because they're generally large
            a.write(script, "forceline" + str(self.id) + " = Instantiate(forceline," + a.vf(self.position + [0]) + "," + a.qf(np.pi/2) + ");")
            a.write(script, "forceline" + str(self.id) + ".transform.localScale = " + a.vf([0,outwardForce/5,0]) + ";")
            a.write(script, "moveline" + str(self.id) + " = Instantiate(moveline," + a.vf(self.position + [0]) + "," + a.qf(friction_theta) + ");")
            a.write(script, "moveline" + str(self.id) + ".transform.localScale = " + a.vf([0, np.sqrt(friction_x**2 + friction_y**2)/5,0]) + ";")


class Rider:
    def __init__(self, lForceFunc, lTorqueFunc, rForceFunc, rTorqueFunc, lTheta, rTheta, animate=False):
        self.animate = animate 
        if self.animate:
            global script, camerapos
            script = [[]]
            camerapos = [a.vf([LEG/4, 0, LEG])]
        # set functions
        self.lForceFunc, self.lTorqueFunc, self.rForceFunc, self.rTorqueFunc = lForceFunc, lTorqueFunc, rForceFunc, rTorqueFunc
        # initialize skates
        self.lSkate, self.rSkate = Skate(0, 0, 0, lTheta, self.animate), Skate(1, LEG/2, 0, rTheta, self.animate)

    def calcstuff(self):
        lx, ly = self.lSkate.position
        rx, ry = self.rSkate.position
        lInFront = 1 if ly > ry else -1
        yDist = np.abs(ry-ly)
        xDist = np.abs(rx-lx)
        totDist = np.sqrt(yDist**2 + xDist**2)
        if LEG**2 - (totDist/2)**2 > 0:
            height = np.sqrt(LEG**2 - (totDist/2)**2) 
        else:
            if self.animate:
                global script
                a.writeScript(script, camerapos)
            raise Exception("Legs cannot reach skates")
        legAngle = np.arctan((yDist/2)/height)
        return legAngle, lInFront, totDist

    def ride(self):
        score = 0
        global script
        N = 500
        for i in range(N):

            try:
                legAngle, lInFront, totDist = self.calcstuff()
            except:
                return score - N*DT*np.power(1/np.log((i*DT)+2), 2)

            downForce = WEIGHT/2
            lOutForce = (downForce*np.tan(legAngle)) * lInFront
            rOutForce = -lOutForce

            lDesForce = self.lForceFunc(i*DT)
            rDesForce = self.rForceFunc(i*DT)

            if np.sign(lDesForce) != np.sign(rDesForce):
                force = min(np.abs(lDesForce), np.abs(rDesForce))
                lOutForce += force*np.sign(lDesForce)
                rOutForce += force*np.sign(rDesForce)

            lTorque = self.lTorqueFunc(i*DT)
            rTorque = self.rTorqueFunc(i*DT)

            if self.animate:
                script.append([])
            self.lSkate.updateSkate(lOutForce, downForce, lTorque)
            self.rSkate.updateSkate(rOutForce, downForce, rTorque)

            score += DT*self.lSkate.position[0]
            score += DT*self.rSkate.position[0]

            if totDist > LEG: #keep legs close together
                score -= DT*(1/np.log((i*DT)+2))*np.power(totDist, 2)
            elif totDist < 1: #don't have skates go through each other
                score -= N*DT
            if not np.pi/2 > self.rSkate.theta > -np.pi/2:
                score -= DT*np.abs(self.rSkate.theta)
            if not np.pi/2 > self.lSkate.theta > -np.pi/2:
                score -= DT*np.abs(self.lSkate.theta)

            if self.animate:
                avg_pos = [(self.lSkate.position[0] + self.rSkate.position[0])/2, (self.lSkate.position[1] + self.rSkate.position[1])/2]
                camerapos.append(a.vf(avg_pos + [totDist*2]))

        if self.animate:
            a.writeScript(script, camerapos)
        return score

def objfunc(params, animate=False): # if animate is true, will write script to masterscript.cs
    a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z = params 
    lff = lambda time: (a if b*(time + c) % 10 < 5 else -a) + (d if e*(time + f) % 10 < 5 else -d)
    rff = lambda time: (g if h*(time + i) % 10 < 5 else -g) + (j if k*(time + l) % 10 < 5 else -j)
    ltf = lambda time: (m if n*(time + o) % 10 < 5 else -m) + (p if q*(time + r) % 10 < 5 else -p)
    rtf = lambda time: (s if t*(time + u) % 10 < 5 else -s) + (v if w*(time + x) % 10 < 5 else -v)
    return -Rider(lff, ltf, rff, rtf, y, z, animate).ride()