def solve (a,b,c):
   if a==0:
        if b!=0:
            x1=-c/b
            print (x1)
            quit()
        else:
            print("special case")
            quit()
   d=b*b-(4*a*c)
   if d==0:
       x1 = -b/(2*a)
       print(x1)
   elif d>0:
       x1 = (-b + math.sqrt(d))/(2*a)
       x2 = (-b - math.sqrt(d))/(2*a)
       print ("%f | %f" %(x1,x2))
       #print(x2)
   else:
       print("no real roots")


import math
import sys

a = float(sys.argv[1])
b = float(sys.argv[2])
c = float(sys.argv[3])
solve(a, b, c)
