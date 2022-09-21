using System;
//System.Console.InputEncoding = Encoding.GetEncoding(1251);


namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Bolciano-Koshi: ");
            // Bolciano_Koshi();
            Console.WriteLine("");
            Console.WriteLine("Method Bisekcii:");
            //Bisekcia();
            Console.WriteLine("");
            Console.WriteLine("Method Niutona");
            Niuton();

            Niuton();
            Niuton();
            Console.ReadKey();

        }




        static double Function(double x)
        {
            return x * x * x + 12 * x * x + 44 * x + 48;
        }
        static double DFunction(double x)
        {
            return 3 * x * x + 24 * x + 44;
        }
        static void Bolciano_Koshi()
        {
            Console.WriteLine("print begin of x:");
            string x_one = Console.ReadLine();
            Console.WriteLine("print end of x");
            string x_two = Console.ReadLine();
            double x1 = Convert.ToDouble(x_one);
            double x2 = Convert.ToDouble(x_two);
            double medium = 0, esp = 0.0001;
            double dx, half;
            int i = 0;
            Console.WriteLine(" The equation is:x * x * x + 12 * x * x + 44 * x + 48 = 0;\n\n So: f(x) x * x * x + 12 * x * x + 44 * x + 48 = 0;\n\n For the solution we use the consequence of the Bolzano-Cauchy theorem.\n\n Choose x1 = {0} i x2 = {1}, because f(x1) = {2} i f(x2) = {3}.\n\n Number of iteration:\t\t Coordinate of center:", x1, x2, Function(x1), Function(x2));
            while (x2 - x1 > esp)
            {
                dx = x2 - x1;
                half = dx / 2;
                medium = x1 + (half / 2);
                if (Math.Sign(Function(x1)) != Math.Sign(Function(medium)))
                {
                    x2 = medium;
                }
                else
                {
                    x1 = medium;
                }
                Console.WriteLine("      {0, 2:F0}     \t\t\t{1}", ++i, medium);
            }
            //Console.WriteLine("{0}\t{1}\t{2}", medium, Function(medium)+medium);
            Console.WriteLine("\n the root of the equation, x = {0}, cause x * x * x + 12 * x * x + 44 * x + 48  = {1}.\n\n Fault: {2}\n\n", medium, Function(medium) + medium, Function(medium));
            Console.ReadKey();
        }

        static void Bisekcia()
        {
            Console.WriteLine("print begin of x:");
            string x_one = Console.ReadLine();
            Console.WriteLine("print end of x");
            string x_two = Console.ReadLine();
            double x_begin = Convert.ToDouble(x_one);
            double x_end = Convert.ToDouble(x_two);
            double middle_x = (x_begin + x_end) / 2;
            double eps = 0.0001;

            if (Function(x_begin) == 0)
            {
                //return x_begin;
                Console.WriteLine("{0} - root of the equation", x_begin);
            }

            if (Function(x_end) == 0)
            {
                //return x_end;
                Console.WriteLine("{0} - root of the equation", x_end);
            }

            while ((x_end - x_begin) > eps)
            {
                double dx = (x_end - x_begin) / 2;
                middle_x = x_begin + dx;
                if (Math.Sign(Function(x_begin)) != Math.Sign(Function(x_end)))
                {
                    x_begin = middle_x;
                }

            }

            //return middle_x;
            Console.WriteLine("Find the root of the equation - {0} with an accuracy of y - {1}", middle_x, eps);
        }

        static void Niuton()
        {
            double eps = 0.0001;
            int iteration = 0;
            Console.WriteLine("Print definition close to x: ");
            string x_text = Console.ReadLine();
            double x = Convert.ToDouble(x_text);
            while (Math.Abs(Function(x)) > eps)
            {
                iteration += 1;
                double x_prev = x;
                x = x - Function(x) / DFunction(x);
                double delta = x - x_prev;
                Console.WriteLine("k{0} | x = {1} | Delta {2} = {3}", iteration, x, iteration, delta);
            }

            Console.WriteLine("number of iterations = {0}", iteration);

        }

    }
}

