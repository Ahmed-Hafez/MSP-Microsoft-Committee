using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Console_Methods
{
    class Program
    {
        static void Main()
        {
            #region Strings
            string s1 = new string('*', 20);
            Console.WriteLine("s1 = " + s1);

            char[] charArr = { 'a', 'b', 'c', 'd' };
            string s2 = new string(charArr);
            Console.WriteLine("s2 = " + s2);

            string s3 = new string(charArr, 1, 2);
            Console.WriteLine("s3 = " + s3);
            Console.WriteLine();
            //=====================================
            // Some important string functions
            string s4 = "My team is MSP";
            Console.WriteLine("s4 = " + s4);
            Console.WriteLine("s4.Length = " + s4.Length);
            Console.WriteLine("s4.Count() = " + s4.Count());
            Console.WriteLine(@"s4.Contains(""MSP"") = " + s4.Contains("MSP"));
            Console.WriteLine("s4.ElementAt(5) = " + s4.ElementAt(5));
            Console.WriteLine("s4.IndexOf('m') = " + s4.IndexOf('m'));
            Console.WriteLine("s4.Remove(6) = " + s4.Remove(7));
            Console.WriteLine(@"s4.Replace(""team"", ""Community"") = " + s4.Replace("team", "Community"));
            Console.WriteLine("s4.Substring(11) = " + s4.Substring(11));
            Console.WriteLine("s4.Substring(3, 4) = " + s4.Substring(3, 4));
            Console.WriteLine("s4.ToUpper() = " + s4.ToUpper());
            Console.WriteLine("s4.ToLower() = " + s4.ToLower());
            Console.WriteLine();
            //=====================================
            // Formating
            Console.WriteLine(@"when putting (@) there is no special characters like \n\r\a\f\\");// notice the sign (@)
            Console.WriteLine();

            Console.WriteLine("{0} is the Committee Head, {1} is HR,\n{0} is 20 years old, {1} also," +
                "\n{0} and {1} are in the same team.\n", "Ahmed", "Shimaa");

            Console.WriteLine("Enter two numbers to get the sum of them");
            Console.Write("first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("second number : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {x} + {y} = {x + y}\n"); // notice the sign ($)

            Console.Write("\nEnter square length : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("*".PadLeft(n, '*'));
            for (int i = 0; i < n / 2 - 2; i++) Console.WriteLine("*".PadRight(n - 1) + "*");
            Console.WriteLine("*".PadLeft(n, '*'));
            Console.WriteLine("=============================\n");
            #endregion

            #region Console
            Console.WriteLine("If you want to go in console part press Enter");
            if (Console.ReadKey(true).Key != ConsoleKey.Enter) return;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.CursorLeft = 10;
            Console.WriteLine("Is CapsLock key on? : " + Console.CapsLock);
            Console.Title = "MSP Program"; // the title of the console in the title bar is now changed
            Console.WriteLine($"Console.LargestWindowHeight = {Console.LargestWindowHeight}\n" +
                $"Console.LargestWindowWidth = {Console.LargestWindowWidth}\n" +
                $"Console.WindowHeight = {Console.WindowHeight}\n" +
                $"Console.WindowWidth = {Console.WindowWidth}");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("Console.SetCursorPosition(15, 10)");
            Console.WriteLine("If you want to go in console.ReadKey part press Enter");
            if (Console.ReadKey(true).Key != ConsoleKey.Enter) return;
            Console.ResetColor();
            Console.Clear();

            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey(true);
                Console.Write(" --- You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape);
            #endregion

            #region using our Methods
            Console.WriteLine("If you want to go in Methods part press Enter");
            if (Console.ReadKey(true).Key != ConsoleKey.Enter) return;
            Console.Clear(); // To clear the console

            printNumber(15.6);
            Console.WriteLine("sum(14.6m, 15.4m) = {0}", sum(14.6m, 15.4m)); // note the suffix "m" next to both numbers

            // Passing
            int num1 = 5;
            int num2 = 5;
            int num3;
            Console.WriteLine("<<<<<< Before Calling \"pass\" function >>>>>>");
            Console.WriteLine($"x = {num1}, y = {num2}, z = null");
            pass(num1, ref num2, out num3);
            Console.WriteLine("<<<<<< After Calling \"pass\" function >>>>>>");
            Console.WriteLine($"x = {num1}, y = {num2}, z = {num3}");
            #endregion
        }
        #region Methods
        // common way 
        /*
         * Access_modifier Return_type Function_name(parameters)
         * {
         *      // your functionilty goes here
         * }
         * 
         * Note : you should use "static" modifier to call your Method 
         *        the "Main" Method, we will discuss this modifier later.
         */
        static void printNumber(double number)
        {
            Console.WriteLine($"Your number is : {number}");
        }


        // Expression Body Definition
        static decimal sum(decimal x, decimal y) => x + y;


        // pass by reference using "ref"
        // pass by outing using "out"
        // if you don't put "ref" or "out" then you use pass by value
        static void pass(int x, ref int y, out int z)
        {
            x = 10;
            y = 10;
            z = 10;
            Console.WriteLine("<<<<<< From \"pass\" function >>>>>>");
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
        #endregion
    }
}
