listIn = [2,5,3,1,9,6]

def cube(list):
    for i,j in enumerate(list):
        list[i] = j**3
    print(list)


cube(listIn)
