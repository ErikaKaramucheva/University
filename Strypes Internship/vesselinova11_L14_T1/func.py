import PIL
from PIL import Image
def size(img):
    size=img.size
    return size

def name(img):
    name=img.filename
    return name

def format(img):
    format=img.format
    return format

def color(img):
    rgb=img.convert('RGB')
    r,g,b=rgb.getpixels(rgb)
    return r,g,b


def save(img):
    img.save('img.png')

def rotate(img):
    res=img.rotate(90)
    return res

def horizontal_rotate(img):
    res=img.transpose(Image.FLIP_LEFT_RIGHT)
    return res

def vertial_rotate(img):
    res=img.transpose(Image.FLIP_TOP_BOTTOM)
    return res
