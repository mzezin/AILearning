
import os
from RecordClasses import Group, Lesson, Student
from DB import DB


def cls():
    os.system('cls' if os.name == 'nt' else 'clear')


def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def main_menu(db: DB):
    print("Главное меню")
    print("="*100)
    print("1 - Группы")
    print("2 - Студенты")
    print("3 - Предметы")
    print("4 - Поисковые запросы")
    print("0 - Выход")

    selection = input_int()
    if selection == 1:
        groups_menu(db)
    elif selection == 2:
        students_menu(db)
    elif selection == 3:
        lessons_menu(db)
    elif selection == 4:
        search_menu(db)
    elif selection == 0:
        return
    else:
        print("Неправильный ввод")
        main_menu(db)

    # test_run(db)


def groups_menu(db: DB):
    print("Меню управления группами")
    print("="*100)
    print("1 - Просмотр всех групп")
    print("2 - Добавление группы")
    print("3 - Удаление группы")
    print("0 - Возврат")
    selection = input_int()
    if selection == 1:
        db.groups.print()
        groups_menu(db)
    elif selection == 2:
        name = input("Введите название группы: ")
        db.groups.add(Group(name))
        db.groups.print()
        groups_menu(db)
    elif selection == 3:
        db.groups.print()
        id = input("Введите id для удаления: ")
        db.groups.remove(id)
        db.groups.print()
        groups_menu(db)
    elif selection == 0:
        main_menu(db)
    else:
        print("Неправильный ввод")
        groups_menu(db)


def students_menu(db: DB):
    print("Меню управления студентами")
    print("="*100)
    print("1 - Просмотр всех студентов")
    print("2 - Добавление студента")
    print("3 - Удаление студента")
    print("0 - Возврат")
    selection = input_int()
    if selection == 1:
        db.students.print()
        students_menu(db)
    elif selection == 2:
        print("Список групп:")
        db.groups.print()
        group_id = input("Введите id группы для добавления студента: ")
        fio = input("Введите ФИО студента: ")
        db.students.add(Student(fio, group_id))
        db.students.print()
        students_menu(db)
    elif selection == 3:
        db.students.print()
        id = input("Введите id для удаления: ")
        db.students.remove(id)
        db.students.print()
        students_menu(db)
    elif selection == 0:
        main_menu(db)
    else:
        print("Неправильный ввод")
        students_menu(db)


def lessons_menu(db: DB):
    print("Меню управления предметами")
    print("="*100)
    print("1 - Просмотр всех предметов")
    print("2 - Добавление предмета")
    print("3 - Удаление предмета")
    print("0 - Возврат")
    selection = input_int()
    if selection == 1:
        db.lessons.print()
        lessons_menu(db)
    elif selection == 2:
        print("Список групп:")
        db.groups.print()
        group_id = input("Введите id группы для добавления урока: ")
        name = input("Введите предмет: ")
        db.lessons.add(Lesson(name, group_id))
        db.lessons.print()
        lessons_menu(db)
    elif selection == 3:
        db.lessons.print()
        id = input("Введите id для удаления: ")
        db.lessons.remove(id)
        db.lessons.print()
        lessons_menu(db)
    elif selection == 0:
        main_menu(db)
    else:
        print("Неправильный ввод")
        lessons_menu(db)


def search_menu(db: DB):
    print("Меню поисковых запросов: ")
    print("="*100)
    print("1 - Список студентов по группе")
    print("2 - Список предметов по группе")
    print("3 - Список студентов по предмету")
    print("0 - Возврат")
    selection = input_int()
    if selection == 1:
        print("Список предметов по группе")
        db.groups.print()
        group_id = db.groups.find(
            "name", input("Введите название группы: ")).id
        filtered_lessons = db.lessons.find_all("group_id", group_id)
        db.lessons.print(filtered_lessons)
        search_menu(db)
    elif selection == 2:
        print("Список студентов по группе")
        db.groups.print()
        group_id = db.groups.find(
            "name", input("Введите название группы: ")).id
        filtered_students = db.students.find_all("group_id", group_id)
        db.students.print(filtered_students)
        search_menu(db)
    elif selection == 3:
        print("Список студентов по предмету")
        db.lessons.print()
        lessons = db.lessons.find_all(
            "name", input("Введите название предмета: "))
        groups = map(lambda e: e.group_id, lessons)
        filtered_students = []
        for group_id in groups:
            filtered_students += db.students.find_all("group_id", group_id)
        db.students.print(filtered_students)
        search_menu(db)
    elif selection == 0:
        main_menu(db)
    else:
        print("Неправильный ввод")
        lessons_menu(db)


def test_run(db: DB):

    db.groups.add(Group("2A"))
    db.groups.add(Group("3A"))
    db.groups.add(Group("4A"))
    db.groups.print()

    group_id = db.groups.find("name", "2A").id
    db.students.add(Student("Иванов Иван Иванович", group_id))
    db.students.add(Student("Петров Петр Петрович", group_id))
    db.students.add(Student("Сидоров Сидор Сидорович", group_id))
    db.students.print()

    db.lessons.add(Lesson("Математика", group_id, "09:00", "09:45"))
    db.lessons.add(Lesson("Литература", group_id, "10:00", "10:45"))
    db.lessons.add(Lesson("ОБЖ", group_id, "11:00", "11:45"))
    db.lessons.print()

    lesson_id = db.lessons.find("name", "Литература").id
    db.lessons.remove(lesson_id)
    db.lessons.print()
