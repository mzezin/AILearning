# Задача 2. Напишите псевдокод по блок-схеме
# Найти среднее арифметическое среди всех элементов массива [2, 5, 13, 7, 6, 4]

numbers  = [2, 5, 13, 7, 6, 4] # задаем массив
size = 6 # задаем переменную с размером
sum = 0 # инициализируем переменную sum
avg = 0 # инициализируем переменную avg
index = 0 # инициализируем переменную index
while index < size : # запускаем цикл
  sum = sum + numbers[index] # увеличиваем сумму на значение элемента
  index = index + 1 # увеличиваем счетчик цикла
avg = sum / size # считаем среднее значение
print(avg) # выводим значение