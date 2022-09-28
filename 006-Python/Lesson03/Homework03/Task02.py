# 2) Напишите программу, которая найдёт произведение пар чисел списка.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def input_int_list():
    count = input_int("Введите количество элементов списка: ")
    result = list()
    for i in range(count):
        result.append(input_int(f"Введите целое число №{i+1}: "))
    return result

def pair_production(input_list):
    length = len(input_list)
    target_length = length//2
    result = list()
    for i in range(target_length):
        result.append(input_list[i] * input_list[length - i - 1])
    if target_length * 2 != length:
        result.append(input_list[target_length]**2)
    return result


print(pair_production(input_int_list()))

# print(pair_production([2, 3, 4, 5, 6]))
# print(pair_production([2, 3, 5, 6]))
