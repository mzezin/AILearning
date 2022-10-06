# Создайте программу для игры с конфетами человек против человека.
# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой.
# За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте как наделить бота ""интеллектом""
from random import randint


def input_int(msg=""):
    while True:
        try:
            result = int(input(msg))
        except ValueError:
            print("Ошибка, повторите ввод")
        else:
            return result


def start_multiplayer_game(initial_amount=2021, max_move=28):
    print(
        f"Начало игры, на столе лежит {initial_amount} конфет, вы можете взять от 1 до {max_move} конфет.")
    is_first_player_move = True
    current_player = "Первый"
    amount = initial_amount
    while amount > 0:
        while True:
            current_player = "Первый" if is_first_player_move else "Второй"
            move = input_int(
                f"{current_player} игрок, ваш ход. На столе осталось {amount} конфет, введите количество конфет: ")
            if 1 <= move <= max_move and move <= amount:
                break
            else:
                print("Вы не можете взять столько конфет")
        amount -= move
        is_first_player_move = not is_first_player_move
    print(
        f"Поздравляем Вас, {current_player} игрок. Вы взяли последние конфеты и победили.")


def start_random_bot_game(initial_amount=2021, max_move=28):
    print(
        f"Начало игры, на столе лежит {initial_amount} конфет, вы можете взять от 1 до {max_move} конфет.")
    is_human_player_move = bool(randint(0, 1))
    amount = initial_amount
    while amount > 0:
        while True:
            if is_human_player_move:
                move = input_int(
                    f"Ваш ход. На столе осталось {amount} конфет, введите количество конфет: ")
            else:
                move = randint(1, max_move if amount > max_move else amount)
                print(
                    f"На столе оставалось {amount} конфет. Бот(случайный) сделал ход. Он взял {move} конфет")
            if 1 <= move <= max_move and move <= amount:
                break
            else:
                print("Вы не можете взять столько конфет")
        amount -= move
        is_human_player_move = not is_human_player_move
    if not is_human_player_move:
        print("Поздравляем Вас. Вы взяли последние конфеты и победили.")
    else:
        print("К сожалению, вы проиграли, Бот(случайный) взял последние конфеты и победил")


def start_strategic_bot_game(initial_amount=2021, max_move=28):
    print(
        f"Начало игры, на столе лежит {initial_amount} конфет, вы можете взять от 1 до {max_move} конфет.")
    is_human_player_move = bool(randint(0, 1))
    amount = initial_amount
    while amount > 0:
        while True:
            if is_human_player_move:
                move = input_int(
                    f"Ваш ход. На столе осталось {amount} конфет, введите количество конфет: ")
            else:
                leftover = amount % max_move
                if leftover == 0:
                  move = randint(1, max_move if amount > max_move else amount)
                else:
                  move = leftover  
                print(
                    f"На столе оставалось {amount} конфет. Бот(стратегический) сделал ход. Он взял {move} конфет")
            if 1 <= move <= max_move and move <= amount:
                break
            else:
                print("Вы не можете взять столько конфет")
        amount -= move
        is_human_player_move = not is_human_player_move
    if not is_human_player_move:
        print("Поздравляем Вас. Вы взяли последние конфеты и победили.")
    else:
        print("К сожалению, вы проиграли, Бот(стратегический) взял последние конфеты и победил")


print('Добро пожаловать в игру "Забери конфетку"')
while True:
    print("Выберите режим игры:")
    print("1 - Два игрока")
    print("2 - Против Бота(случайный)")
    print("3 - Против Бота(стратегический)")
    mode = input_int()
    if 1 <= mode <= 3:
        break
    print("Неправильный ввод")
amount = input_int("Введите общее количество конфет: ")
max_move = input_int(
    "Введите максимальное количество конфет, которое можно взять за один ход: ")

if mode == 1:
    start_multiplayer_game(amount, max_move)
elif mode == 2:
    start_random_bot_game(amount, max_move)
elif mode == 3:
    start_strategic_bot_game(amount, max_move)
