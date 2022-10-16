from json import dumps, loads
from flask import Flask, jsonify, request
from marshmallow import Schema, fields, ValidationError, validate
from calculations.index import make_move

app = Flask(__name__)

# class Move():
#     def __init__(self, x, y, currentPlayer):
#         self.x = x
#         self.y = y
#         self.currentPlayer = currentPlayer
#     def __repr__(self) -> str:
#         return f"<Move (coords={self.x} {self.y})>"

class MoveSchema(Schema):
    x = fields.Integer(required=True, validate=validate.Range(min=0, max=3))
    y = fields.Integer(required=True, validate=validate.Range(min=0, max=3))
    currentPlayer = fields.String(required=True, validate=validate.OneOf(["X", "0"]))
    

initial_state = {
    "currentMove": 1,
    "currentPlayer": "X",
    "field": [
        [" ", " ", " "],
        [" ", " ", " "],
        [" ", " ", " "]
    ]}

global state
state = initial_state.copy()


@app.route("/game", methods=['GET'])
def show_state():
    return jsonify(state), '200'


@app.route("/game", methods=['POST'])
def process_move():
    move = request.get_json()
    try:
        MoveSchema().load(move)
    except ValidationError as err:
        return err.messages, '400'
    make_move(move["x"], move["y"], move["currentPlayer"])
    return state, '201'



