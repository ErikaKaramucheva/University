import unittest
from vesselinova11_L8_T1.py import func, bisection

class firstTest(unittest.TestCase):
   def testOne(self):
       res=bisection('a','b')
       self.assertEqual(res,'a and b must to be numbers')
   def testTwo(selfself,a,b):
       rOne=func(a)
       rTwo=func(b)
       if(rOne*rTwo>=0):
           self.assertEqual('f(a) and f(b) should have opposite signs')