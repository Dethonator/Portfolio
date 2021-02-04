import datetime

d = input('Please enter the date (dd/mm/yyyy): ')
def change_date(str_date):
    date = datetime.datetime.strptime(str_date, "%d/%m/%Y").date()
    print('In ISO format, this date is ', date.isoformat())

change_date(d)
