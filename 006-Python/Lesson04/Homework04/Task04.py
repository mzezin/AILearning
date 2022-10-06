# Задана натуральная степень k.
# Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена
# и записать в файл многочлен степени k.

# Пример:

# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0


import random


def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def generate_polynomial(k):
    result = {}
    for i in range(k, -1, -1):
        result[i] = random.randint(0, 100)
    return result

def generate_poly_element(x, n, superscript_mode=False):
    if n == 0:
        return str(x)
    if n == 1:
        return str(x)+"*x"
    superscript = ["⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹"]
    result = str(x)
    if x != 0:
        result += "*x"
    if superscript_mode:
        for i in str(n):
            result += superscript[int(i)]
    else:
        result += "^"+str(n)
    return result
  
def print_polynomial(poly, superscript_mode=False):
    result = []
    for k in poly:
        if poly[k] != 0:
          result.append(generate_poly_element(poly[k], k, superscript_mode))
    return "+".join(result)


k = input_int("Введите степень: ")
polynomial = generate_polynomial(k)
print(print_polynomial(polynomial))
with open("poly1.txt", "w") as file:
    file.write(print_polynomial(polynomial))
