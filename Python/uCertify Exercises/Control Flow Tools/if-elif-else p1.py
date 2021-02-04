fees = int(input('What are the fees? '))
st_code = str.upper(input('What is the student code? '))
def check_fees(fees, student_code):
    if(fees == 100 and student_code == 'N'):
        print("The student is normal.")
    elif(fees == 60 and student_code == 'PD'):
        print("The student is physically disabled.")
    elif(fees == 80 and student_code == 'PPD'):
        print("The student is partial physically disabled.")
    else:
        print("The student is of any other class.")
check_fees(fees, st_code)
