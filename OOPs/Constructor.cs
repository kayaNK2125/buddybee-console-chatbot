using System;
//commenting every details that i am using this for what so that i will do a quick revisions
public class Hen  // Creating a Car class
{
    public string shouting;  // Creating a field just taken a example of hen atributes like gender,shouting or not etc;0
    public string gender;
    public int quantity;
    
    // Creating a class constructor for the hen class
    public Hen()
    {
        shouting="NO";  // Seting my initial value for model hen that is no its not shouting 
    }

    public Hen(string ishouthing,string itsgender,int itsquantity) //passing perameters field so that i can just pass data directly   
    {
        shouting=ishouthing; 
        gender = itsgender;
        quantity = itsquantity;
    }
    
  static void Main()
  {
    Hen hen = new Hen();  // Create an object of the Car Class (this will call the constructor)
    Console.WriteLine(hen.shouting);  // Print the value of model for this output should be "NO"
    

    Hen hen1 = new Hen("YES","MALE",17);  
    Console.WriteLine(hen1.shouting + " hen is shouting and it is " + hen1.gender + " ,quantity is "+ hen1.quantity); 
    //for this output should be "YES hen is shouting and it is MALE ,quantity is 17



   // I know C# uses class defined in other c# files so i defined Dog class in file "dogConstructor.cs"  
    Dog myObj1 = new Dog();  
    Dog myObj2 = new Dog();
    Console.WriteLine(myObj1.Gender);
    Console.WriteLine(myObj2.age);

    //output should be what i passed in other file 
  }
}
