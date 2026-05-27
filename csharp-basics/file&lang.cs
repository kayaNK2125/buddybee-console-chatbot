using System;
using System.Text;

public class Test
{
    public static void Main()
    {  
    Console.WriteLine("Hello\nWorld!"); //for adding newline
    Console.WriteLine("Hello\tWorld!"); //for adding tab
    
    // Console.WriteLine("Hello "World"!"); ERROR!!
    Console.WriteLine("Hello \"World\"!");

    // Console.WriteLine("c:\source\repos");
    Console.WriteLine("c:\\source\\repos");

    Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
    Console.WriteLine("Invoice: 1021\t\tComplete!");
    Console.WriteLine("Invoice: 1022\t\tComplete!");
    Console.Write("\nOutput Directory:\t");

    Console.Write(@"c:\invoices");

    //  Console.WriteLine(@"    c:\source\repos    
    //       (this is where your code goes)");
    
Console.OutputEncoding = Encoding.UTF8;
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

    }
}

