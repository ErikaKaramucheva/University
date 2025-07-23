import tkinter
from tkinter import *
from tkinter import ttk
from PIL import ImageTk,Image

def open_manager(collection):
    if collection=='book':
        window.destroy()
        open('bookManager.py')
    elif collection=='game':
        window.destroy()
        open('game.json')
    else:
        window.destroy()
        open('movie.json')

window=Tk()
window.title("Collection manager")
window.config(pady=150,padx=160)

menu_bar = Menu(window)
window.config(menu=menu_bar)

file_menu=Menu(menu_bar)
menu_bar.add_cascade(label='File',menu=file_menu)
file_menu.add_command(label="New",command='')
file_menu.add_command(label="Open",command='')
file_menu.add_command(label="Save",command='')

edit_menu=Menu(menu_bar)
menu_bar.add_cascade(label='Edit',menu=edit_menu)
edit_menu.add_command(label='Cut',command='')
edit_menu.add_command(label='Add books',command='')
edit_menu.add_command(label='Add movies',command='')
edit_menu.add_command(label='Add games',command='')
edit_menu.add_command(label='Delete books',command='')
edit_menu.add_command(label='Delete movies',command='')
edit_menu.add_command(label='Delete games',command='')

collection_menu=Menu(menu_bar)
menu_bar.add_cascade(label='Collections',menu=collection_menu)
collection_menu.add_command(label='Books',command='')
collection_menu.add_command(label='Movies',command='')
collection_menu.add_command(label='Games',command='')

help_menu=Menu(menu_bar)
menu_bar.add_cascade(label='Help',menu=help_menu)
help_menu.add_command(label='Help',command='')

welcome_label=Label(text='My Collections',font='AgencyFB 26 italic')
welcome_label.grid(row=1,column=1,columnspan=3)

book_button=Button(text='Books',command=lambda:open_manager('book'))
book_button.grid(row=5,column=1)
book_image=Label()
book_test=ImageTk.PhotoImage(Image.open('book.png'))
book_image.config(image=book_test)
book_image.grid(row=2,rowspan=3,column=1)
movie_button=Button(text='Movies',command=lambda :open_manager('movie'))
movie_button.grid(row=5,column=2)
movie_image=Label()
movie_test=ImageTk.PhotoImage(Image.open('movie.png'))
movie_image.config(image=movie_test)
movie_image.grid(row=2,rowspan=3,column=2)
game_button=Button(text='Games',command=lambda : open_manager('game'))
game_button.grid(row=5,column=3)
game_image=Label()
game_test=ImageTk.PhotoImage(Image.open('game.png'))
game_image.config(image=game_test)
game_image.grid(row=2,rowspan=3,column=3)

window.mainloop()