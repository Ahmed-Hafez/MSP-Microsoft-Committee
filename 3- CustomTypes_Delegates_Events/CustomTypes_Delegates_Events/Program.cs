using System;

namespace CustomTypes_Delegates_Events
{
    // Difference between class and struct
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my1 = new MyClass();
            my1.x = 10;
            my1.y = 20;
            Console.WriteLine("Before (class) : my1.x = {0}, my1.y = {1}", my1.x, my1.y);
            myStruct my2 = new myStruct();
            my2.x = 30;
            my2.y = 40;
            Console.WriteLine("Before (struct) : my2.x = {0}, my2.y = {1}", my2.x, my2.y);
            convert(my1, my2);
            Console.WriteLine("After (class) : my1.x = {0}, my1.y = {1}", my1.x, my1.y);
            Console.WriteLine("After (struct) : my2.x = {0}, my2.y = {1}", my2.x, my2.y);

        }
        static void convert(MyClass my1, myStruct my2)
        {
            my1.x = 5;
            my1.y = 5;
            Console.WriteLine("In (class) : my1.x = {0}, my1.y = {1}", my1.x, my1.y);
            my2.x = 8;
            my2.y = 8;
            Console.WriteLine("In (struct) : my2.x = {0}, my2.y = {1}", my2.x, my2.y);
        }
    }
    class MyClass
    {
        public int x, y;
    }
    struct myStruct
    {
        public int x, y;
    }



    // Session Example on delegates and events
    class Program
    {
        public delegate void mydel();
        public static event mydel myEvent;
        static void Main()
        {
            int[] arr = { 3, 4, 5, 6, 7 };
            mydel mydel1 = new mydel(Print);
            myEvent += mydel1;
            Console.Write("Enter index you want to access : ");
            int indx = int.Parse(Console.ReadLine());
            if (indx >= arr.Length || indx < 0) myEvent();
            else Console.WriteLine($"arr[{indx}] = {arr[indx]}");
            myEvent -= mydel1;
            Main();
        }
        static void Print()
        {
            Console.WriteLine("Index out of range");
        }
    }



    // Session task
    class company
    {
        public delegate void del();      // Intialize a new delegate type
        public event del orderHandler;   // Intialize a new Event Handler
        del orderDel;                    // object from (del) type "The delegate type"
        int no_pencils;                  // total number of pencils
        public company(int no_pencils)
        {
            this.no_pencils = no_pencils;
            orderDel = new del(print);
            orderHandler += orderDel;

        }
        public void order(int requiredPencils)
        {
            if (no_pencils - requiredPencils < 0) orderHandler();
            else
            {
                no_pencils -= requiredPencils;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ok, got it.");
                Console.ResetColor();
            }

        }
        public void print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(); // make alert
            Console.WriteLine("This quantity is not available!");
            Console.ResetColor();
        }
    }
    class Program
    {

        static void Main()
        {
            Console.Write("Enter the number of pencils in the company : ");
            int x = int.Parse(Console.ReadLine());
            company c = new company(x);
            while (true) // you can make the condition broken when number of pencils in the company become 0
            {
                Console.Write("Enter the required number of pencils : ");
                int y = int.Parse(Console.ReadLine());
                c.order(y);
            }
        }

    }
}
