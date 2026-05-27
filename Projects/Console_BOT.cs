using System;
using System.IO; 
using System.Collections.Generic; 
using System.Threading; 
public class Demo
{
    public static void BotSay(string message)
    {
        foreach (char ch in message){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(ch);
            Thread.Sleep(8);
            Console.ResetColor();
        }
    }
    public static string UserInput()
    {
        Console.ForegroundColor = ConsoleColor.White;
        string input = Console.ReadLine();
        Console.ResetColor();
        return input;
    }

    public static int GetValidInteger()
    {
        while (true)
        {
            string input = Console.ReadLine();
            int choice;  
            bool success = int.TryParse(input , out choice);
            if (success)
            {
                return choice;
            }
            else
                BotSay("Please Enter Valid Integer Number"); 
        }
    }

    public static void Calculate()
    {
        while (true)
        {
            BotSay("Choose operator \n 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division\n 5.string Comparison\n 6.back");
            BotSay("\nJust Enter number I will automatically fetch operator\n");

            string comment = Console.ReadLine();
            if (comment=="back")
            {
                BotSay("phewww Out of calculation Mode hehe\n");
                return;
            }
            else
            {
                int chosen;
                bool success = int.TryParse(comment, out chosen);
                if (success)
                { 
                if (chosen == 1)
                {
                    BotSay("Enter how many numbers you want to add:");
                    int a = GetValidInteger();

                    int sum = 0;
                    for (int i = 0; i < a; i++)
                    {
                        BotSay("Enter number: ");
                        int num = GetValidInteger();
                        sum += num;
                    }
                    BotSay("Total = " + sum + "\n");
                    break;
                }
                else if (chosen == 2)
                {
                    BotSay("Enter how many numbers you want to subtract:");
                    int a = GetValidInteger();
                    int result = 0;

                    for (int i = 0; i < a; i++)
                    {
                        BotSay("Enter number: ");
                        int number = GetValidInteger();

                        if (i == 0)
                        {
                            result = number;
                        }
                        else
                        {
                            result -= number;
                        }
                    }
                    BotSay("Subtraction = " + result + "\n");
                    break;
                }
                else if (chosen == 3)
                {
                    BotSay("Enter how many numbers you want to Multiply:");
                    int a = GetValidInteger();
                    int result = 1;
                    for (int i = 0; i < a; i++)
                    {
                        BotSay("Enter number: ");
                        int number = GetValidInteger();
                        if (i == 0)
                        {
                            result = number;
                        }
                        else
                        {
                            result = result * number;
                        }
                    }
                    BotSay("Multiplication = " + result + "\n");
                    break;
                }
                else if (chosen == 4)
                {
                    BotSay("Enter how many numbers you want to Divide:");
                    int a = GetValidInteger();
                    double result = 1;
                    for (int i = 0; i < a; i++)
                    {
                        BotSay("Enter number: ");
                        int number = GetValidInteger();
                        if (i == 0)
                        {
                            result = number;
                        }
                        else
                        {
                            result = result / number;
                        }
                    }
                    BotSay("Division = " + result + "\n");
                    break;
                }
                else if (chosen == 5)
                {
                    BotSay("Enter first String:");
                    string f = Console.ReadLine();
                    BotSay("Enter Second String:");
                    string s = Console.ReadLine();
                    f = f.ToLower();
                    s = s.ToLower();
                    if (f == s)
                    {
                        BotSay("THEY ARE SAMEEE");
                    }
                    else
                        BotSay("They are not same.\n");
                }
                break;
                }
                else
                {
                    BotSay("Invalid values passed *-*\n");
                }  
        }
    }
    }
    public static void ShowBanner()
    {
        Console.WriteLine("=======================================================================");
        Console.WriteLine("||                         BuddyBee Console Bot                      ||");
        Console.WriteLine("=======================================================================");
        BotSay("I am a non-API bot so I can only perform certain tasks, feel free to type help for all commands.\n");
    }

    public static void Main()
    {
        List<string> history = new List<string>();
        string[] jokes =
        {
            "Why do programmers hate nature? Too many bugs.\n",
            "Why did the computer get cold? It forgot to close Windows.\n",
            "Why do Java developers wear glasses? Because they don't C#.\n",
            "Why was the keyboard crying? Because it lost its control.\n",
            "Why did the programmer quit his job? Because he didn't get arrays.\n"
        };

        Console.WriteLine("=======================================================================");
        Console.WriteLine("||                         BuddyBee Console Bot                      ||");
        Console.WriteLine("=======================================================================");
        string name;
        string botname = "BuddyBee_templatev2";
        if (File.Exists("username.txt"))
        {
            name = File.ReadAllText("username.txt");
            BotSay("Hello Good to see you again " + name + "\n");
        }
        else
        {
            BotSay("Hello! How are you i am " + botname + " chat bot can i know you name? for further assist\n");
            name = Console.ReadLine();
            File.WriteAllText("username.txt",name);
            BotSay("Hi " + name + ", nice to meet you. What task do you want me to do today?\n");
            BotSay("i am no API bot So i can only perform task that i know, here is the list of what i can do: \n1)joke\n2)time\n3)calculate\n4)clear\n5)help\n");
        }

        while (true)
        {
            string input = UserInput();
            input = input.ToLower();
            history.Add(input);
            switch (input)
            {
                case "hi":
                    BotSay("Hi how are you\n");
                    break;    
                case "hey":
                    BotSay("hiiiii\n");
                    break;
                case "how are you":
                    BotSay("i am fine running perfectly though hehe you tell how's everything going\n");
                    break;
                case "calculate":
                case "calc":
                case "calculator":
                    Calculate();
                    break;
                case "time":
                    BotSay("Current Time: " + DateTime.Now.ToString("hh:mm tt\n"));
                    break;
                case "joke":
                    Random random = new Random();
                    int Index = random.Next(jokes.Length);
                    BotSay(jokes[Index]);
                    break;
                case "exit":
                    return;
                case "help":
                    BotSay("Here are all Available Commands you can use:\n 1)time\n 2)calculate\n 3)joke\n 4)exit\n 5)clear\n 6)history\n 7)calc/calculator\n 8)back (inside calculator)\n");
                    BotSay("Enter your Choice:");
                    break;
                case "clear":
                    Console.Clear();
                    ShowBanner();
                    break;
                case "history":
                    foreach (string commands in history)
                    {
                        Console.WriteLine("->" + commands);
                    }
                    break;    
                case "buddybee":
                   BotSay("BuddyBee Template v3 Features:\n" +
                    "1) Continuous chatbot conversation system\n" +
                    "2) Advanced calculator with Addition, Subtraction, Multiplication and Division\n" +    
                    "3) String comparison system\n" +
                    "4) Random programming jokes\n" +
                    "5) Real-time clock command\n" +
                    "6) Command history tracking\n" +
                    "7) Help and clear commands\n" +
                    "8) Typing animation effect\n" +
                    "9) Colored console chat interface\n" +
                    "10) Username memory system using file handling\n" +
                    "11) Case-insensitive command handling\n" +
                    "12) Safer integer validation using TryParse\n" +
                    "13) Calculator escape/back system\n" +
                    "14) Multiple command aliases like calc/calculator\n" +
                    "15) Non-API lightweight chatbot architecture built fully in C#\n" +
                        "\nFuture Plans:\n" +
                        "- API Integration\n" +
                        "- .NET Upgrade\n" +
                        "- GUI/Web Version\n");
                    break;
                default:
                    BotSay("Unknown Command. \n");
                    break;
            }
               
        }
    }
}