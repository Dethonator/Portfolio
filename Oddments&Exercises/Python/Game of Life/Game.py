from grid import Grid
'''Game module'''
activegrid = []

#Game method
def runGame():
    print("\nNew game started.\n")
    x = int(input("How wide would you like the grid of cells to be? "))
    y = int(input("How long would you like the grid to be? "))
    print("\n" + str(x) + " x " + str(y) + " grid chosen")
    activeGrid = Grid(x, y)
    activeGrid.printGrid()
    
    #prompt user to perform a tick method or to return to the main menu
    choice = ''
    while choice != 'q':
        choice = input('Press any key to initialise a \'tick\' or enter \'q\' to return to the main menu: ')
        if choice == '':
            activeGrid.tick()
            activeGrid.printGrid()
