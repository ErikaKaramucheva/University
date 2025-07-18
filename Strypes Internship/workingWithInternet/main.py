import tkinter
from tkinter import *
from tkinter import ttk
import requests
URL='https://slashdot.org/slashdot.rss'
response=requests.get(URL)
open('file.txt','wb').write(response.content)


window=Tk()
window.title("Window")
window.config(padx=100,pady=100)
data={}
with open('file.txt') as file:
    for f in file:
        data[f]=
list_box=Listbox(window)
list_box.grid(column=0,columnspan=2,row=0,rowspan=6)

info_label=Label(window)
info_label.grid(column=3,columnspan=2,row=0,rowspan=6)

window.mainloop()
