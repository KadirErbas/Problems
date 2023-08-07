x = int(input("kaç tane araba gireceksin? "))
amounts = []
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
total_amount = 0
total_hours = 0

for i in range(len(hours)):
    total_hours += hours[i]
    amount = calculate_fee(hours[i])
    total_amount += amount
    amounts.append(amount)

for i in range(len(hours)):
    print("%s %9.1f %11.2f $" % (i+1, hours[i], amounts[i]))

print("TOPLAM %4.1f %11.2f $" % (total_hours, total_amount))
