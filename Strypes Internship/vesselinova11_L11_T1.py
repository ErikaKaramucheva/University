import math
import tkinter
from tkinter import *
from tkinter import ttk
from turtledemo.__main__ import font_sizes

first_number=''
second_number=''
global result
signs=''
i=0 #variable for input data
memory=[]
n=0 #variable for memory list

def press_num(num):
    global i
    inp.insert(i,num)
    i+=1
    global first_number
    global second_number
    if first_number=='':
        first_number=inp.get()
    else:
        second_number=inp.get()

def memory_plus():
    global memory
    global n
    memory[n]=inp.get()
    n+=1

def memory_minus():
    global memory
    global n
    memory[n]=0
    n-=1

def memory_clear():
    global memory
    global n
    memory = []
    n = 0

def memory_retrieval():
    global memory
    global n
    inp.insert(1,memory[n])

def aggregate_function(sign):
   global signs
   global i
   i+=1
   inp.insert(i,sign)
   global result
   if sign=='+':
        signs = '+'
        if result != 0:
           result=result+second_number
        else:
            result=first_number+second_number
   elif sign=='-':
        signs = '-'
        if result==0:
           result=first_number-second_number
        else:
            result-=second_number
   elif sign=='*':
        if result==0:
           result=first_number*second_number
        else:
            result=result*second_number
   elif sign=='/':
        if second_number==0:
            raise Exception("No division by zero")
        elif result==0:
            result=first_number/second_number
        else:
            result=result/second_number
   return result

def result():
    global result
    global i
    inp.delete(0,END)
    inp.insert(0,result)
    result=0
    i=0

def change():
    global i
    i-=1
    inp.delete(i,END)
    global signs
    if signs=="+":
        aggregate_function('-')
        inp.insert(i,'-')
    elif signs=='-':
        aggregate_function('+')
        inp.insert(i,'+')

def clear_all():
    global i
    i=0
    inp.delete(0,END)

def fac():
    global i
    i+=1
    inp.insert(i,'!')
    f_num=first_number
    result=1
    for t in range(first_number):
        result*=f_num
        f_num-=1
    return result

def sqrt():
    global result
    global i
    i+=1
    result=math.sqrt(float(inp.get()))
    inp.insert(i,' sqrt')

def clear_entry():
    global i
    inp.delete(i,END)
    i-=1

window=Tk()
window.title("Calculator")
window.config(padx=50, pady=50,background='black')

inp=Entry(window)
inp.grid(column=0,columnspan=3,row=0,sticky='NSEW')

mc_Button=Button(text='MC',width=4,height=2,command=lambda :memory_clear())
mc_Button.grid(column=0,row=1)
m_plus_Button=Button(text='M+',width=4,height=2,command=lambda:memory_plus())
m_plus_Button.grid(column=1,row=1)
m_minus_Button=Button(text='M-',width=4,height=2,command=lambda:memory_minus())
m_minus_Button.grid(column=2,row=1)
mr_Button=Button(text="MR",width=4,height=2,command=lambda:memory_retrieval())
mr_Button.grid(column=0,row=2)

ce_Button=Button(text="CE",width=4,height=2,command=lambda :clear_entry())
ce_Button.grid(column=1,row=2)
ac_Button=Button(text='AC',width=4,height=2,command=lambda:clear_all())
ac_Button.grid(column=2,row=2)

plus_Button=Button(text='+', command=lambda : aggregate_function('+'),width=4,height=2)
plus_Button.grid(column=3,row=4)
minus_Button=Button(text='-',command=lambda:aggregate_function('-'),width=4,height=2)
minus_Button.grid(column=3,row=3)
mult_Button=Button(text='*',command=lambda:aggregate_function('*'),width=4,height=2)
mult_Button.grid(column=3,row=2)
division_Button=Button(text='/',command=lambda :aggregate_function('/'),width=4,height=2)
division_Button.grid(column=3,row=1)

zero_Button=Button(text='0',command=lambda :press_num(0),width=4,height=2)
zero_Button.grid(column=2,row=6)
one_Button=Button(text='1',command=lambda:press_num(1),width=4,height=2)
one_Button.grid(column=0,row=5)
two_Button=Button(text='2',command=lambda :press_num(2),width=4,height=2)
two_Button.grid(column=1,row=5)
three_Button=Button(text='3',command=lambda :press_num(3),width=4,height=2)
three_Button.grid(column=2,row=5)
four_Button=Button(text='4',command=lambda :press_num(4),width=4,height=2)
four_Button.grid(column=0,row=4)
five_Button=Button(text='5',command=lambda:press_num(5),width=4,height=2)
five_Button.grid(column=1,row=4)
six_Button=Button(text='6',command=lambda :press_num(6),width=4,height=2)
six_Button.grid(column=2,row=4)
seven_Button=Button(text='7',command=lambda:press_num(7),width=4,height=2)
seven_Button.grid(column=0,row=3)
eight_Button=Button(text='8',command=lambda:press_num(8),width=4,height=2)
eight_Button.grid(column=1,row=3)
nine_Button=Button(text='9',command=lambda:press_num(9),width=4,height=2)
nine_Button.grid(column=2,row=3)

point_Button=Button(text='.',width=4,height=2,command=lambda: press_num('.'))
point_Button.grid(column=1,row=6)
sqrt_Button=Button(text='sqrt',width=4,height=2,command=lambda :sqrt())
sqrt_Button.grid(column=3,row=5)
fac_Button=Button(text='n!',width=4,height=2,command=lambda:fac())
fac_Button.grid(column=3,row=6)
change_Button=Button(text='+/-',width=4,height=2,command=lambda:change())
change_Button.grid(column=0,row=6)
sum_Button=Button(text='=',width=4,height=2,command=lambda:result())
sum_Button.grid(column=3,row=0)

window.mainloop()