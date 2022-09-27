# Напишите программу, которая по заданному номеру четверти,
# показывает диапазон возможных координат точек в этой четверти (x и y).

def input_quarter(message):
    quarter = input(message)
    while (not quarter.isdigit() or int(quarter) < 1 or int(quarter) > 4):
        quarter = input("Ошибка ввода, введите номер четверти: ")
    return int(quarter)


def get_possible_coords(quarter):
    if quarter == 1:
        return "x > 0, y > 0"
    if quarter == 2:
        return "x < 0, y > 0"
    if quarter == 3:
        return "x < 0, y < 0"
    if quarter == 4:
        return "x > 0, y < 0"
    return "Ошибка ввода"


print(get_possible_coords(input_quarter("Введите число от 1 до 4: ")))
