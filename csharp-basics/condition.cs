// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
using System;
public class New
{
    public static void Main()
    {
    int saleAmount = 1001;
    int discount = saleAmount > 1000 ? 100 : 50;
    Console.WriteLine($"Discount: {discount}");


    saleAmount = 900;
    Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
}
}