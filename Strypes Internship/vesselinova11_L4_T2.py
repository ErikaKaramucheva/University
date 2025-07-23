import sys
word=sys.argv[1]
key={}
for i in word:
    if i in key:
        key[i]+=1
    else:
        key[i]=1
print(key)