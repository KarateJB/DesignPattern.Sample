import unittest
import datetime
from Memento_models import Eflow
from Mementos import Memento,EflowMemento
from Originators import Originator, EflowOriginator
from Caretaker import Caretaker

class UtMemento(unittest.TestCase):

    def test_memento(self):
        caretaker = Caretaker()
            
        originator = EflowOriginator()
        originator.eflow = Eflow(
                createOn = datetime.datetime.now(), 
                formData = "簽呈：工程師Hachi申請加薪$3,000!")

        # 第一次建立備忘
        memento = originator.createMemento() 
        # 第一次儲存備忘
        caretaker.add("Hachi的新年新希望" , memento)
            
        # 老闆收到表單，找Hachi約談並施展三寸不爛之舌，只同意加薪$30
        originator.eflow.createOn = originator.eflow.createOn + datetime.timedelta(0,2)
        originator.eflow.formData = "簽呈：工程師Hachi申請加薪$30!" 

        # 第二次建立備忘
        memento = originator.createMemento()
        # 第二次儲存備忘
        caretaker.add("Hachi的新年新希望v2" , memento)

        # 有新公司找Hachi過去，Hachi準備提離職，老闆趕緊同意先前條件
        # Hachi調出之前該單的備忘回存
        mementoOld = caretaker.get("Hachi的新年新希望")
        originator.restoreMemento(mementoOld)

        self.assertEqual(originator.eflow.formData,  "簽呈：工程師Hachi申請加薪$3,000!")


if __name__ == '__main__':
    unittest.main()
