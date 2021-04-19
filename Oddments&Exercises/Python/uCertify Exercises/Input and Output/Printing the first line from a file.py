with open('test.txt', 'w') as f:
    f.write('The first line of code. \nThe second line of code.')

with open('test.txt', 'r') as g:
    print(g.readline())
    
