import random

print("Now I pick a number between 1 and 100")

a = 1
b = 100
c = random.randint(a,b)

d = input("Now think of a number and put it here")
d = int(d)

if (c == d):
    print(f"you pick {d} and I pick {c} you win")
else:
    print(f"I pick {c} hahahaha you loose")