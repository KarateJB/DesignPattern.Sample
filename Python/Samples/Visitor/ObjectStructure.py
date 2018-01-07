import Elements
import Visitors


class ObjectStructure:
    def __init__(self):
        self.elements = []

    def attach(self,element: Elements.Element):
        self.elements.append(element)

    def detach(self,element: Elements.Element):
        self.elements.remove(element)

    def accept(self,visitor: Visitors.Visitor):
        for elm in self.elements:
            elm.accept(visitor)
