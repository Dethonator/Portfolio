seq = input('Please enter any sequence of characters: ')
rev_seq = seq[::-1]
if (seq == rev_seq):
    print('Your input is a palindrome!')
else:
    print('Not a palindrome.')
