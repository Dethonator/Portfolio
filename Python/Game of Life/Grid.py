from cell import Cell
from random import randint

class Grid:
    'Game grid class'
    def __init__(self, rows, columns):
        self.rows = rows
        self.columns = columns
        self.grid = [[Cell() for colCells in range(self.columns)] for rowCells in range(self.rows)]
        self.createGrid()

    #Method to create initial empty grid layout
    def printGrid(self):
        print('\n' * 10)
        print('Creating grid...')
        for row in self.grid:
            for column in row:
                print(column.getChar(), end='')
            print()

    #Method that populates grid with 1/3 chance of cells being alive
    def createGrid(self):
        for row in self.grid:
            for col in row:
                randomNo = ranint(0, 2)
                if randomNo == 1:
                    col.setAlive()

    #Method to check/return list of which cells are neighbours i.e. which cells are +1/-1 row/column away
    def isNeighbour(self, rowCheck, colCheck):
        neighbourList = []
        for row in range(-1, 2):
            for col in range(-1, 2):
                neighbourRow = rowCheck + row
                neighbourCol = colCheck + col
                isANeighbour = True

                if (neighbourRow == rowCheck) and (neighbourCol == colCheck):
                    isANeighbour = False

                if (neighbourRow < 0) or (neighbourRow >= self.rows):
                    isANeighbour = False

                if (neighbourCol < 0) or (neighbourCol >= self.columns):
                    isANeighbour = False

                if isANeighbour:
                    neighbourList.append(self.grid[neighbourRow][neighbourCol])
        return neighbourList

    #Tick method
    def tick(self):
        print('Tick occurring...')
        survivors = []
        casualties = []

        for row in range(len(self.grid)):
            for col in range(len(self.grid[row])):
                isANeighbour = self.isNeighbour(row, col)

                survivorCount = []

    #Establishing living/dead status of neighbours and populating survivor list
                for cell in isANeighbour:
                    if cell.getLiving():
                        survivorCount.append(cell)

                cellInstance = self.grid[row][column]
                cellInstanceLiving = cellInstance.getLiving()

    #Check of living/dead status of neighbours if current cell is alive
                if cellInstanceLiving == True:
                    if (len(survivorCount) < 2) or (len(survivorCount) > 3):
                        casualties.append(cellInstance)

                    if (len(survivorCount) == 2) or (len(survivorCount) == 3):
                        survivors.append(cellInstance)

                else:
                    if len(living_neighbours_count) == 3:
                        survivors.append(cellInstance)

    for cell in survivors:
        cell.setAlive()

    for cell in casualties:
        cell.setDead()
