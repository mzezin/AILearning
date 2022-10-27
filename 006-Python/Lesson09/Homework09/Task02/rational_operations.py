from logger import Logger


def addition(a: float, b: float, logger=Logger()) -> float:
    logger.log([a, b], "+")
    return a + b


def subtraction(a: float, b: float, logger=Logger()) -> float:
    logger.log([a, b], "-")
    return a - b


def production(a: float, b: float, logger=Logger()) -> float:
    logger.log([a, b], "*")
    return a * b


def division(a: float, b: float, logger=Logger()) -> float:
    logger.log([a, b], "/")
    return a / b
