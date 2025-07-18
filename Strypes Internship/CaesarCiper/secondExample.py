import sys
items={1:"one",2:"two",3:"three",3:"one" ,4:"four"}
#values=sys.argv
values=input()
for i in items:
    if items[i]==values:
        print(i)