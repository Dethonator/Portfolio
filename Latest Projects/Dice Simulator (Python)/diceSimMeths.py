# ~~~ Dice method definitions ~~~

def chooseDice():   #Method to select of valid number of dice to create
    while True:
        try:
            diceNo = int(input("How many dice would you like? "))
            if diceNo <= 0:
                raise ValueError
        except ValueError:
            print("That is an invalid choice. You can only choose a positive whole number of dice. Please try again.")
            continue
        else:
            print("\nYou have chosen to have " + str(diceNo) + " dice.\n")
            return diceNo
            break

def chooseSize(i):  #Method to choose size of each dice
    while True:     #Loop for user to select a valid number of sides for each die
        try:
            print("DIE NO " + str(i+1))
            sides = int(input("How many sides would you like this die to have? "))
            if sides <= 0:
                raise ValueError
        except ValueError:
            print("That is an invalid choice. A die must have a positive whole number of sides! Please try again.")
            continue
        else:
            print("\nYou have selected a " + str(sides) + "-sided die.\n")
            return sides
            break