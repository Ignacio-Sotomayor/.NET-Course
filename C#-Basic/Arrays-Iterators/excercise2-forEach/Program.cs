int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int count = 0;

foreach (int items in inventory) {
    sum += items;
    count++;
    Console.WriteLine($"Bin {count} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");