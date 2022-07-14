def trun_vows(s):
  vowels = 'aeiouAEIOU'
  result = ''
  for i in s:
    if (i not in vowels):
      result += i
  print(result)

s = input('Please enter a message:')
trun_vows(s)
