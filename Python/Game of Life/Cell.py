class Cell:
    'Cell status class'
    def __init__(self):
        self._living = 'Dead'
    
    #Setters
    def setDead(self):
        self.living = 'Dead'
    def setAlive(self):
        self.living = 'Alive'

    #Getters
    def getLiving(self):
        if self.living == 'Alive':
            return True
        return False
    def getChar(self):      #getter for which character to print
        if self.getLiving():
            return 'O'
        return '-'