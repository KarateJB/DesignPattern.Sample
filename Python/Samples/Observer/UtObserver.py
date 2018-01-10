import unittest
from Observers import Observer, ObserverMailServer, ObserverPbx
from Subjects import Subject, SubjectEflow


class UtVisitor(unittest.TestCase):

    def test_observer(self):

        # Create observers
        pbx = ObserverPbx()
        ms = ObserverMailServer()
            
        # Create subject
        subject = SubjectEflow()
        subject.attach(pbx)
        subject.attach(ms)

        # Notify when JB is leave of absence
        subject.notify("JB", "Hachi")
            
        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()
