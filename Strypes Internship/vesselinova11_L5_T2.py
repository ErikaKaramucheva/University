import sys
def pow(number,power):
    if power==0:
        return 1
    if power>=1:
        return number*pow(number,power-1)

number=int(sys.argv[1])
power=int(sys.argv[2])
result=pow(number,power)
print(result)