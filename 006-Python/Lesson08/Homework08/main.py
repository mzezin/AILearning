import atexit
from DB import DB
from UI import main_menu



db = DB('db.json')

atexit.register(db.save)

main_menu(db)
