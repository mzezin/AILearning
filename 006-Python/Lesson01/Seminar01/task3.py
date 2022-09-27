# 1. Напишите программу, которая будет на вход принимать число N и выводить числа от -N до N

#     *Примеры:*

#     - 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

def print_both_sides(n):
    result = list(range(0-n, n+1, 1))
    return result

print(print_both_sides(int(input("Введите число N: "))))
