# 1) Задайте список из нескольких чисел. Напишите программу,
# которая найдёт сумму элементов списка, стоящих на нечётной позиции.

# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

from functools import reduce


def sum_of_odd_positions(input_list):
    return reduce(lambda acc, e: acc + int(e[1]) if e[0] % 2 else acc, enumerate(input_list), 0)


print(sum_of_odd_positions([2, 3, 5, 9, 3]))
