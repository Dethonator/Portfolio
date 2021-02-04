print('Please enter a sequence of five random numbers.')
n = 0
list = []
while n < 5:
    print(n+1,'- ',end='')
    list.append(int(input('Please enter a number: ')))
    n += 1
for i in list:
    if i%2 != 0:
        print('The first odd number you entered is', str(i) + '.')
        break
