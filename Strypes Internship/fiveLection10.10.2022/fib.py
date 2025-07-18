import itertools
class Fibs:
    f0:int
    f1:int
    def __init__(self):
       self.f0=0
       self.f1=1
    def __next__(self):
       self.f0=self.f0+1
       self.f1=self.f1*self.f0
       return self.f1
    def __iter__(self):
        return self

fibs=Fibs()
for f in fibs:
    if f<1000:
        print(f.next())
        break