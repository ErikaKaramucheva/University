import sys

def caesarCipper(text,shift):
   result=""
   for i in range(len(text)):
      char=text[i]
      result+=chr(ord(char)+shift%26)
   return result

text=sys.argv[1]
shift=int(sys.argv[2])
res=caesarCipper(text,shift).upper()
print(res)

