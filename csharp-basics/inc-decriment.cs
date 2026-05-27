using System;
public class New
{
    public static void Main()
    {
//ADDITION:-
    int firstNumber = 12;
    int secondNumber = 7;
    Console.WriteLine(firstNumber + secondNumber);
  //MIXING:
    string firstName = "Bob";
    int widgetsSold = 7;
    Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
  //other way:
    Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

//Increment:-

   int value = 1;  // value is now 1.
   value = value + 2;  // value is now 3.
   value++;    // value is now 4.
   Console.WriteLine(value);

//Increment and decrement:-

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
   
//Position the increment and decrement operators:-
  value++;
  Console.WriteLine("first: "+ value);
  Console.WriteLine($"secound: {value++}");
  Console.WriteLine("Third: "+ value);
  Console.WriteLine("Fourth: "+ (++value));
    }
}