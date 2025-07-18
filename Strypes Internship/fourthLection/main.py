import sys
global x
def findFibonacciNumbers(n):
    if n<=1:
        return n
    else:
        x= findFibonacciNumbers(n-1)+findFibonacciNumbers(n-2)
        return x

number=int(input())
for i in range(number):
    print(findFibonacciNumbers(i))

result=findFibonacciNumbers(9)
print(result)