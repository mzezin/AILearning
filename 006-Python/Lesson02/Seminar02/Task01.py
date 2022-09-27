# 1. Напишите программу, которая принимает на вход число N и
# выдаёт последовательность из N членов.
# *Пример:*          - Для N = 5: 1, -3, 9, -27, 81

import random as rd


def input_int(message):
    result = input(message)
    while (not result.isdigit()):
        result = input("Ошибка ввода, введите целое число: ")
    return int(result)


number = input_int("Введите число N: ")
result = []
for i in range(number):
    result.append(rd.randint(-100, 100))
print(result)