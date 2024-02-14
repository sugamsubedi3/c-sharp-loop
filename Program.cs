def calculate_times_table():
    while True:
        try:
            n = int(input("Enter a number below 10: "))
            if 1 <= n < 10:
                for i in range(1, 10):
                    print(f"{i} * {n} = {i * n}")
                break
            else:
                print("Please enter a number below 10.")
        except ValueError:
            print("Please enter a valid number.")

calculate_times_table()
