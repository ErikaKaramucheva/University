import kivy
from kivy.app import App
from kivy.uix.label import Label
from kivy.lang import Builder
kivy.require('2.1.0')
pres=Builder.load_file('main.kv')

class RandomNumber(App):
  def build(self):
    return pres

randomApp = RandomNumber()
randomApp.run()