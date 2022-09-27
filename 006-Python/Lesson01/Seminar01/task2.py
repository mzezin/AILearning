# 2. Напишите программу, которая на вход принимает 5 чисел и находит максимальное из них.

#     Примеры:

#     - 1, 4, 8, 7, 5 -> 8
#     - 78, 55, 36, 90, 2 -> 90

def get_5_numbers():
    result = []
    for i in range(5):
        result.append(int(input(f"Введите число номер {i+1}: ")))
    return result


def find_max_of_5(numbers):
    if type(numbers) != list:
        return None
    if len(numbers) != 5:
        return None
    max_number = numbers[0]
    for i in numbers:
        if i > max_number:
            max_number = i
    return max_number


test_list1 = [1, 4, 8, 7, 5]
test_list2 = [78, 55, 36, 90, 2]
input_list = get_5_numbers()

print(find_max_of_5(test_list1))
print(find_max_of_5(test_list2))
print(input_list)
print(find_max_of_5(input_list))

