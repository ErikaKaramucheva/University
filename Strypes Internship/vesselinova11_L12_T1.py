import sys
import sqlite3

conn=sqlite3.connect('vesselinova11-food.db')
curs=conn.cursor()
curs.execute('''CREATE TABLE food(
                code INTEGER,
                descript TEXT,
                nmbr INTEGER,
                nutname TEXT,
                retention INTEGER)

''')

with open(r'retn5_dat.txt')as file:
    for f in file:
        fi=f[:-8]
        fi=fi.lstrip('~')
        fi=fi.split("~^~")
        data=[row for row in fi]
        curs.executemany("INSERT INTO food (code, descript,nmbr,nutname,retention ) VALUES (?, ?, ?,?,?)", [data])

conn.commit()
command=sys.argv[1:]
res=''
for i in range(len(command)):
    res.join(command[i])
curs.execute(res)
row=curs.fetchall()
print(row)


