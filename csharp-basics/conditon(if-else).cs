using System;
public class Test{
public static void Main(){
// Random rand = new Random();
// int coin = rand.Next(0, 2);
// Console.WriteLine(coin == 0 ? "Heads" : "Tails");

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")){

  if(level > 55){
    Console.WriteLine("Welcome, Super Admin user.");
  }
  else if (level <= 55){
    Console.WriteLine("Welcome, Admin user.");
  }

 } 
else if(permission.Contains("Manager")){
    if(level >= 20){
        Console.WriteLine("Contact an Admin for access.");
    }
    
    else if (level < 20){
        Console.WriteLine("You do not have sufficient privileges.");
    }
 }  
else 
{
     Console.WriteLine("You do not have sufficient privileges.");
}
}
}