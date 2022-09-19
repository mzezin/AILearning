# type: ignore

# Напишите программу для. проверки истинности утверждения
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.
def inputHelper(hint):
    return input(f"Введите значение {hint}: ")


def inputData():
    result = []
    x = inputHelper("X")
    result.append(x)
    y = inputHelper("Y")
    result.append(y)
    z = inputHelper("Z")
    result.append(z)
    return result


def checkCondition(x, y, z):
    return not (x or y or z) == (not x and not y and not z)


input = inputData()
print(checkCondition(input[0], input[1], input[2]))
