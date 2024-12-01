import os
from time import sleep as delay
from PyQt5.QtWidgets import QApplication, QWidget, QPushButton, QVBoxLayout
from lib import winent11 ,winhome11,winpro11
wid = 360
heig = 100
app = QApplication([])
layout = QVBoxLayout()
window = QWidget()
app.setApplicationDisplayName("Windows 11 Activation")
window.setFixedHeight(500)
window.setFixedWidth(360)
buttonpro = QPushButton("Windows 11 Pro Activation")
buttonent = QPushButton("Windows 11 Enterprise Activation")
buttonhome = QPushButton("Windows 11 Home Activation")
buttonpro.setFixedWidth(wid)
buttonpro.setFixedHeight(heig)
buttonhome.setFixedWidth(wid)
buttonhome.setFixedHeight(heig)
buttonent.setFixedWidth(wid)
buttonent.setFixedHeight(heig)
layout.addWidget(buttonent)
layout.addWidget(buttonhome)
layout.addWidget(buttonpro)
buttonpro.clicked.connect(winpro11)
buttonent.clicked.connect(winent11)
buttonhome.clicked.connect(winhome11)
window.setLayout(layout)
window.show()
app.exec()