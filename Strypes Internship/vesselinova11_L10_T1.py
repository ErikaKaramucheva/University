import tkinter
from tkinter import *
from tkinter import ttk

def calculateBmi():
    kg=float(weight.get())
    m=float(height.get())/100
    if kg<1.0 or m<0.01:
        bmi_lab.config(text="Invalid parameters")
    else:
       bmi=kg/(m*m)
       bmi=round(bmi,1)
       categoriesBMI(bmi)
       bmi_lab.config(text="Your bmi: " + str(bmi))

def categoriesBMI(bmi):
    if bmi<18.5:
        result_labael.config(text='- Underweight',foreground='red')
    elif bmi >= 18.5 and bmi<=24.9:
        result_labael.config(text='- Healthy Weight',foreground='red')
    elif bmi >=25 and bmi<=29.9:
        result_labael.config(text='- Overweight',foreground='red')
    else:
        result_labael.config(text='- Obese',foreground='red')


window=Tk()
window.title("BMI_Calculator")
window.config(padx=50, pady=50)

height_l=Label(text="Height: ")
height_l.grid(row=0,column=0)
weight_l=Label(text="Weight: ")
weight_l.grid(row=1,column=0)

inp_height=IntVar()
inp_weight=IntVar()
weight=Entry(width=30,textvariable=inp_weight)
weight.grid(row=1,column=1,columnspan=3,sticky='WE')
height=Entry(width=30,textvariable=inp_height)
height.grid(row=0,column=1,columnspan=3,sticky='WE')
bmi_lab=Label(text="Your BMI: ")
bmi_lab.grid(row=3,column=1)
result_labael=Label()
result_labael.grid(row=3,column=2)
calculateButton=Button(text="Calculate", command=lambda :calculateBmi())
calculateButton.grid(row=4,column=1,columnspan=2)


window.mainloop()

