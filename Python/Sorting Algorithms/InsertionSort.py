def insertionsort(data):
    for i in range(0,len(data)):
        currentvalue=data[i]
        position=i
        while position>0 and data[position-1]>currentvalue:
            data[i]=data[i-1]
            position=position-1
        
        data[position]=currentvalue

    return data

print(insertionsort([54,26,93,17,77,31,44,55,20]))
