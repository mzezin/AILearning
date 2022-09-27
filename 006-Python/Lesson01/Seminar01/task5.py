# 3. Напишите программу, которая принимает на вход число и проверяет,
# кратно ли оно 5 и 10 или 15, но не 30

def is_strange_check(number):
    return (number % 5 == 0 and number % 10 == 0 or number % 15 == 0) and number % 30 != 0

number = int(input("Введите число: "))

print(is_strange_check(number))