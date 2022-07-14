timeNow = int(input('Please enter the current hour in 24-hour format: '))

def check_time(time):
    if(time >= 12 and time <= 24):
        print('PM')
    elif(time > 24 or time < 0):
        print('Invalid time!')
    else:
        print('AM')

check_time(timeNow)
