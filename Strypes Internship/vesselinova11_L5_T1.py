import sys
term = {0:0,1:1}
def fib(n):
    if n <= 1:
        return n
    if n in term:
        return term[n]
    else:
        term[n] = fib(n - 1) + fib(n - 2)
        return term[n]

f_num=int(sys.argv[1])
s_num=int(sys.argv[2])
while f_num<s_num:
   result=fib(f_num)
   print(result)
   f_num+=1
#[2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181]