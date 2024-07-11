using System;
using System.ComponentModel.Design;

class student
{
    public int ssn;
    public int age;
    public String name;
    public String phone;
    public student(int ssn, int age, String name)
    {
        this.ssn = ssn;
        this.age = age;
        this.name = name;
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
            student s1 =new student(15 ,12,"shreen");
        /*
        // 1
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        if (input > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is negative.");
        }

        // 2
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        { Console.WriteLine("num is even"); }
        else
            Console.WriteLine("num is odd");

      
    // 3
            Console.Write("Enter the length of the rectangle: ");
            int lengthInput =int.Parse( Console.ReadLine());

  
            Console.Write("Enter the width of the rectangle: ");
            int widthInput = int.Parse(Console.ReadLine());

          
             if (lengthInput == widthInput)
                {
                    Console.WriteLine("The rectangle is a square.");
                }
                else
               
            Console.WriteLine("The rectangle is not a square.");

              Console.Write("Enter a number: ");
               int numper = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine(numper*i);
                }
                
        while (true)
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your ID: ");
            int id = int.Parse(Console.ReadLine());

            int age = -1;
            while (age <= 0)
            {
                Console.WriteLine("Enter your age (must be positive): ");
                age = int.Parse(Console.ReadLine());

                if (age > 0)
                {
                    Console.WriteLine($"Your name: {name}");
                    Console.WriteLine($"Your age: {age}");
                    Console.WriteLine($"Your ID: {id}");
                }
                else
                {
                    Console.WriteLine("Age must be a positive number.");
                }
            }
        }*/


    }
}