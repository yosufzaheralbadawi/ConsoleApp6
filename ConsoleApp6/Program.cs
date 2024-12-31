using System.Threading.Channels;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp6,



    //part 1


    //1

    //By Value: A copy of the variable is passed; the original value is not affected.
    //By Reference: A reference to the actual variable is passed; changes affect the original value.

    //class Program
    //{
    //    static void Main()
    //    {
    //        int a = 5, b = 5;
    //        IncreaseByValue(a);    
    //        IncreaseByRef(ref b);  
    //        Console.WriteLine(a);  
    //        Console.WriteLine(b);  
    //    }
    //    static void IncreaseByValue(int x) => x += 10;
    //    static void IncreaseByRef(ref int y) => y += 10;
    //}




    //2

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter a number: ");
    //        string input = Console.ReadLine();  
    //        int sum = 0;


    //        foreach (char digit in input)
    //        {
    //            sum += (digit - '0');
    //        }

    //        Console.WriteLine($"The sum of the digits of the number {input} is: {sum}");
    //    }
    //}


    //3 



    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter a number: ");
    //        int number = int.Parse(Console.ReadLine());

    //        bool result = IsPrime(number);

    //        Console.WriteLine($"{number} is {(result ? "prime" : "not prime")}");
    //    }


    //    static bool IsPrime(int n)
    //    {
    //        if (n < 2)
    //            return false;

    //        for (int i = 2; i <= Math.Sqrt(n); i++)
    //        {
    //            if (n % i == 0)
    //                return false;
    //        }

    //        return true;
    //    }
    //}


    //4


    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] arr = { 5, 2, 9, 1, 7 };
    //        int mn = 0, mx = 0;
    //        MinMaxArray(arr, ref mn, ref mx);
    //        Console.WriteLine($"Min={mn}, Max={mx}");
    //    }

    //    static void MinMaxArray(int[] a, ref int mn, ref int mx)
    //    {
    //        mn = mx = a[0];
    //        for (int i = 1; i < a.Length; i++)
    //        {
    //            if (a[i] < mn) mn = a[i];
    //            if (a[i] > mx) mx = a[i];
    //        }
    //    }
    //}

    //5

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter a number: ");
    //        int n = int.Parse(Console.ReadLine());
    //        Console.WriteLine($"Factorial of {n} = {Factorial(n)}");
    //    }

    //    static int Factorial(int n)
    //    {
    //        int result = 1;
    //        for (int i = 1; i <= n; i++)
    //            result *= i;
    //        return result;
    //    }
    //}

    //6

    //Reference Type Passed by Value:
//We pass a copy of the reference.Modifying the contents of the object will affect the original object, but reassigning the parameter will not.
// Reference Type Passed by Reference (ref):
// We pass the actual reference.Changing both the object’s contents or reassigning the parameter will affect the variable in the calling scope.



//class Person
//{
//    public string Name { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person { Name = "Alice" };

//        ChangeByValue(p);
//        Console.WriteLine($"After ChangeByValue: {p.Name}"); 

//        ChangeByRef(ref p);
//        Console.WriteLine($"After ChangeByRef: {p.Name}");   
//    }

   
//    static void ChangeByValue(Person x)
//    {
//        x.Name = "Bob";
//        x = new Person { Name = "Charlie" };
       
//    }

   
//    static void ChangeByRef(ref Person y)
//    {
//        y = new Person { Name = "David" };
        
//    }
//}


//7

//    class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the first number: ");
//        int a = int.Parse(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        int b = int.Parse(Console.ReadLine());

//        Console.Write("Enter the third number: ");
//        int c = int.Parse(Console.ReadLine());

//        Console.Write("Enter the fourth number: ");
//        int d = int.Parse(Console.ReadLine());

        
//        (int sumResult, int diffResult) = GetSumAndDifference(a, b, c, d);

       
//        Console.WriteLine($"Sum of {a} and {b} = {sumResult}");
//        Console.WriteLine($"Difference of {c} and {d} = {diffResult}");
//    }

    
//    static (int, int) GetSumAndDifference(int x, int y, int z, int w)
//    {
//        int sum = x + y;
//        int difference = z - w;
//        return (sum, difference);
//    }
//}


    //8



//    class Program
//{
//    static void Main()
//    {
//        string word = "Hello";
//        Console.WriteLine($"Original: {word}");

        
//        string modifiedWord = ChangeChar(word, 1, 'a');
//        Console.WriteLine($"Modified: {modifiedWord}");
//    }

//    static string ChangeChar(string input, int position, char newChar)
//    {
        
//        if (position < 0 || position >= input.Length)
//            return input;

        
//        char[] chars = input.ToCharArray();

        
//        chars[position] = newChar;

        
//        return new string(chars);
//    }
//}









    //part 2 




    //1
//    enum WeekDays
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//class Program
//{
//    static void Main()
//    {
        
//        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
//        {
//            Console.WriteLine(day);
//        }
//    }
//}


    //2

//    enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
//        string input = Console.ReadLine();

//        try
//        {
           
//            Season chosenSeason = (Season)Enum.Parse(typeof(Season), input, true);

            
//            switch (chosenSeason)
//            {
//                case Season.Spring:
//                    Console.WriteLine("Spring: March to May");
//                    break;
//                case Season.Summer:
//                    Console.WriteLine("Summer: June to August");
//                    break;
//                case Season.Autumn:
//                    Console.WriteLine("Autumn: September to November");
//                    break;
//                case Season.Winter:
//                    Console.WriteLine("Winter: December to February");
//                    break;
//            }
//        }
//        catch
//        {
//            Console.WriteLine("Invalid season entered. Please try again.");
//        }
//    }
//}


    //5

//    enum Colors
//{
//    Red,
//    Green,
//    Blue
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a color name: ");
//        string input = Console.ReadLine();

//        try
//        {
            
//            Colors chosenColor = (Colors)Enum.Parse(typeof(Colors), input, true);

        
//            Console.WriteLine($"{chosenColor} is a primary color.");
//        }
//        catch
//        {
          
//            Console.WriteLine("That is not a primary color.");
//        }
//    }
//}



