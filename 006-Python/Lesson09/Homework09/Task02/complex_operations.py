from logger import Logger


def addition(a: complex, b: complex, logger=Logger()) -> complex:
    logger.log([a, b], "+")
    return a + b


def subtraction(a: complex, b: complex, logger=Logger()) -> complex:
    logger.log([a, b], "-")
    return a - b


def production(a: complex, b: complex, logger=Logger()) -> complex:
    logger.log([a, b], "*")
    return a * b


def division(a: complex, b: complex, logger=Logger()) -> complex:
    logger.log([a, b], "/")
    return a / b
