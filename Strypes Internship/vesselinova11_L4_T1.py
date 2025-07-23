import sys
dictionary={1:'a',2:'b',3:'c',4:'a',5:'d',6:'e',7:'a',8:'b'}
search=sys.argv[1]
res=[i for i in dictionary.keys() if dictionary[i] is search]
print(res)

