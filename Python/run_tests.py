import sys
sys.path.append("./Samples/Adapter/")
sys.path.append("./Samples/Bridge/")
sys.path.append("./Samples/Builder/")
sys.path.append("./Samples/ChainOfResponsibility/")
sys.path.append("./Samples/Command")
sys.path.append("./Samples/Composite")
sys.path.append("./Samples/Decorator")
sys.path.append("./Samples/Facade")
sys.path.append("./Samples/Factory")
sys.path.append("./Samples/Flyweight")
sys.path.append("./Samples/Interpreter/")
sys.path.append("./Samples/Iterator")
sys.path.append("./Samples/Mediator")
sys.path.append("./Samples/Memento")
sys.path.append("./Samples/Observer")
sys.path.append("./Samples/Prototype")
sys.path.append("./Samples/Proxy")
sys.path.append("./Samples/Singleton")
sys.path.append("./Samples/State")
sys.path.append("./Samples/Template")
sys.path.append("./Samples/Visitor")

import unittest

# if __name__ == "__main__":
suite = unittest.TestLoader().discover('.', pattern = "Ut*.py")
unittest.TextTestRunner(verbosity=2).run(suite)