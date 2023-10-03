Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3){
    if(roll1 == roll2 && roll2 == roll3){
        total += 6;
        Console.WriteLine("You got a Triple +6 points");
    }else{
        total+= 2;
        Console.WriteLine("You got a Double +2 points");
    }
    
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}