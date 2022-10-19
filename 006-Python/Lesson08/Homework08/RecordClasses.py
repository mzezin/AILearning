import json
from uuid import uuid4 as uuid


class BaseRecord():
    def __init__(self, id: str = '') -> None:
        self.id = str(uuid()) if id=='' else id

    def __repr__(self) -> str:
        return json.dumps(self.__dict__)


class Group(BaseRecord):
    def __init__(self, name: str, id: str = '') -> None:
        super().__init__(id)
        self.name = name



class Student(BaseRecord):
    def __init__(self, FIO: str,  group_id: str, id: str = '') -> None:
        super().__init__(id)
        self.FIO = FIO
        self.group_id = group_id


class Lesson(BaseRecord):
    def __init__(self, name: str,  group_id: str, start_time, end_time, id: str = '') -> None:
        super().__init__(id)
        self.name = name
        self.start_time = start_time
        self.end_time = end_time
        self.group_id = group_id
