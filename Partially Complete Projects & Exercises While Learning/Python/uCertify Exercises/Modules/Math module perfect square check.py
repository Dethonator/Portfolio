import math

num = int(input('Please enter an integer: '))

def perfect_sq(n):
    sqRt = math.sqrt(n)
    if sqRt - math.floor(sqRt) == 0:
        print(sqRt - math.floor(sqRt) == 0,'-', n, "is a perfect square.")
    else:
        print(sqRt - math.floor(sqRt) == 0,'-', n, "is not a perfect square.")

perfect_sq(num)
