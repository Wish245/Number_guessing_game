import random

print("Now I pick a number between 1 and 100")

a = 1
b = 100
target_number = random.randint(a,b)

guess_number = input("Now think of a number and put it here: ")
guess_number = int(guess_number)

no_attempts = 0

while (target_number!=guess_number):
    guessing_value = target_number - guess_number
    if(guessing_value >0 and guessing_value < 10):
        guess_number = input("You are bit low but close guess again: ")
        guess_number = int(guess_number)
        no_attempts += 1
    if(guessing_value >0 and guessing_value > 10):
        guess_number = input("you are too low guess again: ")
        guess_number = int(guess_number)
        no_attempts += 1
    if(guessing_value <0 and guessing_value < 10):
        guess_number = input("You are bit high but close guess again: ")
        guess_number = int(guess_number)
        no_attempts += 1
    if(guessing_value <0 and guessing_value > 10):
        guess_number = input("you are too high guess again: ")
        guess_number = int(guess_number)
        no_attempts += 1
print(f"you guessed correctly I guess {target_number} it took you {no_attempts} timess")

    