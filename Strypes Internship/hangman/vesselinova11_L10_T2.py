import sys
import tkinter
from tkinter import *
from tkinter import ttk
from tkinter import messagebox
from string import ascii_uppercase
import random

window = Tk()
window.title('Hangman- GUESS THE COLORS')
word_list=['GREEN','WHITE','BLACK','YELLOW','RED','BLUE','PURPLE','PINK','ORANGE','GOLD','LAVENDER','KHAKI','CYAN',
           'TURQUOISE','BROWN','GRAY']

photos = [PhotoImage(file="hang1.png"), PhotoImage(file="hang2.png"),
          PhotoImage(file="hang3.png"), PhotoImage(file="hang4.png"), PhotoImage(file="hang5.png"),
          PhotoImage(file="hang6.png"), PhotoImage(file="hang7.png")]


def newGame():
    global the_word_withSpaces
    global the_word
    global numberOfGuesses
    numberOfGuesses = 0
    opened.set('')

    the_word = random.choice(word_list)
    the_word_withSpaces=[char for char in the_word]
    newWord=""
    for letter in the_word:
        if letter==the_word_withSpaces[0] or letter==the_word_withSpaces[-1]:
            newWord+=letter
        else:
            newWord+='_'
    lblWord.set(newWord)


def guess(letter):
    global numberOfGuesses
    global opened
    t=opened.get()+letter
    opened.set(t)
    if numberOfGuesses < 6:
        txt = list(the_word_withSpaces)
        guessed = list(lblWord.get())
        if the_word_withSpaces.count(letter) > 0:
            for c in range(len(txt)):
                if txt[c] == letter:
                    guessed[c] = letter
                lblWord.set("".join(guessed))
                if lblWord.get() == the_word:
                    messagebox.showinfo("End", "You guessed it!")
                    return
        else:
            numberOfGuesses += 1
            imgLabel.config(image=photos[numberOfGuesses])
            if numberOfGuesses == 6:
                messagebox.showinfo("End","Game Over")



imgLabel = Label(window)
imgLabel.config(image=photos[0])
imgLabel.grid(row=0, column=0, columnspan=3, padx=10, pady=40)

lblWord = StringVar()
Label(window, textvariable=lblWord,font="Helvetica 20 bold").grid(row=0, column=3, columnspan=6, padx=10)

opened=StringVar()
Label(window,text="Already checked:").grid(row=1,column=2,columnspan=2)
lab = Label(window, textvariable=opened).grid(row=1, column=3, columnspan=3)

n = 0
for c in ascii_uppercase:
    B=Button(window, text=c, command=lambda c=c: guess(c),font=('Helvetica 18'), width=4)
    B.grid(row=2 + n // 9,column=n % 9)
    n += 1

Button(window, text="New\nGame", command=lambda: newGame(), font=("Helvetica 10 bold")).grid(row=4, column=8)

newGame()
window.mainloop()