x = int(input("kaç tane araba gireceksin? "))
results = []
hours = []

for i in range(x):
    hours.append(float(input(f"{i+1}. müşterinin park saati: ")))


def calculate_fee(hour):
    price = 0
    if 0 < hour:
        price += 2
    if hour > 3:
        if price < 10:
            price += (hour - 3) * 0.5
        if price >= 10:
            price = 10
    return price


print("\tAraba Saat\t\tÜcret")


for i in range(len(hours)):
    print("%s %9.1f %11.1f $" % (i+1, hours[i], calculate_fee(hours[i])))

