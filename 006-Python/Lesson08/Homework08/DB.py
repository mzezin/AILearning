import json

# from Student import Student
# from Lesson import Lesson
from StorageClasses import GroupDB, StudentDB, LessonDB
from RecordClasses import Group, Student, Lesson


class DB():
    def __init__(self, file_name = ''):
        if file_name == '':
            self.groups = GroupDB()
            self.students = StudentDB()
            self.lessons = LessonDB()
        else:
            self.load(file_name)

    def __repr__(self):
        result = {
            "groups": list(map(lambda e: e.__dict__, self.groups.get_all())),
            "students": list(map(lambda e: e.__dict__, self.students.get_all())),
            "lessons": list(map(lambda e: e.__dict__, self.lessons.get_all()))
        }
        return str(dict(result))

    def save(self, file_name: str = 'db.json'):
        state = {
            "groups": list(map(lambda e: e.__dict__, self.groups.get_all())),
            "students": list(map(lambda e: e.__dict__, self.students.get_all())),
            "lessons": list(map(lambda e: e.__dict__, self.lessons.get_all()))
        }
        with open(file_name, 'w', encoding='utf8') as db:
            json.dump(state, db, ensure_ascii=False, indent=4)
            print("БД сохранена")

    def reset(self):
        self.groups = GroupDB()
        self.students = StudentDB()
        self.lessons = LessonDB()

    def load(self, file_name):
        try:
            with open(file_name) as db:
                loaded_state = json.load(db)
                groups = GroupDB()
                for group in loaded_state["groups"]:
                    groups.add(Group(group["name"], group["id"]))
                self.groups = groups

                students = StudentDB()
                for student in loaded_state["students"]:
                    students.add(
                        Student(student["FIO"], student["group_id"], student["id"]))
                self.students = students

                lessons = LessonDB()
                for lesson in loaded_state["lessons"]:
                    lessons.add(Lesson(lesson["name"], lesson["group_id"], lesson["start_time"], lesson["end_time"], lesson["id"]
                                       ))
                self.lessons = lessons
                print("БД загружена")
                
        except:
            print("Ошибка открытия файла, проверьте формат")
