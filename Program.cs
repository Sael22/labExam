using System.Diagnostics;
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
                Console.Out.WriteLine("------------Fifth-------------");
        Console.WriteLine("Enter a number between 1-12");
        int num = int.Parse(Console.ReadLine());
        switch(num){
            case 1:
            Console.WriteLine("Jan");
            break;

            case 2:
            Console.WriteLine("Feb");
            break;

            case 3:
            Console.WriteLine("Mar");
            break;

            case 4:
            Console.WriteLine("Apr");
            break;

            case 5:
            Console.WriteLine("May");
            break;

            case 6:
            Console.WriteLine("Jun");
            break;

            case 7:
            Console.WriteLine("Jul");
            break;

            case 8:
            Console.WriteLine("Aug");
            break;

            case 9:
            Console.WriteLine("Sep");
            break;

            case 10:
            Console.WriteLine("Oct");
            break;

            case 11:
            Console.WriteLine("Nov");
            break;

            case 12:
            Console.WriteLine("Dec");
            break;
            default:
            Console.WriteLine("Not a month");
            break;

        }

        Console.Out.WriteLine("------------Sixith-------------");
        Book B1 = new Book("Statistics","Ahmed",22);
                Book B2 = new Book("Scince","Mohammed",18.50);

        Book B3 = new Book("Biology","Muna",42);
        Book [] dd = [B1,B2,B3];

        for(int i = 0;i <3;i++){
            B1.printDetails(dd[i]);
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

    public class Book{
        String title;
        String author;
        double price;
        public Book(String Title,String Author,double price){
            this.author = Author;
            this.title = Title;
            this.price = price;
        }
        public void setTitle(String title){
           this.title = title;
        }
        public void setAuthor(String author){
            this.author = author;
        }
        public void setPrice(double price){
            this.price = price;
        }
        public String getTitle(){
            return title;
        }
        public String getAuthor(){
            return author;
        }
        public double getPrice(){
            return price;
        }
        public void printDetails(Book book){
            Console.WriteLine("Title: "+book.getTitle()+" Author:"+book.getAuthor()+" Price:"+book.getPrice());
        }

    }

}
