# 1. Дан список чисел. Создайте список, в который попадают числа, описываемые возрастающую последовательность. Порядок элементов менять нельзя.
    
#     *Пример:* 
    
#     [1, 5, 2, 3, 4, 6, 1, 7] => [1, 2, 3] или [1, 7] или [1, 6, 7] и т.д.
num = [11, 5, 2, 3, 4, 6, 1, 7, 9, 8, 10]

def nextmax(listt):    
    max = listt[0]
    res = [listt[0]]
    for i in range(len(listt)):
        if listt[i] > max:
            max = listt[i]
            res.append(max)
    if len(res) == 1:
        res = nextmax(listt[1:])
    return res

print(nextmax(num))