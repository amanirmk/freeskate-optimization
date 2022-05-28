import freeline as f
import numpy as np
from copy import deepcopy as dc
from scipy.optimize import differential_evolution, basinhopping
import matplotlib.pyplot as plt

initguess =  [4, 2, 1.25] + [3, 2, 2.5] + [4, 2, 3.75] + [3, 2, 5] + [5, 2, 3.75] + [0, 0, 0] + [5, 2, 1.25] + [0, 0, 0] + [0.25*np.pi] + [-0.25*np.pi]
bounds = [(0, 20), (0, 20), (0, 10)]*8 + [(-np.pi, np.pi)]*2

def vary_vals(initguess, bounds, tag=""):
    for var_i, [lower, upper] in enumerate(bounds):
        vals = np.linspace(lower, upper, 500)
        scores = []
        for val in vals:
            params = dc(initguess)
            params[var_i] = val
            scores.append(f.objfunc(params))
        plt.style.use('ggplot')
        fig = plt.figure(figsize=(4,4))
        plt.plot(vals, scores)
        plt.xlabel("param values")
        plt.ylabel("objective function")
        plt.title("Parameter " + str(var_i+1))
        fig.savefig("{}param{}.png".format(tag, var_i+1), bbox_inches='tight', pad_inches=0)
        plt.close('all')

def refine_initial(initguess, bounds):
    newguess = dc(initguess)
    optimized = False
    iterations = 0
    while not optimized:
        old_min = f.objfunc(newguess)
        for var_i, [lower, upper] in enumerate(bounds):
            vals = np.linspace(lower, upper, 500)
            best_val = newguess[var_i]
            min_func = f.objfunc(newguess)
            for val in vals:
                newguess[var_i] = val
                if f.objfunc(newguess) < min_func:
                    best_val = val
            newguess[var_i] = best_val
        if min_func == old_min:
            print("optimization result:", newguess)
            print("value of objective function:", min_func)
            print("number of iterations:", iterations)
            optimized = True
        else:
            print("current minimum:", min_func)
            old_min = min_func
            iterations += 1
    return newguess

# de_res = differential_evolution(f.objfunc, bounds, maxiter=3000)
# print("DIFFERENTIAL EVOLUTION")
# print(de_res)
# vary_vals(de_res.x, bounds, tag="DE")
# refine_initial(de_res.x, bounds)
# print()

# bh_res = basinhopping(f.objfunc, initguess, niter=300)
# print("BASIN HOPING")
# print(bh_res)
# vary_vals(bh_res.x, bounds, tag="BH")
# refine_initial(bh_res.x, bounds)
# print()

# both_res = basinhopping(f.objfunc, de_res.x, niter=300)
# print("BOTH")
# print(both_res)
# vary_vals(both_res.x, bounds, tag="DEBH")
# refine_initial(both_res.x, bounds)
# print()

# creates animation and prints score of running w initial guess
print(f.objfunc(initguess, True))