import sys
inputList=sys.argv[1:]
sortedList=sorted(inputList)
if inputList==sortedList:
    print("sorted")
else:
    print("unsorted")