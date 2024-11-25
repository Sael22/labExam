using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(String[] args)
    {

        String name = "Sael";
        int age = 22;
        double fNumber = 21;
        Console.Out.WriteLine("------------FIRST-------------");
        Console.Out.WriteLine("Hey my name is " + name + " I am " + age + " years old and my favorite number is " + fNumber);
        
        
        Console.Out.WriteLine("------------SECOND-------------");
        int [] arr = new int[5];
        Console.Out.WriteLine("Please enter five numbers");
        for (int i = 0; i < 5; i++)
        {
            int cons = int.Parse(Console.ReadLine());
            arr[i] = cons;

        }
        for(int i = 0; i < 5;i++){
            Console.Out.WriteLine("Your Number "+arr[i]);
        }


        Console.Out.WriteLine("------------THIRD-------------");
        IsEven(10);
        IsEven(11);
        
        
        Console.Out.WriteLine("------------FORTH-------------");
        Console.Out.WriteLine("Pleas Enter Your Age");
        int agee = int.Parse(Console.ReadLine());
        if (agee <= 12)
        {
            Console.Out.WriteLine("You are child");

        }
        else if (agee >= 13 && agee <= 17)
        {
            Console.Out.WriteLine("You are teenager");
        }
        else if (agee >= 18)
        {
            Console.Out.WriteLine("You are adult");
        }

    }
    public static void IsEven(int number)
    {
        int rsault = number % 2;
        if (rsault == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");

        }

    }

}
