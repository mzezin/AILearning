# 43. Дана последовательность чисел. Получить список уникальных элементов заданной последовательности.

# *Пример:* 

# [1, 2, 3, 5, 1, 5, 3, 10] => [2, 10]

def get_unique(input):
  unique=set(input)
  result = []
  for i in unique:
    if input.count(i)==1:
      result.append(i)
  return result

inp_list = [1, 2, 3, 5, 1, 5, 3, 10]
print(get_unique(inp_list))