# Задайте последовательность чисел. Напишите программу,
# которая выведет список неповторяющихся элементов исходной последовательности.

def int_set(input_string):
  return list(set(map(lambda e: int(e), input_string.split())))

data = input("Введите последовательность чисел через пробел: ")
print (int_set(data))