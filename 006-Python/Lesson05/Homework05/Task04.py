# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.
# Входные и выходные данные хранятся в отдельных текстовых файлах.

def RLE_pack(input):
    result = []
    element = [1, input[0]]
    for i in range(1, len(input)):
        if input[i] == element[1]:
            element[0] += 1
        else:
            result.append(str(element[0]) + element[1])  # type: ignore
            element = [1, input[i]]
    if element[0] != 1:
        result.append(str(element[0]) + element[1])  # type: ignore
    return "".join(result)


def RLE_unpack(input):
    result = ""
    buffer = ""
    if_prev_symbol_is_digit = False
    for e in input:
        if e.isdigit():
            buffer += e
            if_prev_symbol_is_digit = True
            continue
        if if_prev_symbol_is_digit:
            for _ in range(int(buffer)):
                result += e
            buffer = ""
    return result


data = ""
with open("Task04_origin.txt", "r") as file_in:
    data = file_in.read()
    print(f"Исходная строка: {data}")
with open("Task04_packed.txt", "w") as file_out:
    packed_data = RLE_pack(data)
    file_out.write(packed_data)
    print(f"Сжатая строка: {packed_data}")
with open("Task04_packed.txt", "r") as file_out:
    unpacked_data = RLE_unpack(file_out.read())
    print(f"Разжатая строка: {unpacked_data}")
    
  

# sample = "WWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWBWWWWWWWWWWWWWW"
# print(sample)
# print(RLE_pack(sample))
# print(RLE_unpack(RLE_pack(sample)))
