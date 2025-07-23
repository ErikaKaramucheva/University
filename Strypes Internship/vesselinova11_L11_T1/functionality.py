import json

class Unit:
    name:str
    author:str
    year:int
    country:str
    description:str
    rating:float
    status:str
    def __init__(self,name,author,year,country,description,rating,status):
        self.name=name
        self.author=author
        self.year=year
        self.country=country
        self.description=description
        self.rating=rating
        self.status=status

class Book(Unit):
    characters:[]
    genre:str
    pages:int
    data=[]

    def __add__(self, Unit,characters,genre,pages):
        super().__init__(name, author, year, country, description, rating, status)
        self.data.extend(super(Book, self).__add__())
        with open('book.json', mode='w') as f:
            json.dump(data, f)


class Game(Unit):
    data=[]
    def __init__(self,Unit):
        super.__init__(name, author,year,country,description,rating,status)

    def __add__(self, Unit):
        super().__init__(name, author, year, country, description, rating, status)
        self.data.extend(super(Game, self).__add__())
        with open('game.json', mode='w') as f:
             json.dump(data, f)

class Movie(Unit):
    characters:[]
    genre:str
    duration:float
    data=[]
    def __init__(self,name, author,year,country,description,rating,status,characters,genre,duration):
        super.__init__(name, author,year,country,description,rating,status)
        self.characters=characters
        self.genre=genre
        self.duration=duration

    def __add__(self, Unit,characters,genre,duration):
        super().__init__(name, author, year, country, description, rating, status)
        self.data.extend(super(Movie, self).__add__())
        with open('movie.json', mode='w') as f:
             json.dump(data, f)