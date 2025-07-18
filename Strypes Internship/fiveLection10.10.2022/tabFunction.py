#x = V:cos(alf).t
#y = V:sin(alf).t -1/2g.t.t

class Projectile:
    mass:float
    x:float
    y:float

    def __init__(self,mass,x):
        self.mass=mass
        self.x=x
        self.y=0

    #def move(self,t,x,y):

