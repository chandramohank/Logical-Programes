
def patterns(str, all):

  # if the string is empty, return all the string sets
  if len(str) == 0:
    return all

  # if character is 0 or 1 then add the character to each
  # string set we currently have so far
  if str[0] == '0' or str[0] == '1':
    for i in range(0, len(all)):
      all[i].append(str[0])

  # for a wildcard, we make a copy of each string set
  # and for half of them we append a 0 to the string
  # and for the other half we append a 1 to the string
  if str[0] == '?':
    le = len(all)
    for i in range(0, le):
      temp = list(all[i])
      all.append(temp)
    for i in range(0, len(all)):
      if i < len(all)/2:
        all[i].append('0')
      else:
        all[i].append('1')

  # recursively calculate all string sets
  return patterns(str[1:], all)

print(patterns('10?1?', [[]]))
