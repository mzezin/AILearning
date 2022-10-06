# Вычислить число c заданной точностью d

# Пример:

# - при $d = 0.001, π = 3.141


import math


def input_float(msg=""):
    while True:
        try:
            result = float(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def my_round(real_number, number_string):
    splitted_string = number_string.split('.')
    digits = len(splitted_string[1])
    return round(real_number, digits)


# real_nubmer = input_float("Введите число для округления: ")
# accuracy = input_float("Введите точность вычисления (например, 0.0001): ")

print(my_round(0.3221212, "0.001"))
print(my_round(math.pi, "0.00001"))
