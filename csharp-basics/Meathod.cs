using System; 
public class hii_csharp{
     static void my_Meathod(){ 
        // Creting Meathods
     Console.WriteLine(5 + 5);
     }
static void meathodWithPERA(string name){
    Console.WriteLine("Wellcome " + name);
    }
static void meathodWithmanyPERA(string name, int age){
    Console.WriteLine("Wellcome " + name + " your age should be " + age);
    }
static void Defaultpera(string name="Name not provided", int age=0){
    Console.WriteLine("Wellcome " + name + " your age should be " + age);
    }
static int fetching(int x){
    return 425 * x ;
    }
static int add(int x,int y){
    return x+y ;
    }
static double add(double x,double y){
    return x+y; //MEATHOD (add) OVERLOADING
    }
static void elder(string child1, string child2, string child3){
    Console.WriteLine("elder is " + child3);
    }
public static void Main(){
    Console.WriteLine("hellow c-sharp");
    my_Meathod();
    my_Meathod();
    meathodWithPERA("kayank");
    meathodWithPERA("Mayank");
    meathodWithmanyPERA("kayank",21);
    meathodWithmanyPERA("Mayank",20);
    Defaultpera();
    Console.WriteLine(fetching(5));
    int x=add(2000,125);
    double y=add(40.5,235.7);
    Console.WriteLine(x);
    Console.WriteLine(y);
    elder(child1: "john",child3:"karthik",child2:"sophi"); //keyword 
    } 
}