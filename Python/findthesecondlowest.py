
import sys

def findtheSecondLowest(inputarray):
    first,second=sys.maxsize ,sys.maxsize 
    for i in range(0,len(inputarray)):
        if inputarray[i] < first:
            second=first
            first=inputarray[i]
        elif inputarray[i]<second and inputarray[i]!=first:
            second=inputarray[i]
    return second

findtheSecondLowest([2,5,3,7,4])



