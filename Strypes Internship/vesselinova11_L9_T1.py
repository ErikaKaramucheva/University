import sys
fileOne=sys.argv[1]
fileTwo=open(sys.argv[2],'w')

with open(fileOne,'r') as file:
    for line in sorted(file):
        fileTwo.write(line)
fileTwo.close()