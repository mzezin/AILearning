# 35. В файле находится N натуральных чисел, записанных через пробел. 
# Среди чисел не хватает одного, чтобы выполнялось условие A[i] - 1 = A[i-1]. Найдите это число.

my_str = '1 2 3 4 5 6 8 9'
my_list = list(map(int, my_str.split()))
print(my_list)
for item in range(1, len(my_list)):
    if my_list[item] - 1 != my_list[item-1]:
        print(my_list[item-1]+1)