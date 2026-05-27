// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);


Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);
dice.Next();
Console.WriteLine(roll);