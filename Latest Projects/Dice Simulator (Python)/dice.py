# ~~~ Dice class definition ~~~

from random import randint

class Dice:
    """Base class for dice"""

    def __init__(self, size):  # Constructor
        self.sides = int(size)
        self.latestRoll = 0

    def roll(self):  # Dice roll method
        rollval = int(randint(0, self.sides))
        print("This die has rolled " + str(rollval) + ".\n")
        self.latestRoll = rollval