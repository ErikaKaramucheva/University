def floodfill(*area,node,target_col,replace_col):
   if target_col !=replace_col:
      return replace_col
   nleft=(node[0]-1,node[1])
   floodfill(area,nleft,target_col,replace_col)

   nright=(node[0]+1,node[1])
   floodfill(area,nright,target_col,replace_col)

   nup = (node[0] , node[1]+1)
   floodfill(area, nup, target_col, replace_col)

   ndown = (node[0] , node[1]-1)
   floodfill(area, ndown, target_col, replace_col)

   return



area=["blue"]*10
result=floodfill(area,(1,1),'black','blue')
for i in result:
   print(result[i])