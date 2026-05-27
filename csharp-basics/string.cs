using System;
using System.Text;
public class New
{
  public static void Main()
    {
       string firstName = "Bob";
       string message = "Hello " + firstName;
       Console.WriteLine(message);

// STRING CONCATENATION:--
       string firstName = "Mayank";
       string greeting = "Hello";
       string message = greeting + " " + firstName + "!"; ////we can create another way
       Console.WriteLine(message);
       Console.WriteLine(greeting + " " + firstName + "!");


// STRING INTERPOLATION:--
        //string message= $"Hellow {firstName}!"; //$ and {} is must
        // Console.WriteLine(message);
        int version = 11;
        string updateText = "Update to Windows";
        // string Msg=$"{updateText} {version}";
        // Console.WriteLine(Msg);  Also be writen as:--
        Console.WriteLine($"{updateText} {version}");

  //verbatim litral:-
    string projectName = "First-Project";
    Console.WriteLine($@"C:\Output\{projectName}\Data");
    
    }
}
