# Реализуйте алгоритм перемешивания списка.
import random as rd


def my_shuffle(input_list):
    result_list = []
    initial_length = len(input_list)
    for _ in range(initial_length):
        random_index = rd.randint(0, len(input_list)-1)
        result_list.append(input_list.pop(random_index))
    input_list = result_list
    return input_list


print(my_shuffle([1, 2, 3, 4, 5]))
print(my_shuffle(list(range(10))))


# другой, менее эффективный вариант
# def my_shuffle_old(input_list):
#     shuffled_index_list = []
#     result_list = []
#     for _ in input_list:
#         passed = False
#         while passed == False:
#             index = rd.randint(0, len(input_list)-1)
#             if index not in shuffled_index_list:
#                 shuffled_index_list.append(index)
#                 passed = True
#     for i in range(len(input_list)):
#         result_list[i] = input_list[shuffled_index_list[i]]
#     return result_list
