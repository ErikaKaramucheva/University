import sys
stem=sys.argv[1]
word=sys.argv[2]
dict={}

with open(stem) as f:
  for line in f:
      key,value=line.split(":")
      dict[key]=value

if word in dict:
    print(dict[word])
else:
    print("not in dictionary")
