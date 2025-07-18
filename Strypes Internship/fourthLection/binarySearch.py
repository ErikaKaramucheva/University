import sys
def binarySearch(number,search, l,r):
    if r>l:
       mid=(l+r)//2
    if number[mid]==search:
        return mid
    elif number[mid]<search:
       return binarySearch(number,search,mid,r)
    elif number[mid]>search:
        return binarySearch(number,search,l,mid+1)
    else:
        return -1


numb=[2,3,5,7,12,18]
n=8
result=binarySearch(numb, n, 0, len(numb)-1)
print(result)
