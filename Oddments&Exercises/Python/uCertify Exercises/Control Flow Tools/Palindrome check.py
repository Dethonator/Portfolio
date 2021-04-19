seq = input('Please enter any sequence of characters: ')
rev_seq = reversed(seq)
if (list(seq) == list(rev_seq)):
    print('Your input is a palindrome!')
else:
    print('Not a palindrome')
