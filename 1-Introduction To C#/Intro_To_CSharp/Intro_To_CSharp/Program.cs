using System;

namespace Intro_To_CSharp
{
    class Program
    {
        static void Main()
        {
            /*
             * Numeric suffixes explicitly define the type of a variable
             * Suffixes can be either lower or uppercase
             * 
             * Note : you can remove the numeric suffix for all types except "float"
             * Note : the default numeric type is "int" so it hasn't any numeric suffix
             */
            int i = 5;
            float f = 5.09f;   // (f) is a numeric suffix
            decimal m = 4343m; // (m) is a numeric suffix
            double d = 328.43d;// (d) is a numeric suffix
            uint u = 1U;       // (u) is a numeric suffix
            long l = 1L;       // (l) is a numeric suffix
            ulong ul = 1UL;    // (ul) is a numeric suffix
            // ============================================================

            // Some special values
            Console.WriteLine(double.NaN); // Not a Number 
            Console.WriteLine(double.NegativeInfinity); // -∞
            Console.WriteLine(double.PositiveInfinity); // ∞
            // ============================================================

            // using Console.Read() Method
            // int i;
            while ((i = Console.Read()) != -1) // because all unicode characters are positive values
                                               // you replace (-1) by any negative value
            {
                Console.WriteLine("{0}={1}", i, (char)i);
            }
            // after any input you will notice that (13 and 10) was printed on console
            // 13 means the Key (Enter Was pressed) and its character is '\r'
            Console.WriteLine((int)'\r'); // to reach this code comment the while-loop
            // 10 means new line was printed and its character is '\n'
            Console.WriteLine((int)'\n'); // to reach this code comment the while-loop
            // ========================================================================================

            // goto statement
            AreaName:
            Console.WriteLine("This Area for (goto statement)");
            goto AreaName;
            // ===================================================

            // to reach this code comment also (goto statement)
            // Arrays
            // Single-dim Array
            int[] arr1 = new int[3];
            int[] arr2 = new int[3] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };
            // Multi-dim Array
            int[,] arr4 = new int[2, 2];
            int[,] arr5 = new int[2, 2] { { 0, 1 }, { 1, 0 } };
            int[,] arr6 = { { 0, 1 }, { 1, 0 } };
            // jagged(ragged) Array
            int[][] arr7 = new int[2][];
            arr7[0] = new int[3];
            arr7[1] = new int[4];

            int[][] arr8 = new int[2][]
            {
                new int[3],
                new int[4]
            };

            /*
             * int[][] arr9 = new int[][3]; // wrong syntax
             * if you want to know why this is wrong syntax 
             * read this article : 
             * https://blogs.msdn.microsoft.com/ericlippert/2009/08/17/arrays-of-arrays/
             */
            //=============================================================================

            // The use of (Console.ReadKey)
            // Note : we will discuss this code in the next session

            while (Console.ReadKey(true).Key != ConsoleKey.Escape) continue;


            while (Console.ReadKey().Key == ConsoleKey.Enter) Console.Write("\a\r");


            ConsoleKeyInfo cki;
            // Prevent example from ending if CTRL+C is pressed.
            Console.TreatControlCAsInput = true;
            
            Console.WriteLine("Press any combination of CTRL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey(true);
                Console.Write("You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTRL+");
                Console.WriteLine("{0} (character '{1}')", cki.Key, cki.KeyChar);
            } while (cki.Key != ConsoleKey.Escape);


        }
    }
}
