// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");



// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);\


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("fox") == false); //forcing FALSE
Console.WriteLine(pangram.Contains("cow"));

//REVERSE SCINARIOS(logic negotion):-
Console.WriteLine(!pangram.Contains("fox"));  
Console.WriteLine(!pangram.Contains("cow"));


int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False


string myValue1 = "kayaNK";
string myValue2 = "kayank";
Console.WriteLine(myValue1!= myValue2);
Console.WriteLine(myValue1.Trim().ToLower() != myValue2.Trim().ToLower());
Console.WriteLine(myValue1.Trim().ToLower() == myValue2.Trim().ToLower());