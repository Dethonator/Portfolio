#Creation of a two line text file
with open('test.txt', 'w') as f:
    f.write('The first line of code. \nThe second line of code.')

#Printing the first line of the above file
with open('test.txt', 'r') as g:
    print(g.readline())
    
