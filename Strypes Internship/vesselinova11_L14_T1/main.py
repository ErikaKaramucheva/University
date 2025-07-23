import sys,os
from tkinter import *
from PIL import ImageTk, Image
from func import *

for infile in sys.argv[1:]:
	file= os.path. splitext(infile)[ 0 ] + " .thumbnail "
	if infile!= file:
		try:
			img = Image . open (infile )
		except:
			"Cannot open file"
root = Tk()
root.title("Image Viewer")
root.geometry("500x500")
img.show()
button_exit = Button(root, text="Exit",
					command=root.quit)
button_exit.grid(row=3, column=1)
button_rotate = Button(root, text="Rotate",
					command=lambda: rotate(img))
button_rotate.grid(row=3, column=2)
button_save = Button(root, text="Save",
						command=lambda: save(img))
button_save.grid(row=3, column=3)

root.mainloop()

