def KMPSearchUsingNaive(inputstring,substring):
    inputlen = len(inputstring)
    substringlen  = len(substring)
    matchingindex = []
    i=0
    while i < inputlen:
        if  inputstring[i] == substring[0]:
            j=0
            matchingind = i
            while  i<inputlen and j<substringlen:                
                if  inputstring[i]==substring[j]:
                    if j == substringlen-1:
                        matchingindex.append(matchingind+1)
                        i=i+1
                        break
                    i=i+1
                    j=j+1                  
                    continue
                else:
                    break
        else:
            i=i+1
                        
    return matchingindex


def KMPUsingPrefixSufix(text,pat):
    n=len(text)
    m=len(pat)
    lps=[0]*patlen

def generatelpsarray(lps,pat):
    


print(KMPSearchUsingNaive("ABABDABACDABABCABAB","ABABCABAB"))
                    

