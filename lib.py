import os
from PyQt5.QtWidgets import QApplication, QWidget, QPushButton, QVBoxLayout , QMessageBox
from time import sleep as delay



def winpro11():
    os.system("cd C:/Windows/System32")
    os.system("set productKey=W269N-WFGWX-YVC9B-4J6C9-T83GX")
    os.system("cscript slmgr.vbs /ipk %productKey%")
    os.system("cscript slmgr.vbs /skms kms8.msguides.com")
    os.system("cscript slmgr.vbs /ato")
    alert = QMessageBox()
    alert.setText('Win 11 Pro Acdtivated')
    alert.exec()
def winent11():
    os.system("cd C:/Windows/System32")
    os.system("set productKey=NPPR9-FWDCX-D2C8J-H872K-2YT43")
    os.system("cscript slmgr.vbs /ipk %productKey%")
    os.system("cscript slmgr.vbs /skms kms8.msguides.com")
    os.system("cscript slmgr.vbs /ato")
    alert = QMessageBox()
    alert.setText('Win 11 Enterprise Acdtivated')
    alert.exec()
def winhome11():
    os.system("cd C:/Windows/System32")
    os.system("set productKey=TX9XD-98N7V-6WMQ6-BX7FG-H8Q99")
    os.system("cscript slmgr.vbs /ipk %productKey%")
    os.system("cscript slmgr.vbs /skms kms8.msguides.com")
    os.system("cscript slmgr.vbs /ato")
    alert = QMessageBox()
    alert.setText('Win 11 Home Acdtivated')
    alert.exec()