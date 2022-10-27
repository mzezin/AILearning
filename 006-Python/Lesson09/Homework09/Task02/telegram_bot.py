import os
from dotenv import load_dotenv
from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove, Update
from telegram.ext import Updater, CommandHandler, ContextTypes, ConversationHandler, MessageHandler, Filters
import rational_operations, complex_operations, validators
from logger import Logger


def bot_start():
    dotenv_path = os.path.join(os.path.dirname(__file__), '.env')
    if os.path.exists(dotenv_path):
        load_dotenv(dotenv_path)

    token = os.environ.get('TOKEN')
    updater = Updater(token)

    [
        SELECT_TYPE,
        SELECT_RATIONAL,
        SELECT_COMPLEX,
        RATIONAL_ADDITION,
        RATIONAL_SUBSTRACTION,
        RATIONAL_PRODUCTION,
        RATIONAL_DIVISION,
        COMPLEX_ADDITION,
        COMPLEX_PRODUCTION,
        COMPLEX_SUBSTRACTION,
        COMPLEX_DIVISION
    ] = range(11)

    def start(update: Update, context: ContextTypes) -> int:
        """Starts the conversation and asks the user about their gender."""
        reply_keyboard = [["Рациональные", "Комплексные"]]
        update.message.reply_text(
            "Выберите тип калькулятора",
            reply_markup=ReplyKeyboardMarkup(
                reply_keyboard, one_time_keyboard=True, input_field_placeholder="Рациональные или комплексные?"
            ),
        )
        return SELECT_TYPE

    def operation_helper(operation_type):
        def operation(update: Update, context: ContextTypes) -> int:
            logger = Logger('Telegram bot', update.message.from_user.username, False)
            [a, b] = update.message.text.split()
            if operation_type == RATIONAL_ADDITION:
                a = validators.validate_float(a)
                b = validators.validate_float(b)
                update.message.reply_text(f"{a} + {b} = {rational_operations.addition(a, b, logger)}")
            elif operation_type == RATIONAL_DIVISION:
                a = validators.validate_float(a)
                b = validators.validate_float(b)
                update.message.reply_text(f"{a} / {b} = {rational_operations.division(a, b, logger)}")
            elif operation_type == RATIONAL_SUBSTRACTION:
                a = validators.validate_float(a)
                b = validators.validate_float(b)
                update.message.reply_text(f"{a} - {b} = {rational_operations.subtraction(a, b, logger)}")
            elif operation_type == RATIONAL_PRODUCTION:
                a = validators.validate_float(a)
                b = validators.validate_float(b)
                update.message.reply_text(f"{a} * {b} = {rational_operations.production(a, b, logger)}")
            elif operation_type == COMPLEX_ADDITION:
                a = validators.validate_complex(a)
                b = validators.validate_complex(b)
                # b = complex(b.split("+")[0], b.split("+")[1][:-1])
                update.message.reply_text(f"{a} + {b} = {complex_operations.addition(a, b, logger)}")
            elif operation_type == COMPLEX_SUBSTRACTION:
                a = validators.validate_complex(a)
                b = validators.validate_complex(b)
                update.message.reply_text(f"{a} - {b} = {complex_operations.subtraction(a, b, logger)}")
            elif operation_type == COMPLEX_PRODUCTION:
                a = validators.validate_complex(a)
                b = validators.validate_complex(b)
                update.message.reply_text(f"{a} * {b} = {complex_operations.production(a, b, logger)}")
            elif operation_type == COMPLEX_DIVISION:
                a = validators.validate_complex(a)
                b = validators.validate_complex(b)
                update.message.reply_text(f"{a} / {b} = {complex_operations.division(a, b, logger)}")
            return SELECT_TYPE

        return operation

    def select_rational(update: Update, context: ContextTypes) -> int:
        operation_type = update.message.text
        update.message.reply_text("Введите два рациональных числа, разделенных пробелом, например  2334 123.434: ")
        if operation_type == "Суммирование":
            return RATIONAL_ADDITION
        elif operation_type == "Вычитание":
            return RATIONAL_SUBSTRACTION
        elif operation_type == "Произведение":
            return RATIONAL_ADDITION
        elif operation_type == "Деление":
            return RATIONAL_DIVISION
        else:
            return SELECT_RATIONAL

    def select_complex(update: Update, context: ContextTypes) -> int:
        operation_type = update.message.text
        update.message.reply_text("Введите два комплексных числа, разделенных пробелом, например 23+2e2j 12+3e-4j: ")
        if operation_type == "Суммирование":
            return COMPLEX_ADDITION
        elif operation_type == "Вычитание":
            return COMPLEX_SUBSTRACTION
        elif operation_type == "Произведение":
            return COMPLEX_ADDITION
        elif operation_type == "Деление":
            return COMPLEX_DIVISION
        else:
            return SELECT_COMPLEX

    def select_type(update: Update, context: ContextTypes) -> int:
        calc_type = update.message.text
        reply_keyboard = [["Суммирование", "Вычитание", "Произведение", "Деление"]]
        update.message.reply_text(
            "Выберите тип операции",
            reply_markup=ReplyKeyboardMarkup(
                reply_keyboard, one_time_keyboard=True, input_field_placeholder="Тип операции?"
            ), )
        if calc_type == "Рациональные":
            return SELECT_RATIONAL
        elif calc_type == "Комплексные":
            return SELECT_COMPLEX
        else:
            return SELECT_TYPE

    def cancel(update: Update, context: ContextTypes) -> int:
        update.message.reply_text(
            "Работа с калькулятором завершена", reply_markup=ReplyKeyboardRemove()
        )
        return ConversationHandler.END

    main_menu_handler = ConversationHandler(
        entry_points=[CommandHandler("start", start)],
        states={
            SELECT_TYPE: [MessageHandler(Filters.regex("^(Рациональные|Комплексные)$"), select_type)],
            SELECT_RATIONAL: [MessageHandler(Filters.regex("^(Суммирование|Вычитание|Произведение|Деление)$"),
                                             select_rational)],
            SELECT_COMPLEX: [MessageHandler(Filters.regex("^(Суммирование|Вычитание|Произведение|Деление)$"),
                                            select_complex)],
            RATIONAL_ADDITION: [MessageHandler(Filters.text, operation_helper(RATIONAL_ADDITION))],
            RATIONAL_SUBSTRACTION: [MessageHandler(Filters.text, operation_helper(RATIONAL_SUBSTRACTION))],
            RATIONAL_PRODUCTION: [MessageHandler(Filters.text, operation_helper(RATIONAL_PRODUCTION))],
            RATIONAL_DIVISION: [MessageHandler(Filters.text, operation_helper(RATIONAL_DIVISION))],
            COMPLEX_ADDITION: [MessageHandler(Filters.text, operation_helper(COMPLEX_ADDITION))],
            COMPLEX_SUBSTRACTION: [MessageHandler(Filters.text, operation_helper(COMPLEX_SUBSTRACTION))],
            COMPLEX_PRODUCTION: [MessageHandler(Filters.text, operation_helper(COMPLEX_PRODUCTION))],
            COMPLEX_DIVISION: [MessageHandler(Filters.text, operation_helper(COMPLEX_DIVISION))]

        },
        fallbacks=[CommandHandler("cancel", cancel)],
    )
    updater.dispatcher.add_handler(main_menu_handler)
    print('server start')
    updater.start_polling()
    updater.idle()
