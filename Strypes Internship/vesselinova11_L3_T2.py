import sys
def caesarCipper(text, shift):
    result = ""
    for i in range(len(text)):
        char = text[i].lower()
        result += chr((ord(char) + shift - 97) % 26 + 97)
    return result
def vigenere(text, shift):
    result=""
    for i in range(len(text)):
        char = text.lower()[i]
        shifted_letter = key[i % len(key)]
        shift = ord(shifted_letter) - 97
        result += caesarCipper(char, shift)
    return result

plaintext=sys.argv[1]
key=sys.argv[2]
result=vigenere(plaintext,key).upper()
print(result)

