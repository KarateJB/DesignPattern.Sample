import datetime

class Eflow:
    def __init__(self, createOn=datetime.datetime, formData=""):
        self.createOn = createOn 
        self.formData = formData
