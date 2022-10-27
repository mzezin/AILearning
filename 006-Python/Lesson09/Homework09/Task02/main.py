# Прикрутить бота к задачам с предыдущего семинара:

# Создать калькулятор для работы с рациональными и комплексными числами,
# организовать меню, добавив в неё систему логирования

from console_menu import main_menu, bot_mode
from telegram_bot import bot_start
from threading import Thread

if bot_mode():
    bot_start()
else:
    main_menu()

