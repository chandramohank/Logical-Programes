
def duplicates(arr):

  # our hash table to store each element
  # in the list as we pass through it
  hashTable = {}

  # store duplicates
  dups = []

  # check each element in the array
  for i in range(0, len(arr)):

    # if element does not exist in hash table
    # then insert it
    if arr[i] not in hashTable:
      hashTable[arr[i]] = True

    # if element does exist in hash table
    # then we know it is a duplicate
    else:
      dups.append(arr[i])

  return dups

print(duplicates([1, 21,21, -4, 103, 21, 4, 1]))
