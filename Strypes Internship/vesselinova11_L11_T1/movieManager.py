import tkinter
from tkinter import *
from tkinter import ttk
from PIL import ImageTk, Image
from functionality import *

window = Tk()
window.title("Movies")
window.config(pady=150, padx=160)

menu_bar = Menu(window)
window.config(menu=menu_bar)

file_menu = Menu(menu_bar)
menu_bar.add_cascade(label='File', menu=file_menu)
file_menu.add_command(label="New", command='')
file_menu.add_command(label="Open", command='')
file_menu.add_command(label="Save", command='')

edit_menu = Menu(menu_bar)
menu_bar.add_cascade(label='Edit', menu=edit_menu)
edit_menu.add_command(label='Cut', command='')
edit_menu.add_command(label='Add books', command='')
edit_menu.add_command(label='Add movies', command='')
edit_menu.add_command(label='Add games', command='')
edit_menu.add_command(label='Delete books', command='')
edit_menu.add_command(label='Delete movies', command='')
edit_menu.add_command(label='Delete games', command='')

collection_menu = Menu(menu_bar)
menu_bar.add_cascade(label='Collections', menu=collection_menu)
collection_menu.add_command(label='Books', command='')
collection_menu.add_command(label='Movies', command='')
collection_menu.add_command(label='Games', command='')

help_menu = Menu(menu_bar)
menu_bar.add_cascade(label='Help', menu=help_menu)
help_menu.add_command(label='Help', command='')

search_label = Label(text='Search')
search_label.grid(row=0, column=0, columnspan=3)
search_button = Button(text='Search')
search_button.grid(row=0, column=3)
add_button = Button(text='Add')
add_button.grid(row=0, column=4)
delete_button = Button(text='Delete')
delete_button.grid(row=0, column=5)
upgrade_button = Button(text='Upgrade')
upgrade_button.grid(row=0, column=6)
movie_list_box = Listbox(window)
movie_list_box.grid(row=1, column=0, columnspan=6)
with open('movie.json') as file:
    for f in file:
        movie_list_box.insert(f)

window.mainloop()