import unittest
import Context


class UtState(unittest.TestCase):

    def test_state(self):
        expectedFinalState = "Done(已完成)"
        actualFinalState = ""

        context = Context.Context()
        while (context.currentState != None):
            actualFinalState = str(context.currentState)
            print("需求目前狀態="+ actualFinalState)
            context.action()
            
        self.assertEqual(actualFinalState, expectedFinalState)



if __name__ == '__main__':
    unittest.main()
