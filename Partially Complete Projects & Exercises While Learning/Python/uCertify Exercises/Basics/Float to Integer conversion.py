print('Please input the dimensions of a rectangular prism in metres. \n'
      'Please note that all decimal values are rounded down to integers.')
l = float(input('Length:'))
b = float(input('Breadth:'))
h = float(input('Height:'))
def volume(length, breadth, height):
    v = int(length)*int(breadth)*int(height)
    return v
print('The volume of your prism is', volume(l,b,h),'m')
