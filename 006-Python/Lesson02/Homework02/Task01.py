# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

# Пример:

# - 6782 -> 23
# - 0,56 -> 11

def input_real_number(msg):
    while True:
        try:
            result = float(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод: ")
        else:
            return result


def sum_of_digits(number):
    number_string = str(number)
    result = 0
    for digit in number_string:
        if digit.isdigit():
            result += int(digit)
    return result


result = input_real_number("Введите вещественное число: ")
print(sum_of_digits(result))

# print(sum_of_digits(6782))
# print(sum_of_digits(0.56))
