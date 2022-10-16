# Создайте программу для игры в ""Крестики-нолики"".

empty_field = [[" ", " ", " "], [" ", " ", " "], [" ", " ", " "]]


def print_field(field):
    print("    0   1   2   ")
    print("  ┌───┬───┬───┐")
    print("0 │ "+" │ ".join(field[0])+" │")
    print("  ├───┼───┼───┤")
    print("1 │ "+" │ ".join(field[1])+" │")
    print("  ├───┼───┼───┤")
    print("2 │ "+" │ ".join(field[2])+" │")
    print("  └───┴───┴───┘")


def make_move(field, move, symbol):
    result = field.copy()
    move = move.split()
    [x, y] = list(map(int, move))
    if (3 > x >= 0) and (3 > y >= 0) and result[y][x] == " ":
        result[y][x] = symbol
    else:
        new_attempt = input("Неправильный ход, повторите ввод: ")
        result = make_move(field, new_attempt, symbol)
    return result


def check_win(field):
    # проверка ряда
    for row in field:
        if row[0] == "X" and row[1] == "X" and row[2] == "X":
            return "X"
        if row[0] == "0" and row[1] == "0" and row[2] == "0":
            return "0"
    # проверка колонки
    for col in range(3):
        if field[0][col] == "X" and field[1][col] == "X" and field[2][col] == "X":
            return "X"
        if field[0][col] == "0" and field[1][col] == "0" and field[2][col] == "0":
            return "0"
    # проверка диагонали
    if field[0][0] == "X" and field[1][1] == "X" and field[2][2] == "X":
        return "X"
    if field[0][2] == "X" and field[1][1] == "X" and field[2][0] == "X":
        return "X"
    if field[0][0] == "0" and field[1][1] == "0" and field[2][0] == "0":
        return "0"
    if field[0][2] == "0" and field[1][1] == "0" and field[2][0] == "0":
        return "0"
    return None


field = empty_field
moves_count = 0
is_X_move = True
print("Добро пожаловать в игру X-0. В свой ход вводите координаты, разделенные пробелом.")
print_field(field)
while check_win(field) == None and moves_count < 9:
    current_player = "X" if is_X_move else "0"
    field = make_move(field, input(
        f"Ход игрока {current_player}: "), current_player)
    print_field(field)
    is_X_move = not is_X_move
    moves_count += 1
print("Игра окончена")
result = check_win(field)
if result == None:
    print("Ничья")
else:
    print(f"Победитель: игрок {result}")
