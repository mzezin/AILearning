# 3) Задайте список из вещественных чисел. Напишите программу,
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

# Пример:
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19
def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def input_float(msg=""):
    while True:
        try:
            result = float(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def input_float_list():
    count = input_int("Введите количество элементов списка: ")
    result = list()
    for i in range(count):
        result.append(input_float(f"Введите вещественное число №{i+1}: "))
    return result


def min_max_delta(input_list):
    min = input_list[0]
    max = input_list[0]
    for i in input_list:
        if i < min:
            min = i
        if i > max:
            max = i
    return max - min


def fraction_list(input_list):
    fraction_list = list()
    for i in input_list:
        fraction_list.append(i - int(i))
    return fraction_list


print(min_max_delta(fraction_list(input_float_list())))

# print(min_max_delta(fraction_list([1.1, 1.2, 3.1, 5, 10.01])))
