import sys
def power(number, p):
    if p==0:
        return 1
    if p>=1:
        return number*power(number,p-1)

#number=int(sys.argv[1])
#pow=int(sys.argv[2])
number=int(input())
pow=int(input())
result=power(number,pow)
print(result)