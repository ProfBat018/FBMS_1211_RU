class Person:
    def __init__(self, name: str, surname: str, age: int):
        self.name = name
        self.surname = surname
        self.age = age


class Teacher(Person):
    # def __init__(self, name, surname, age, salary: int):
    #     super().__init__(name, surname, age)
    #     self.salary = salary

    @property
    def name(self):
        return self.name

    @name.setter
    def name(self, value):
        self.name = value


a = Person("124", "213", 123)

b = Teacher("124", "213", 123, 34234)

b.name = 5
print(b.name)
