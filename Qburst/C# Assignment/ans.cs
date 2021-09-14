1.Will the following code compile?

double d = 9999.11;
int i = d;

Ans:

Will not compile as it is an explicit uncompatible type conversion. (int)d will work.

2.For the following C# code what is the relevant solution for conversion of data type.

static void Main(string[] args)
{
int num1 = 20000;
int num2 = 50000;
long total;
total = num1 + num2;
Console.WriteLine($"Total is : {total}");
Console.ReadLine();
}

Ans. One method is to initialize total as : var total =0

3.For the given set of C# code, is conversion possible?

static void Main(string[] args)
{
int a = 76;
char b;
b = (char)a;
Console.WriteLine(b);
Console.ReadLine();
}

Ans:Yes, 76 gets converted into ASCII code and a character having that number gets printed.

4.What will be the output of the following C# code?

static void Main(string[] args)
{
float sum;
int i;
sum = 0.0F;
for (i = 1; i <= 10; i++)
{
sum = sum + 1 /(float)i;
}
Console.WriteLine($"sum = {sum}");
Console.ReadLine();
}

Ans: Sum will be a decimal close to 2.92

5.Refactor the following code (apply explicit conversion) to get an output without any error?

static void Main(string[] args)
{
int a = 22;
long b = 44;
double c = 1.406;
b = a;
c = a;
a = b;
b = c;
}

Ans:
    a = (int)b;
    b = (long)c;
     
6.Write a program to print the current day. Eg: Today is Tuesday.

Ans:
static void Main(string[] args)
        {
            DateTime one = DateTime.Today;
            Console.WriteLine("Today is {0:dddd}",one);
        }

7.Write a C# Sharp program that takes two numbers as input 
and perform an operation (+,-,*,x,/,%) on them using switch statement
and displays the result of that operation.

Ans:
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            string op;
            Console.WriteLine("Enter Operator:");
            op = Console.ReadLine();
            switch (op)
            {
                case "+": 
                          Console.WriteLine(a + b);
                          break;
                case "-":
                          Console.WriteLine(a - b);
                          break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;
                default: Console.WriteLine("Invalid Operator");
                        break;
            }
        }

8.Write a program in C# Sharp to read 10 numbers from the keyboard and find their sum and average.
Test Data :
Input the 10 numbers :
Number-1 :2
...
Number-10 :2
Expected Output :
The sum of 10 no is : 51
The Average is : 5.100000

Ans:
static void Main(string[] args)
        {
            int a, sum=0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter Number {i+1}:");
                a = Convert.ToInt32(Console.ReadLine());
                sum += a;
            }
            double avg = sum / 10.0;
            Console.WriteLine($"Sum={sum} Average={avg}");
        }

9.Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output :

666666
66666
6666
666
66
6

Ans:

int l;
Console.WriteLine($"Enter Number:");
l = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= l; i++)
{
    for (int j = i; j <=l ; j++)
    {
        Console.Write(l);
    }
    Console.Write("\n");
}

10.Write a program in C# Sharp to sort a string array in ascending order. Go to the editor
Test Data :
Input the string : this is a string
Expected Output :

After sorting the string appears like :
a g h i i i n r s s s t t

Ans:

static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            Console.WriteLine(chars);

        }

11.Find how many prime numbers lying between the given range using loops and conditional statements

Ans:

static void Main(string[] args)
        {
            int a, b,j,c;
            Console.WriteLine("Enter Limits:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                c = 0;
                for (j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine($"{i} is a Prime Number");
                }
                else
                {
                    Console.WriteLine($"{i} is not a Prime Number");
                }
            }
        }

12.Write a function to parse the DateTime string 
and returns true if it is successfully parsed else return false using TryParse method

Ans:
		static void Main(string[] args)
        {
            Console.WriteLine("Enter a date:");
            bool ret = doesParse(Console.ReadLine());
            Console.WriteLine(ret);
        }

        public static bool doesParse(string date)
        {
            DateTime dt;
            bool b = DateTime.TryParse(date, out dt);
            return b;
        }

13.What will be the correct order of execution of function func1(), func2() & func3() in the given code snippet?
class baseclass
{
public void func1() {}
public virtual void func2() {}
public virtual void func3() {}
}
class derivedclass :baseclass
{
new public void func1() {}
public override void func2() {}
public new void func3() {}
}
class Program
{
static void Main(string[] args)
{
baseclass b = new derivedclass();
b.func1 ();
b.func2 ();
b.func3 ();
}
}
Ans:
func1() of baseclass , func2() of derivedclass , func3() of baseclass.

14.What will be the output of the following code snippet?

class BaseClass
{
public virtual void Print()
{
System.Console.WriteLine("BaseClass");
}
}

class DerivedClass : BaseClass
{
public override void Print()
{
System.Console.WriteLine("DerivedClass");
}
}

class Derived2Class : BaseClass
{
public void Print()
{
System.Console.WriteLine("Derived2Class");
}
}

class Program
{
public static void Main()
{
BaseClass b;
b = new DerivedClass();
b.Print();

BaseClass c= new Derived2Class();
c.Print();
}
}

Ans:

DerivedClass
BaseClass

15.If we call the below statements in main (), what is the wings’ colour of Parrot? Give reason.
Bird b = new Parrot();
b.wings();

In case of unknown colour, complete the source code of classes to get correct colour of Parrot’s wings.

class Bird
{
public void legs() { Console.WriteLine("legs: 2"); }
public void wings() { Console.WriteLine("colour: unknown"); }
}
class Parrot : Bird
{
public void wings() { Console.WriteLine("colour: Green"); }
}

Ans:
Color will be Unknown as override is not used.

16.What is output of the following program? When we create 2 objects of the class A e.g.
A obj1 = new A();
A obj2 = new A();

class A
{
static A()//Static constructor
{
Console.WriteLine("Static Constructor");
}

public A()// Constructor
{
Console.WriteLine("Class Constructor");
}
}

Ans:
Static Constructor
Class Constructor
Class Constructor 

17.Write a program in C# Sharp to create a nested struct (Student and DateOfBirth)
and store two records of students in an array.

Ans:

		struct Student
        {
            public string Name;
            public DateOfBirth Date;
        }
        struct DateOfBirth
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            int dd, mm, yy;
            Student[] s = new Student[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Name:");
                s[i].Name = Console.ReadLine();
                Console.WriteLine("Enter DOB:");

                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                s[i].Date.Day = dd;

                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                s[i].Date.Month = mm;

                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                s[i].Date.Year = yy;
            }
        }

18.Write complete program for below scenario in C#.

Create a class Travel Insurance using below Interface and call GetInsurance() method in main() program.

interface Insurance
{
void GetInsurance();
}

Ans:
    interface Insurance
    {
        void GetInsurance();
    }
    class TravelInsurance : Insurance
    {
        public void GetInsurance()
        {
            Console.WriteLine("Got Insurance");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Insurance i = new TravelInsurance();
            i.GetInsurance();

        }
    }

19.What type of implementation is shown below:

interface IFlyable
{
void fly();
}
interface IEatable
{
void eat();
}

class Bird : IFlyable, IEatable
{
public void fly()
{
Console.WriteLine("Bird flying");
}
public void eat()
{
Console.WriteLine("Bird eats");
}
}

class Program
{
static void Main(string[] args)
{
Bird b = new Bird();
b.eat();
b.fly();
}
}

Ans:
Multiple Inheritance

20.How to implement two interface with same method in C#?
Eg:
interface ILoanCustomer
{
void GetCostomerInfo();
}
interface IBankCustomer
{
void GetCostomerInfo();
}

Implement the above interfaces in a class

Ans:

    interface ILoanCustomer
    {
        void GetCostomerInfo();
    }
    interface IBankCustomer
    {
        void GetCostomerInfo();
    }
    class CustomerInfo : ILoanCustomer , IBankCustomer
    {
        void ILoanCustomer.GetCostomerInfo()
        {
            Console.WriteLine("Got Loan Customer Info");
        }

        void IBankCustomer.GetCostomerInfo()
        {
            Console.WriteLine("Got Bank Customer Info");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILoanCustomer c1 = new CustomerInfo();
            c1.GetCostomerInfo();

            IBankCustomer c2 = new CustomerInfo();
            c2.GetCostomerInfo();
        }
    }

23.What is the Use of Digital Separator

Ans:
Inorder to mimic commas in number system.

24.What is the Output of the following code snippet 
{long x = 100000022200000202;
long z = 10000000020;

Console.WriteLine("X: {0}", x);
Console.WriteLine("Z: {0}", z);

// Using digit separators
long num1 = 1_00_10_00_00_00;
var num2 = 0b_010_000_000_000_000_000_000_000_000;
long num3 = 1_00_00_00_00_00_00;
var num4 = 0b_1_1000_0000_1000_0000_0011_0000_0000_1000_0001;

Console.WriteLine("Num1: {0}", num1);
Console.WriteLine("Num2: {0}", num2);
Console.WriteLine("Num3: {0}", num3);
Console.WriteLine("Num4: {0}", num4);

Ans:
X: 100000022200000202
Z: 10000000020
Num1: 10010000000
Num2: 33554432
Num3: 1000000000000
Num4: 103213629569

25.What is the Output 
Console.WriteLine(default(Int32));
Console.WriteLine(default(Boolean));
Console.WriteLine(default(String));

Ans:
0
False

26.
Write a generic class with a function to swap any 2 variables of same datatype( eg. integer, string).

Ans:

    public class GenericList<T>
    {
        public void Swap(int a , int b) {
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("Swapped");
        }
    }
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Swap(1,7);

        }
    }

27.What is the output 
var My_Tuple = Tuple.Create(13, "Geeks", 67, 89.90,
'g', 39939, "geek", Tuple.Create(12, 30, 40, 50));

// Accessing the element of Tuple
// Using Item property
// And accessing the elements of nested tuple
// Using Rest property
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item1);
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item2);
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item3);
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item4);
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item5);
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item6);
Console.WriteLine("Element of My_Tuple: "+My_Tuple.Item7);
Console.WriteLine("Element of Nested tuple: "+My_Tuple.Rest);
Console.WriteLine("Element of Nested tuple: "+My_Tuple.Rest.Item1.Item1);
Console.WriteLine("Element of Nested tuple: "+My_Tuple.Rest.Item1.Item2);
Console.WriteLine("Element of Nested tuple: "+My_Tuple.Rest.Item1.Item3);
Console.WriteLine("Element of Nested tuple: "+My_Tuple.Rest.Item1.Item4);

Ans:
Element of My_Tuple: 13
Element of My_Tuple: Geeks
Element of My_Tuple: 67
Element of My_Tuple: 89.9
Element of My_Tuple: g
Element of My_Tuple: 39939
Element of My_Tuple: geek
Element of Nested tuple: ((12, 30, 40, 50))
Element of Nested tuple: 12
Element of Nested tuple: 30
Element of Nested tuple: 40
Element of Nested tuple: 50

28.What is the Output

 Queue myQueue = new Queue();

// Inserting the elements into the Queue
myQueue.Enqueue("C#");
myQueue.Enqueue("PHP");
myQueue.Enqueue("Perl");
myQueue.Enqueue("Java");
myQueue.Enqueue("C");

// Displaying the count of elements
// contained in the Queue
Console.Write("Total number of elements present in the Queue are: ");

Console.WriteLine(myQueue.Count);

// Displaying the beginning element of Queue
Console.WriteLine("Beginning Item is: " + myQueue.Peek());

Ans:

Total number of elements present in the Queue are: 5
Beginning Item is: C#

29.Write an extension method to read the DOB
and check whether the current month is your birthday month otherwise show how many months left for your birthday

Ans:

	class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            DateTime.TryParse(Console.ReadLine(), out date);
            int t = date.Birth_Month();
            if (t != 0)
                Console.WriteLine($"There are {t} months till birthday");
            else
                Console.WriteLine("This is your birthday month!");
        }
    }

    static class MyExt
    {
        public static int Birth_Month(this DateTime dt)
        {
            DateTime td = DateTime.Today;
            int val = dt.Month - td.Month;
            if (val >= 0)
            {
                return val;
            }
            else
            {
                return 12 + val;
            }
        }
    }


30.Write a function to do the following:

1. should accepts an Action delegate (to pass a function) and count (number of execution of that function)
2. write code to execute the passed function to 'count' times and find the average execution time using Stopwatch

Ans:

class _30
    {
        static void ConsolePrint(int n,Action act)
        {
            Stopwatch stopWatch = new Stopwatch();
            double count=0;
            for (int i = 0; i < n; i++)
            {
                stopWatch.Start();
                act();
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                count = count + ts.Milliseconds;
                Console.WriteLine("Loop Time :"+ ts.Milliseconds);
                stopWatch.Reset();
            }
            Console.WriteLine(count/n);
        }

        static public void test()
        {
            var list = Enumerable.Range(1, 100000).ToList();
        }

        static void Main(string[] args)
        {
            Action<int,Action> printActionDel = ConsolePrint;
            printActionDel(10,test);
        }
    }


31.Write a program in C# Sharp to find the negative numbers from a list of numbers using LINQ Query.

Ans:

using System;
using System.Linq;

class LinqExercise
{
    static void Main()
    {
        int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

        var nQuery =
        (from VrNum in n1
        where VrNum < 0
        select VrNum);

        foreach (var VrNum in nQuery)
        {
            Console.Write(VrNum);
        }
    }
}

32.Write a program in C# Sharp to find the number in the array 
and the square of each number which is more than 30 using LINQ query.

Ans:


using System;
using System.Linq;

class LinqExercise
{
    static void Main()
    {
        int[] n1 = {
                1, 53, -2, -44, -7, -3, -8, 12, 49, 6, 9, 10, 34
            };

        var nQuery =
        (from VrNum in n1
        where VrNum > 30
        select VrNum);

        foreach (var VrNum in nQuery)
        {
            Console.WriteLine(VrNum+" Square: "+VrNum*VrNum);
        }
    }
}

33.Can one process run multiple threads in C#? If yes, provide an example

Ans:

Yes It is possible.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


class LinqExercise
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(new ThreadStart(Messi));
        t1.Start();

        Thread t2 = new Thread(new ThreadStart(Ronaldo));
        t2.Start();
    }

    public static void Messi()
    {
        
        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine(i+1 + " Messi ");
        }
    }

    public static void Ronaldo()
    {
        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine(i+1 + " Ronaldo ");
        }
    }


}

34.What is the output of the following code?

public static void Main()
{
foreach (int num in Numbers())
{
Console.WriteLine(num.ToString());
}
}

static IEnumerable<int> Numbers()
{
yield return 6;
yield return 2 + 4;
yield return 15;
yield return 0;
yield return -9;
yield return 264;
}

Ans:

6
6
15
0
-9
264

35.Write an alternate code with Using statement

string manyLines = @"This is line one
This is line two
Here is line three
The second last line is line four
This is the final, fifth line.";

var reader = new StringReader(manyLines);

try
{
string item;
do
{
item = reader.ReadLine();
Console.WriteLine(item);
} while (item != null);
Console.ReadKey();
}
finally
{
reader?.Dispose();
}

Ans:

class MyClass
{
    public static void Main()
    {
        string manyLines = @"This is line one
This is line two
Here is line three
The second last line is line four
This is the final, fifth line.";

        using (var reader = new StringReader(manyLines))
        {
            string item;
            do
            {
                item = reader.ReadLine();
                Console.WriteLine(item);
            } while (item != null);
            Console.ReadKey();
        }
    }
}


















































































