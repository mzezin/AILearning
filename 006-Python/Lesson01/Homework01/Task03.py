# Напишите программу, которая принимает на вход координаты точки (X и Y),
# причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
# в которой находится эта точка (или на какой оси она находится).

def find_quarter(x, y):
    if x > 0:
        if y > 0:
            return 1
        if y < 0:
            return 4
    if x < 0:
        if y > 0:
            return 2
        if y < 0:
            return 3
    return None


x = int(input("Введите координату X: "))
y = int(input("Введите координату Y: "))

print(find_quarter(x, y))
