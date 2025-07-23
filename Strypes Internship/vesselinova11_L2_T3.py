import sys
inputList=sys.argv[1:]
length=len(inputList)
for i in range(length):
    k=i+1
    while k<length:
       if inputList[i]==inputList[k]:
          print("True")
          quit()
       k+=1
print("False")