import sys

input = '''11111111111111111111
10000000000000000001
10111111101011111101
10000000101010110101
10111111101010110101
10100000000010110101
10101110111110110101
10101010100000110101
10001000001000000001
11111111111111111111'''
x=sys.argv[1]
y=sys.argv[2]
lines = input.split('\n')
m = [[int(x) for x in line] for line in lines]
m[3][16] = 3

def printMaze(m):
    for row in range(len(m)):
        for col in range(len(m[0])):
            if m[row][col] == 1:
                m[row][col] = '#'
            elif m[row][col] == 0:
                m[row][col] = ' '
            elif m[row][col] == 3:
                m[row][col] = 'g'
    [print(' '.join(row)) for row in m]
    print()

def solveMaze(grid, i, j):
    n = len(grid)
    m = len(grid[0])
    if grid[i][j] == 3:
        print("Found")
        printMaze(grid)
        return

    if i < 0 or i >= n or j < 0 or j >= m or grid[i][j] != 0:
        return

    grid[i][j] = "."
    solveMaze(grid, i, j - 1)
    solveMaze(grid, i, j + 1)
    solveMaze(grid, i - 1, j)
    solveMaze(grid, i + 1, j)

    if grid[i][j] == ".":
       grid[i][j] = "x"

solveMaze(m, x,y)