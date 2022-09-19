# Напишите программу, которая принимает на вход цифру,
# обозначающую день недели, и проверяет, является ли этот день выходным.

# Пример:
# - 6 -> да
# - 7 -> да
# - 1 -> нет

def isNonWorkingDay(dayNumber):
    if type(dayNumber) is not int or dayNumber < 1 or dayNumber > 7:
        print("Неверные входные параметры")
        return False
    if dayNumber > 5:
        return True
    return False


print(isNonWorkingDay(6))
print(isNonWorkingDay(7))
print(isNonWorkingDay(1))
