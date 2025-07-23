import sys
def check(s1, s2):
    # the sorted strings are checked
    if (sorted(s1) == sorted(s2)):
        print("True")
    else:
        print("False")

s1=sys.argv[1]
s2=sys.argv[2]
check(s1,s2)