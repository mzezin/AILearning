# 2. Для натурального n создать словарь индекс-значение,
# состоящий из элементов последовательности 3n + 1.
# *Пример:*          - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

def input_int(message):
    result = input(message)
    while (not result.isdigit()):
        result = input("Ошибка ввода, введите целое число: ")
    return int(result)


number = input_int("Введите число N: ")
result = []
for i in range(1, number+1):
    element = [i, 3*i + 1]
    result.append(element)
print(dict(result))
