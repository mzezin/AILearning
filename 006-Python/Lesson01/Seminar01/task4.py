# 2. Напишите программу, которая будет принимать на вход дробь
# и показывать первую цифру дробной части числа.

#     *Примеры:*

#     - 6,78 -> 7
#     - 5 -> нет
#     - 0,34 -> 3



def first_fractional_digit (number):
    if float(number) == int(number):
        return None
    return int((number % 1) * 10)

print(first_fractional_digit(6.78))
print(first_fractional_digit(5))
print(first_fractional_digit(0.34))

print(first_fractional_digit(float(input("Введите дробное число: "))))