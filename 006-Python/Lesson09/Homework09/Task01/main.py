# Создайте программу для игры в ""Крестики-нолики"" при помощи виртуального окружения и PIP

from tictactoe import Board
from enum import Enum, auto


class Player(Enum):
    X = auto()
    O = auto()


def make_move(board: Board = Board(), current_player=Player.X):
    result = board.result()
    if result is not None:
        print("Игра окончена")
        print(board)
        if result == 1:
            print("Победил игрок X")
        elif result == 2:
            print("Победил игрок 2")
        else:
            print("Ничья")
        return
    print(board)
    print(f"Ход игрока {current_player.name}")
    try:
        [x, y] = input("Введите координаты хода через пробел:").split(" ")
        board.push((int(x), int(y)))
    except:
        print("Неправильные координаты")
    else:
        current_player = Player.O if current_player == Player.X else Player.X
    make_move(board, current_player)


make_move()
