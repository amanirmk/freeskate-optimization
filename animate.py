import numpy as np

def write(script, code):
    script[-1].append(code + "\n")

def vf(vector):
    vStr = "new Vector3(" 
    for i in [0,2,1]:
        vStr += str(vector[i]) + "f,"
    vStr = vStr[:-1] + ")"
    return vStr

def qf(rad):  
    return "Quaternion.Euler(0," + str(90 - np.degrees(rad)) + "f, 0)"

def writeScript(script, camerapos):
    # assumes two skates
    masterScript = open("masterscript.cs", "w")
    masterScript.writelines(["using UnityEngine;\n","using System.Collections;\n","using System.Collections.Generic;\n","using System;\n","public class masterscript : MonoBehaviour\n","{\n","private int frameCount = 0;\n"])
    masterScript.writelines(["public static GameObject leftskate;\n", "public static GameObject rightskate;\n", "public static GameObject forceline;\n", "public static GameObject moveline;\n"])
    
    for i in range(2):
        masterScript.write("static GameObject skate" + str(i) + ";\n")
        masterScript.write("static GameObject forceline" + str(i) + ";\n")
        masterScript.write("static GameObject moveline" + str(i) + ";\n")

    masterScript.writelines(["public interface frame\n","{\n","void visualize();\n","}\n"])
    for i in range(len(script)):
        masterScript.writelines(["public class frame" + str(i) + " : frame\n","{\n", "public void visualize()\n","{\n"])
        masterScript.writelines(script[i])
        masterScript.write("}\n}\n")
    masterScript.write("Vector3[] camerapos = {" + str(camerapos).replace("'","")[1:-1] + "};\n")
    makeMethodArr = "frame[] frames = {"
    for i in range(len(script)):
        makeMethodArr += " new frame" + str(i) + "(),"
    makeMethodArr = makeMethodArr[:-1] + "};\n"
    masterScript.write(makeMethodArr)
    masterScript.write("void Start()\n{\n")
    masterScript.write('leftskate = (GameObject) Resources.Load("leftskate");\n')
    masterScript.write('rightskate = (GameObject) Resources.Load("rightskate");\n')
    masterScript.write('forceline = (GameObject) Resources.Load("ForceLine");\n')
    masterScript.write('moveline = (GameObject) Resources.Load("MoveLine");\n')
    masterScript.write("}\n")
    masterScript.write("void Update()\n{\n")
    masterScript.write("if (Input.GetKey(KeyCode.R))\n")
    masterScript.write("{\n")
    for i in range(2):
        masterScript.write("Destroy(skate" + str(i) +");\n")
        masterScript.write("Destroy(forceline" + str(i) +");\n")
        masterScript.write("Destroy(moveline" + str(i) +");\n")
    masterScript.write("frameCount = 0;\n")
    masterScript.write("}\n")
    masterScript.writelines(["if (frameCount < " + str(len(script)) + ")\n","{\n", "transform.position = camerapos[frameCount];\n", "frames[frameCount].visualize();\n","frameCount++;\n","}\n","}\n","}\n"]) 
    masterScript.close()