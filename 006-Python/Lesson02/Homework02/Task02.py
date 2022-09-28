# Напишите программу, которая принимает на вход число N и
# выдает набор произведений чисел от 1 до N.

# Пример:
# - пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

def input_int(msg):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод: ")
        else:
            return result


def generate_production_list(n):
    result = []
    buffer = 1
    for i in range(n):
        buffer = (i+1) * buffer
        result.append(buffer)
    return result


print(generate_production_list(input_int("Введите целое число: ")))


# print(generate_production_list(4))
# print(generate_production_list(6))
