# Напишите программу, которая принимает на вход число N и
# выдает набор произведений чисел от 1 до N.

# Пример:
# - пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)
from functools import reduce

def prod_list(n):
    result = reduce(lambda acc, e: acc + [acc[-1]*e], range(1, n+1), [1])
    return result[1:]

print(prod_list(4))  