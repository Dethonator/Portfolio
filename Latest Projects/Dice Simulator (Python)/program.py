# ~~~ Main program ~~~

from dice import Dice
import diceSimMeths

print("Welcome to the dice simulator. This program allows you to choose and then roll a set of dice with any valid number of sides.\n")

diceList = []       #Declaration of empty list to store dice

diceNo = diceSimMeths.chooseDice()  #Method to choose number of dice

i = 0
while i < diceNo:       #Loop to iterate through chosen number of dice and select dice sizes
    size = diceSimMeths.chooseSize(i)
    diceList.append(Dice(size))
    i += 1

totalRoll = 0   #For sum of dice rolls

input("Press any key to roll the dice\n")
for x in diceList:      #Loop to roll each of the dice
    x.roll()
    totalRoll += x.latestRoll

print("The total roll is " + str(totalRoll) + ".\n")