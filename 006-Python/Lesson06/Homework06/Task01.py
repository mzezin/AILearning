# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

# Пример:

# - 6782 -> 23
# - 0,56 -> 11

def sum_of_digits(number):
    return sum(list(map(int, filter(str.isdigit, str(number)))))

print (sum_of_digits(6782))
print (sum_of_digits(0.56))

