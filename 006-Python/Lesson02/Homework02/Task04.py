# Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на указанных позициях.
# Позиции хранятся в файле file.txt в одной строке одно число.

def generate_number_list(n):
    result = []
    for i in range(-n, n):
        result.append(i)
    return result


def calculate_production(input_list, pos_a, pos_b):
    return input_list[pos_a-1] * input_list[pos_b-1]


def input_int(msg):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод: ")
        else:
            return result


n = input_int("Введите число N: ")
position_a = input_int("Введите номер позиции 1: ")
position_b = input_int("Введите номер позиции 2: ")

generated_list = generate_number_list(n)
result = calculate_production(generated_list, position_a, position_b)

print(generated_list)
print(result)

# print(generate_number_list(5))
# print(calculate_production(generate_number_list(5), 1, 3))
