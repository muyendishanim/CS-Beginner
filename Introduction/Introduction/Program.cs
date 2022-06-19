using System;


class Deneme
{

    static void Main(string[] args)
    {
        
        Console.WriteLine("- INTRODUCTION -");

        //Hello World!
        Console.WriteLine("Hello World!");

        Console.WriteLine("What is your name?");

        //Getting input from the user

        string name = Console.ReadLine();

        Console.WriteLine("Nice to meet you " + name + "!");


        Console.WriteLine("----------------------------------------------------------------------------------------");


        


       
        Console.WriteLine("- Data Types -");

        // int variable  
        int i = 34;
        Console.WriteLine("My number: " + i);

        // increasing i value
        i = i + 1;
        i += 1;

        Console.WriteLine("Num after addition: " + i);

        // Use i in an operation   
        int counter = i + 1;

        Console.WriteLine("Counter: " +counter);

        // char variable  
        char c = 'm';

        // float variable 32 bit
        float f = 6.8f;

        // double variable 64 bit
        double d = 5.7d;

        // string variable  
        string ex = "example";

        // casting operation -> cast double to int in this example
        double sayi = 3.56d;
        int cas = (int) sayi;
        float cas1 = (float) sayi;

        Console.WriteLine("Casting number: " + cas);
        Console.WriteLine("Value of d remains same: " + d);

        // boolean variable
        bool bt = true;
        bool bf = false;

        // object variable  
        object o = c;
        Console.WriteLine("Object: " + o);

        // This is Boxing as we are converting a 'value type' value into 'object type'   
        object o1 = "example";
        Console.WriteLine("Boxing: " +o1);

        // This is Unboxing as we are converting a 'object type' value into 'value type'   
        string text = (string)o1;
        Console.WriteLine("Unboxing: " +text);

        Console.WriteLine("----------------------------------------------------------------------------------------");

       
        
        
        
        
        
        

        Console.WriteLine("- Mathematical Operations -");

        // Summation
        int a = 15;
        int b = 3;
        int sum = a + b;

        Console.WriteLine("a = {0}, b = {1}, summation = {2}", a, b, sum);

        // Subtraction
        int sub = a - b;

        Console.WriteLine("a = {0}, b = {1}, subtraction = {2}", a, b, sub);

        // Multiplication
        int mult = a * b;

        Console.WriteLine("a = {0}, b = {1}, multiplication = {2}", a, b, mult);

        // Division
        int div = a / b;

        Console.WriteLine("a = {0}, b = {1}, division = {2}", a, b, div);

        // Remaining -> Bolme isleminden kalani getirir
        int rem = a % 4;

        Console.WriteLine("a = {0}, b = {1}, remaining = {2}", a, b, rem);


        Console.WriteLine("----------------------------------------------------------------------------------------");

        

        

        Console.WriteLine("- IF Statement -");

        int x = 5;
        int y = 10;

        // 1 condition and 1 operation inside of the if
        if (x == 5)
            Console.WriteLine("Correct!");
        else
            Console.WriteLine("Wrong!");

        if (y == 10)
            Console.WriteLine("y 10'dur!");


        // 1 condition but more than 1 operation inside of the if
        // 1. kosul
        if (y < 10)
        {
            x = x + y;
            Console.WriteLine("New value of x: " + x);
        }
        // 2. kosul
        else if(y > 10)
        {
            x = y - x;
            Console.WriteLine("New value of x: " + x);
        }
        // 3. kosul
        else if (y != 15)
        {
            Console.WriteLine("Value of x: " + x);
        }
        // 3 kosuldan herhangi birisini saglamiyorsa
        else
        {
            x = x * y;
            Console.WriteLine("New value of x: " + x);
        }




        // 2 condition and 1 operation inside of the if
        // && and sembolu
        // || or sembolu

        bool deneme = false;

        // X 50 ve Y 10 ise
        if (x == 50 && y == 10)
        {
            deneme = true;
            Console.WriteLine("That's it!");
        }
        // X 5 ile 10 arasinda ise
        else if(x > 5 && x < 10)
            Console.WriteLine("x is between 5 and 10");
        // Y 10dan kucuk veya buyukse
        else if(y < 10 || y > 10)
            Console.WriteLine("y is smaller than 10 or bigger than 10");
        // Y 5ten kucuk ve X 10dan buyukse
        else if(y<5 && x>10)
            Console.WriteLine("y is smaller than 5");




        // If with boolean variable
        bool bo = true;

        if (bo)
        {
            Console.WriteLine("Boolean is true!");
        }

        if (!bo)
        {
            Console.WriteLine("Boolean is false!");
        }


        //Examples for exercises
        int x1 = 5;
        int y1 = 3;

        // Sayinin herhangi bir kati
        double pow = Math.Pow(x, 4);
        int pow1 = (int)pow;

        int funcg = -x1 * x1 + 5;
        Console.WriteLine("f({0},{1}) = {2}",x1,y1,funcg);

        const double pi = 3.14d;

        const int con = 5;


        double r = 15.456;
        int final = (int)Math.Round(r);

        double r1 = 15.756;
        int final1 = (int)Math.Round(r1);

        Console.WriteLine("Yuvarlama 1: " + final);

        Console.WriteLine("Yuvarlama 2: " + final1);

    }
}
