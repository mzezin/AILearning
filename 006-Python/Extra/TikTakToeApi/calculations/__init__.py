def make_move(state, x, y, player):
    state["field"][y][x] = player
    state["currentMove"] += 1