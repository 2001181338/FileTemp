from pynput.keyboard import Listener
import pyautogui
from tkinter import *
import tkinter as tk

dicNumber  = {
	"<96>" : "0",
	"<97>" : "1",
	"<98>" : "2",
	"<99>" : "3",
	"<100>" : "4",
	"<101>" : "5",
	"<102>" : "6",
	"<103>" : "7",
	"<104>" : "8",
	"<105>" : "9",
}
dic = {}
window = Tk()
def pressKeyboard(key):
	key = str(key)
	if key == "Key.f12":
		dic.clear()
		raise SystemExit(0)
	try:
		key = dicNumber[key]
	except:
		key = key
	# Search in dictionary
	print(dic)
	print(key)
	try:
		content = dic[key.replace("'", '')]
		pyautogui.typewrite(content)
		print("Success")
	except:
		print("Fail")
		
window.title("Keyboard Shortcuts")
window.geometry('800x400')
window.option_add('*Times New Roman', '18')

txtChuoi = Label(window, text="Chuỗi phím tắt")
txtChuoi.place(x=40, y=20)
txtChuoi.config(font=("Times New Roman", 18))

txtChuoi = Label(window, text="Phím tắt")
txtChuoi.place(x=280, y=20)
txtChuoi.config(font=("Times New Roman", 18))

txtChuoi = Label(window, text="Mô tả")
txtChuoi.place(x=520, y=20)
txtChuoi.config(font=("Times New Roman", 18))

valInputChuoi1 = tk.StringVar()
valPhimTat1 = tk.StringVar()

inputChuoi1 = Entry(window,width=24, textvariable=valInputChuoi1)
inputChuoi1.place(x=40, y=80)

inputPhimTat1 = tk.Entry(window,width=24, textvariable=valPhimTat1)
inputPhimTat1.place(x=280, y=80)

inputMoTa1 = Entry(window,width=24)
inputMoTa1.place(x=520, y=80)

def startKeyPress():
	dic[valPhimTat1.get()] = inputChuoi1.get()
	with Listener(on_press=pressKeyboard) as listener:
		listener.join()

btnStart = Button(window, text="Bắt đầu", command=startKeyPress)
btnStart.place(x=20, y=200)

window.mainloop()


