# Задайте натуральное число N. Напишите программу, которая
# составит список простых множителей числа N.
def input_int(message):
    result = input(message)
    while (not result.isdigit()):
        result = input("Ошибка ввода, введите целое число: ")
    return int(result)


def factorize(n):
    result = []
    for i in range(2, n):
        while n % i == 0:
            result.append(i)
            n /= i
    if n != 1:
        result.append(n)
    return result

print(factorize(input_int("Введите целое число:")))
# print(factorize(8829))
