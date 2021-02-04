num1 = int(input('Please enter your first number: '))
num2 = int(input('Please enter your second number: '))

def lcm(n1, n2):
    if n1 > n2:
        greater = n1
    else:
        greater = n2
    while(True):
        if((greater % n1 == 0) and (greater % n2 == 0)):
            lcm = greater
            break
        greater += 1
    return lcm

print('The lowest common multiple of', num1,'and', num2,'is', str(lcm(num1, num2))+'.')
    
