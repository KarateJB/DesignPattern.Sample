import unittest
from Prototypes import Prototype, PrototypeFatbook, PrototypeGoople
from PrototypeStore import StoreEnum, PrototypeStore


class UtPrototype(unittest.TestCase):

    _goopleP = None
    _fatbookP = None

    def __init__(self, *args, **kwargs):
        super(UtPrototype, self).__init__(*args, **kwargs)
        self._goopleP = PrototypeGoople(
            id=1001,
            name="Goople",
            phone="09XXXXXXX",
            searchEngine="Awesome"
        )

        self._fatbookP = PrototypeFatbook(
            id=2001,
            name="Fatbook",
            phone="09ZZZZZZZZ",
            ads="Many"
        )

    def test_prototype(self):

        # Initialize PrototypeStore
        prototypeStore = PrototypeStore()
        prototypeStore.add(StoreEnum.Goople, self._goopleP)
        prototypeStore.add(StoreEnum.Fatbook, self._fatbookP)

        # region Clone Goople
        newGoople = prototypeStore.get(StoreEnum.Goople)
        print(str(newGoople))
        self.assertEqual(newGoople, self._goopleP)

        # region Clone Fatbook
        newFatbook = prototypeStore.get(StoreEnum.Fatbook)
        print(str(newFatbook))
        self.assertEqual(newFatbook, self._fatbookP)


if __name__ == '__main__':
    unittest.main()
