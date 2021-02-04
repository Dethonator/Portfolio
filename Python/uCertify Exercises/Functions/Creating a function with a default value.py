name = input('Please enter your name: ')

def my_name(n="Jack"):
    return n

if len(name)==0:
    nameNow = my_name()
else:
    nameNow = my_name(name)

print('My name is', nameNow)
    
