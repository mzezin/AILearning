# Даны два файла, в каждом из которых находится запись многочлена.
# Задача - сформировать файл, содержащий сумму многочленов.


  
def print_polynomial(poly, superscript_mode=False):
    def generate_poly_element(x, n, superscript_mode=False):
        if n == 0:
            return str(x)
        if n == 1:
            return str(x)+"x"
        superscript = ["⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹"]
        result = str(x)
        if x != 0:
            result += "x"
        if superscript_mode:
            for i in str(n):
                result += superscript[int(i)]
        else:
            result += "^"+str(n)
        return result
    result = []
    for k in poly:
        if poly[k] != 0:
          result.append(generate_poly_element(poly[k], k, superscript_mode))
    return "+".join(result)




def validate_poly(poly_string):
    def poly_iterator(element):
        result = element.split("x^")
        if len(result) != 1:
            return [int(result[0]), int(result[1])]
        if result[0][-1] == "x":
            return [int(result[0][:-1]), 1]
        return [int(result[0]), 0]
    poly = poly_string.split("+")
    result = list(map(poly_iterator, poly))
    return {element[1]: element[0] for element in result}





def sum_polys(poly_a, poly_b):
    def max_power(poly):
        return max(map(int, poly.keys()))
    max_pow_a = max_power(poly_a)
    max_pow_b = max_power(poly_b)
    max_pow = max_pow_a if max_pow_a > max_pow_b else max_pow_b
    result = {}
    for i in range(max_pow, -1, -1):
        result[i] = poly_a.get(i, 0)+poly_b.get(i, 0)
    return result


with open("poly1.txt", "r") as file:
    poly1 = file.read()
with open("poly2.txt", "r") as file:
    poly2 = file.read()

poly1 = validate_poly(poly1)
poly2 = validate_poly(poly2)

poly_sum = sum_polys(poly1, poly2)

print(print_polynomial(poly1))
print(print_polynomial(poly2))
print(print_polynomial(poly_sum))

with open("poly_sum.txt", "w") as file:
    file.write(print_polynomial(poly_sum))
