# Напишите программу для. проверки истинности утверждения
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

possible_predicates = [False, True]


def check_condition(x, y, z):
    return not (x or y or z) == (not x and not y and not z)


for x in possible_predicates:
    for y in possible_predicates:
        for z in possible_predicates:
            print(
                f"Для x: {x}, y: {y}, z: {z} -  значение условия: {check_condition(x,y,z)}")
