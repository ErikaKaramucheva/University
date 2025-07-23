import sys
inputList=sys.argv[1:]
result=[]
length=len(inputList)
for i in inputList:
    if i not in result:
        result.append(i)
for i in range(len(result)):
    print(result[i])