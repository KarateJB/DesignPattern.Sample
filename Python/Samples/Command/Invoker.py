from Commands import Command

class Invoker:
    def __init__(self):
        self.commands=[]
    
    def addCommand(self, cmd:Command):
        self.commands.append(cmd)

    def cancelCommand(self, cmd:Command):
        self.commands.remove(cmd)

    def invoke(self):
        for cmd in self.commands:
            cmd.execute()