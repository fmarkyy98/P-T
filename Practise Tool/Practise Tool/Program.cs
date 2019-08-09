using System;

namespace Practise_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, Solution = 0;
            char operation;
            Console.WriteLine("Write down the two number splitted with ';' character!");
            string input = Console.ReadLine();
            bool failure = false;
            do
            {
                if (failure)
                {
                    Console.WriteLine("Incorrect sintax, write again the input!");
                    input = Console.ReadLine();
                }
                string[] split = input.Split(';');
                if (double.TryParse(split[0], out x) && double.TryParse(split[1], out y)) failure = false;
                else failure = true;
            } while (failure);
            Console.WriteLine("write down the operator!");
            input = Console.ReadLine();
            failure = false;
            do
            {
                if (failure)
                {
                    Console.WriteLine("Incorrect sintax, write again the input!");
                    input = Console.ReadLine();
                }
                if (!char.TryParse(input, out operation)) { failure = true; break; }
                switch (operation)
                {
                    case '+':
                        Solution = x + y;
                        failure = false;
                        break;
                    case '-':
                        Solution = x - y;
                        failure = false;
                        break;
                    case '*':
                        Solution = x * y;
                        failure = false;
                        break;
                    case '/':
                        try { Solution = x / y; }
                        catch (DivideByZeroException) { Console.WriteLine("Nullával való osztás nem értelmezhető."); return; }
                        failure = false;
                        break;
                    default:
                        failure = true;
                        break;
                }
            } while (failure);
            Console.WriteLine($"{x} {operation} {y} = {Solution.ToString("0.##")}");
            Console.ReadKey();
        }
    }
}
