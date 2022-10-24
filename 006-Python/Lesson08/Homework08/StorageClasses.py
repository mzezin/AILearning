import json

from RecordClasses import Group, Student, Lesson


class BaseStorage():
    def __init__(self, initial_state=None) -> None:
        if initial_state == None:
            self.state = []
        else:
            self.state = json.load(initial_state)

    def __repr__(self):
        return str(list(map(lambda e: e.__dict__, self.state)))

    def get_all(self):
        return self.state

    def get(self, id: str):
        result = list(filter(lambda e: e.id == id, self.state))
        if len(result) == 0:
            print("Ошибка поиска")
            return None
        return result[0]

    def remove(self, id: str):
        result = list(filter(lambda e: e.id != id, self.state))
        self.state = result

    def find(self, field: str, value: str):
        try:
            result = list(filter(lambda e: e.__dict__[
                                               field] == value, self.state))
            if len(result) == 0:
                print("Ошибка поиска")
                return None
            return result[0]
        except:
            print("Ошибка имени поля")
            return None

    def find_all(self, field: str, value: str):
        try:
            result = list(filter(lambda e: e.__dict__[
                                               field].lower() == value.lower(), self.state))
            if len(result) == 0:
                print("Ошибка поиска")
                return None
            return result
        except:
            print("Ошибка имени поля")
            return None

    def validate(self, result=True):
        if not result:
            print("Ошибка валидации")
        return result

    def add(self, record) -> str | None:
        if not self.validate(record):
            return None
        self.state.append(record)
        return record.id


class GroupDB(BaseStorage):
    def validate(self, record):
        return isinstance(record, Group)

    def print(self, state=None):
        if state == None:
            state = self.state
        result = [f"{'id':<37}│{'Название группы'}"]
        result += [f"{'─' * 115}"]
        result += list(
            map(lambda record: f"{record.id:<37}│{record.name}", state))
        result += [f"{'─' * 115}"]
        result += [""]
        for row in result:
            print(row)


class StudentDB(BaseStorage):
    def validate(self, record):
        return isinstance(record, Student)

    def print(self, state=None):
        if state == None:
            state = self.state
        result = [f"{'id':<37}│{'ФИО':<40}│{'id группы'}"]
        result += [f"{'─' * 115}"]
        result += list(
            map(lambda record: f"{record.id:<37}│{record.FIO:<40}│{record.group_id}", state))
        result += [f"{'─' * 115}"]
        result += [""]
        for row in result:
            print(row)


class LessonDB(BaseStorage):
    def validate(self, record):
        return isinstance(record, Lesson)

    def print(self, state=None):
        if state == None:
            state = self.state
        result = [
            f"{'id':<37}│{'Урок':<20}│{'Начало':<7}│{'Конец':<7}│{'id группы'}"]
        result += [f"{'─' * 115}"]
        result += list(
            map(lambda
                    record: f"{record.id:<37}│{record.name:<20}│{record.start_time:<7}│{record.end_time:<7}│{record.group_id}",
                state))
        result += [f"{'─' * 115}"]
        result += [""]
        for row in result:
            print(row)
