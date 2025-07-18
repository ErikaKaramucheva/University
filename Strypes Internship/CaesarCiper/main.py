#text="meet me at"
#result=""
#for i in range(len(text)):
#    char=text[i]
#    result+=chr(ord(char)+3%26)
#print(result)

text="attackatdown"
key="lemon"
result=""
for i in range(len(text)):
    for j in range(len(key)):
       shift=ord(j)-(ord('a'))
       pos=ord('a')+(ord(i)-ord('a')+shift)%26
       result.__add__(chr(pos))
print(result)