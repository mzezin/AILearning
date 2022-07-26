# 4) Напишите программу, которая будет преобразовывать десятичное число в двоичное.

# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def decimal_to_bin(number):
    buffer = number
    result = ""
    while buffer > 0:
        result = str(buffer % 2) + result
        buffer //= 2
    return result


# print(decimal_to_bin(input_int("Введите целое число: ")))

# print(decimal_to_bin(45))
# print(decimal_to_bin(3))
# print(decimal_to_bin(2))

# n = (input("Введите число для преобразовывания: "))
# while not n.isdigit():
#     n = (input("Введите еще раз: "))
# n1 = int(n)
# s = ""
# while n1 != 0:
#     s = str(n1 % 2) + s
#     n1 //= 2
# print(f'\nДесятичное число: {n} => двоичное число: {s}')

