import sys
def check_palindrome(word):
   if len(word) < 1:
      return True
   else:
      if word[0] == word[-1]:
         return check_palindrome(word[1:-1])
      else:
         return False

given_word=sys.argv[1]
result=check_palindrome(given_word)
print(result)