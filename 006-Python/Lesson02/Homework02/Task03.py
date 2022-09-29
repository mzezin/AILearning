# Задайте список из n чисел последовательности (1 + 1/n)**n
# и выведите на экран их сумму.


def input_int(msg):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод: ")
        else:
            return result


def generate_list(n):
    result = []
    for i in range(1, n+1):
        result.append(round((1 + 1/i)**i))
    return result


n = input_int("Введите целое число: ")
number_list = generate_list(n)


print(f"Для n = {n}: {number_list} -> {sum(number_list)}")

# print(generate_list(6))
