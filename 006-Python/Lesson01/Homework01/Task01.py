# Напишите программу, которая принимает на вход цифру,
# обозначающую день недели, и проверяет, является ли этот день выходным.

# Пример:
# - 6 -> да
# - 7 -> да
# - 1 -> нет

day_number = input("Введите день недели: ")
while (not day_number.isdigit() or not 8 > int(day_number) > 1):
    print("Ошибка ввода, введите корректный день недели")
    day_number = input("Введите день недели: ")
if int(day_number) > 5:
    print(f"{day_number} -> да")
else:
    print(f"{day_number} -> нет")
