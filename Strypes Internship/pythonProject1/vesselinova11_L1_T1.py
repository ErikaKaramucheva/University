def solve (a,b,c):
   d=b*b-(4*a*c)
   if d==0:
       x1 = -b/(2*a)
       print(x1)
   elif d>0:
       x1 = (-b + math.sqrt(d))/(2*a)
       x2 = (-b - math.sqrt(d))/(2*a)
       print ("%f | %f" %(x1,x2))
       #print(x2)
   elif d < 0:
       print("no real roots")
   else :
       print("special case")


import math
a = float(input())
b = float(input())
c = float(input())
solve(a, b, c)

