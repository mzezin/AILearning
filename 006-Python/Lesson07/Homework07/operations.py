import json


def save(data):
    with open('db.json', 'w', encoding='utf8') as db:
        json.dump(data, db, ensure_ascii=False)


def init():
    save([])


def add(record):
    with open('db.json') as db:
        data = json.load(db)
        data.append(record)
        save(data)


def delete(index):
    with open('db.json') as db:
        data = json.load(db)
        data.pop(index)
        save(data)


def get(index):
    with open('db.json') as db:
        data = json.load(db)
        return data[index]
    
def get_all():
    with open('db.json') as db:
        data = json.load(db)
        return data
      
# def find_by_name(query):
#       with open('db.json') as db:
#         data = json.load(db)
#         return data.find()
  
