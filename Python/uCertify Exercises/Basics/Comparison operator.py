def smallest(n1, n2):
  if(n1 < n2):
    print(n1,'is the smaller number.')
  elif(n1 > n2):
    print(n2,'is the smaller number.')
  else:
    print('The two numbers are equal!')
  return
a = int(input('Please enter an integer: '))
b = int(input('Please enter a second integer: '))
smallest(a,b)
