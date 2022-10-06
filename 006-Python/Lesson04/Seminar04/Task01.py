
# a = 6
# b = 8
# nok = a * b

# for i in range(nok, max(a,b), -1):
#   if i % a == 0 and i % b:
#     nok = i
# print(nok)

a = 9
b = 12
nok = max(a, b)
for i in range(nok, nok**2):
    if (i % a == 0 and i % b == 0):
        print(i)
        break