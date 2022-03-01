from cx_Freeze import setup, Executable
import matplotlib
import sys
base = None    
if sys.platform == 'win32':
    base = "Win32GUI"

 
executables = [Executable("autoword.py", base=base)]
 
packages = ["idna", "speech_recognition", "pyautogui", "pygame"]
options = {
    'build_exe': {    
        'packages':packages,
    },    
}
 
setup(
    name = "autoWord",
    options = options,
    version = "0.11",
    description = 'autoWord',
    executables = executables
)