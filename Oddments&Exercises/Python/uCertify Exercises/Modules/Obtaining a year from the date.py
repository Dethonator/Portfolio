import datetime

d = input('Please enter the date with the format dd-mm-yyyy: ')

def get_year(date):
    a = datetime.datetime.strptime(date, "%d-%m-%Y").date()
    print(a.year)

get_year(d)
