from logger import Logger
from validators import input_float, input_complex, input_int
import rational_operations, complex_operations


def bot_mode() -> bool:
    print("Выбор режима работы:")
    print("=" * 100)
    print("1 - Консольный режим")
    print("2 - Запуск телеграм-бота")
    selection = input_int()

    if selection == 1:
        return False
    elif selection == 2:
        return True
    else:
        print("Неправильный ввод")
        bot_mode()


def main_menu(console_logger = Logger("console", "localUser", False)):
    print("Выбор типа операции:")
    print("=" * 100)
    print("1 - Рациональные числа")
    print("2 - Комплексные числа")
    print("0 - Выход")
    selection = input_int()
    if selection == 1:
        rational_menu(console_logger)
    elif selection == 2:
        complex_menu(console_logger)
    elif selection == 0:
        quit()
    else:
        print("Неправильный ввод")
        main_menu()


def rational_menu(console_logger):
    print("Работа с рациональными числами:")
    print("=" * 100)
    print("1 - Суммирование")
    print("2 - Вычитание")
    print("3 - Произведение")
    print("4 - Деление")
    print("0 - Выход")
    selection = input_int()
    if selection == 1:
        print(rational_operations.addition(input_float("Число A: "), input_float("Число B: "), console_logger))
    elif selection == 2:
        print(rational_operations.subtraction(input_float("Число A: "), input_float("Число B: "), console_logger))
    elif selection == 3:
        print(rational_operations.production(input_float("Число A: "), input_float("Число B: "), console_logger))
    elif selection == 4:
        print(rational_operations.division(input_float("Число A: "), input_float("Число B: "), console_logger))
    elif selection == 0:
        main_menu(console_logger)
    else:
        print("Неправильный ввод")
    rational_menu(console_logger)


def complex_menu(console_logger):
    print("Работа с комплексными числами:")
    print("=" * 100)
    print("1 - Суммирование")
    print("2 - Вычитание")
    print("3 - Произведение")
    print("4 - Деление")
    print("0 - Выход")
    selection = input_int()
    if selection == 1:
        print(complex_operations.addition(input_complex("Число A: "), input_complex("Число B: "), console_logger))
    elif selection == 2:
        print(complex_operations.subtraction(input_complex("Число A: "), input_complex("Число B: "), console_logger))
    elif selection == 3:
        print(complex_operations.production(input_complex("Число A: "), input_complex("Число B: "), console_logger))
    elif selection == 4:
        print(complex_operations.division(input_complex("Число A: "), input_complex("Число B: "), console_logger))
    elif selection == 0:
        main_menu(console_logger)
    else:
        print("Неправильный ввод")
    complex_menu(console_logger)
