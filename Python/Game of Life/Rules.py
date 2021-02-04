import sys
'''Rules module'''

def rulesList():
    print('\n~~~~~~~~~~~~~~~~CONWAY\'S GAME OF LIFE~~~~~~~~~~~~~~~~\n')
    print('\nRULES OF THE GAME\n')
    print('1. Any live cell with two or three live neighbours will survive to the next generation.')
    print('2. Any dead cell with three live neighbours comes back to life in the next generation.')
    print('3. All other live cells die in the next generation and all other dead cells remain dead.')
    print('\nSPECIFICS OF THIS PROGRAM\n')
    print('- The playing area is rectangular with a size chosen by you, the user.')
    print('- Each generation is formed after each \'tick\'. The frequency of these is controlled by the user. ')
    print('- Each generation is displayed by a grid of O\'s and -\'s with O denoting a living cell and - marking a dead cell.')
    print('- The first generation of living cells are chosen at random.')
    print('- No more than half of the population will be alive from the start.')
    input('\nPlease press any key to return to the main menu')