number = float(input('Please enter a number: '))
def check_num(num):
    if (num > 0):
      print('Positive!')
    elif(num < 0):
      print('Negative')
    else:
      print('Consider zero as a positive number.')
check_num(number)
