def validate_int(value: str) -> int | None:
    try:
        result = int(value)
    except ValueError:
        return None
    else:
        return result


def input_int(msg="") -> int:
    while True:
        result = validate_int(input(msg))
        if result is None:
            print("Ошибка, повторите ввод")
        else:
            return result


def validate_float(value: str) -> float | None:
    try:
        result = float(value)
    except ValueError:
        return None
    else:
        return result


def input_float(msg="") -> float:
    while True:
        result = validate_float(input(msg))
        if result is None:
            print("Ошибка, повторите ввод")
        else:
            return result


def validate_complex(value: str) -> complex | None:
    try:
        [rational_part, complex_part] = value.split("+")
        complex_part = complex_part[:-1]
        result = complex(float(rational_part), float(complex_part))
    except:
        print("Ошибка, повторите ввод")
    else:
        return result


def input_complex(msg="") -> complex:
    while True:
        print("Формат комплексных чисел: 23+2e2j")
        result = validate_complex(input(msg))
        if result is None:
            print("Ошибка, повторите ввод")
        else:
            return result
