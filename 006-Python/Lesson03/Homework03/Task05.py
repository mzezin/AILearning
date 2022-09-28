# 5) Задайте число. Составьте список чисел Фибоначчи,
# в том числе для отрицательных индексов.

# Пример:
# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
# [Негафибоначчи](https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%B3%D0%B0%D1%84%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8#:~:text=%D0%92%20%D0%BC%D0%B0%D1%82%D0%B5%D0%BC%D0%B0%D1%82%D0%B8%D0%BA%D0%B5%2C%20%D1%87%D0%B8%D1%81%D0%BB%D0%B0%20%D0%BD%D0%B5%D0%B3%D0%B0%D1%84%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8%20%E2%80%94%20%D0%BE%D1%82%D1%80%D0%B8%D1%86%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%20%D0%B8%D0%BD%D0%B4%D0%B5%D0%BA%D1%81%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5%20%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D1%8B%20%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D0%B8%20%D1%87%D0%B8%D1%81%D0%B5%D0%BB%20%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8.)


from turtle import pos


def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def positive_fibonacci(n):
    if n < 0:
        return []
    if n == 0:
        return [0]
    if n == 1:
        return [0, 1]
    result = list()
    result.append(0)
    result.append(1)
    for i in range(2, n+1):
        result.append(result[i-1] + result[i-2])
    return result


def reverse_list(input_list):
    result = list()
    length = len(input_list)
    for i in range(length):
        result.append(input_list[length - i - 1])
    return result


def negative_fibonacci(n):
    if n <= 0:
        return []
    if n == 1:
        return [1]
    if n == 2:
        return [-1, 1]
    result = list()
    result.append(0)
    result.append(1)
    result.append(-1)
    for i in range(3, n+1):
        result.append(result[i-2] - result[i-1])
    result.pop(0) 
    return reverse_list(result)

def full_fibonacci(n):
  return negative_fibonacci(n) + positive_fibonacci(n) 


print(full_fibonacci(input_int("Введите целое число: ")))

# print(full_fibonacci(8))
