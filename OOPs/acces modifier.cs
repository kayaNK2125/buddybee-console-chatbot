using System;

public class car
{
  //private 
  //To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private
  public string model="mustang";
  
  string brand="mercidies"; //private by default

} //class end
  public class test{
    static void Main(string[] args)
    {
      car CAR=new car();
      Console.WriteLine(CAR.model);
    }
  }