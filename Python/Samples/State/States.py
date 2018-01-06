from abc import ABC, abstractmethod
import Context

class State(ABC):
    @abstractmethod
    def action(self,context=Context):
        pass

class StateToDo(State):
    def __str__(self):
        return "TODO(待做事項)"

    def action(self,context=Context):
        
        # Do something...

        # Set next state
        context.currentState = StateWorking()
        print("The requirement is on TODO list, send email to IT manager.");

class StateWorking(State):
    def __str__(self):
        return "Working(進行中)"

    def action(self,context=Context):
        
        # Do something...

        # Set next state
        context.currentState = StateTesting()
        print("The requirement is completed, send email to users!");


class StateTesting(State):
    def __str__(self):
        return "Testing(測試中)"

    def action(self,context=Context):
        
        # Do something...

        # Set next state
        context.currentState = StateDone()
        print("Test ok, send email to operation team!");


class StateDone(State):
    def __str__(self):
        return "Done(已完成)"

    def action(self,context=Context):
        
        # Do something...

        # Set next state
        context.currentState = None
        print("Close the requirement, send email to all stakeholders!");