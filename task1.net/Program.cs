using System;
using System.ComponentModel.Design;
// shreen
/* class student
{
    public int ssn;
    public int age;
    public String name;
    public String phone;


    public student (int ssn, int age , string name )
    {
        this.ssn = ssn;
        this.age = age;
        this.name = name;
    }

    public void setData(int ssn, int age, String name)
    {
        this.ssn = ssn;
        this.age = age;
        this.name = name;
    }
    public void getData()
    {
        Console.WriteLine($"your name : {name} , your id : {ssn} , your age : {age}");
    }

    public Boolean isAge()
    {
        if ( age >55 )
            return true;
        else return false;

    }


}
*/


class Book
{
    int ID;
    string Name;
    string type;
    DateTime CreateDate;
    bool IsDeleted;
    int price;
    static int count =0;
    private Book(int price,string name ) 
    {
        this.price = price;
        this.Name = name;
        count++;
    }
    public Book()
    { 
        Console.WriteLine("default constructor ");
        count++;
    }
    public Book(int id , string name,string type ,bool isdeleted ,int price)
    {
        this.ID = id;
        this.Name = name;
        this.type = type;
        this.IsDeleted = isdeleted;
        this.price = price;
        count++;

    }
    public Book(Book book)
    {
        this.ID = book.ID;
        this.Name = book.Name;
         this.type = book.type;
        this.IsDeleted = book.IsDeleted;
        this.price = book.price;
        count++;
    }


    public void CountbookSell() { Console.WriteLine( count); }
    public void IsBookDeleted()
    {
        Console.WriteLine( IsDeleted ? "deleted" : "not deleted");
    }
    public void GetBookName()
    {
        Console.WriteLine($"{Name} , {ID} , {price} , {type} , {CreateDate} , {IsDeleted}");
    }



}
public class HelloWorld
{
    public static void Main(string[] args)
    {
           

            Book book1 = new Book();
            Book book2 = new Book(2154,"fire","exit", true ,125);
            Book book3 = new Book(1254, "fuuny","fuuny" , false , 156);
            book2.GetBookName();
            Console.WriteLine();
            book3.IsBookDeleted();
            Console.WriteLine();
            book3.CountbookSell();








        
        
        /*
            Console.WriteLine("hello");
            student s1 =new student(2154,25,"shreen");
            student s2 =new student(4987,34,"yara");
            Console.Write("write your id :");
            int ssn =int .Parse(Console.ReadLine());
            Console.Write("write your age :");
            int age =int .Parse(Console.ReadLine());
            Console.Write("write your name :");
            string name =Console.ReadLine();
            s1.setData(ssn ,age,name);
            s1.getData();
        if (s1.isAge())
        {
            Console.WriteLine("you are Pensioner");
        }
        else
            Console.WriteLine("you are still work");

       
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