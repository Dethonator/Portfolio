snt = input('Please enter a sentence: ')
words = snt.split()
words.sort()
for word in words:
    print(word, end="\n")
