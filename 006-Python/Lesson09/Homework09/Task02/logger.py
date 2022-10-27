class Logger:
    def __init__(self, source='N/A', username='local', dummy_mode=True, filename='log.csv'):
        self.source = source
        self.username = username
        self.dummy_mode = dummy_mode
        self.filename = filename

    def log(self, arguments, operator):
        log_item = f'{self.source}, {self.username}, {arguments[0]}, {arguments[1]}, {operator}\n'
        if self.dummy_mode:
            print(log_item)
            return
        file = open(self.filename, 'a')
        file.write(log_item)
        file.close()
