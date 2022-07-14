n = int(input('Please enter a positive integer: '))
if n > 0:
    sum = 0
    while(n > 0):
        sum += n
        n -= 1
    print("The factorial of your number is", str(sum) + ".")
else:
    print('That is not a valid input!')
