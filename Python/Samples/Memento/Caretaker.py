from Mementos import Memento, EflowMemento
from Originators import Originator, EflowOriginator
from Memento_models import Eflow


class Caretaker:
    def __init__(self):
        self.store = {}

    def add(self, key="", memento=Memento):
        self.store[key] = memento
        print("儲存一張表單! 建立日期{0}，內容: {1}".format(
            memento.eflow.createOn, memento.eflow.formData))

    def get(self, key=""):
        restoredMemento = self.store[key]
        print("回存一張表單! 建立日期{0}，內容: {1}".format(
            restoredMemento.eflow.createOn, restoredMemento.eflow.formData))
        return restoredMemento
