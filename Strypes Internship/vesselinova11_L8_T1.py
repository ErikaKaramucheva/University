import sys

def func(x):
    return x*x*x+3*x-5

def notOpposite(a,b):
    if func(a)*func(b)>=0.0:
        raise Exception('f(a) and f(b) should have opposite signs')
        exit(1)
def bisection(a,b,f):
    try:
        a = float(a)
        b = float(b)
    except ValueError:
        print('a and b must to be numbers')
        exit(1)
    notOpposite(a,b)
    while (b-a)/2:
        c=(a+b)/2
        if f(c)==0:
           return (round(c,3))
        elif f(a)*f(c)<0:
            b=c
        else:
            a=c
    return (round(c,3))

