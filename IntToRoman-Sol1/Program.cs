using System;
using System.Collections.Generic;

namespace IntToRoman_Sol1
{
   sealed class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            while (true)
            {
                Console.WriteLine("Enter a positive integer between 1 to 3999:");

                if (Int32.TryParse(Console.ReadLine(), out inputNumber) && (inputNumber > 0 && inputNumber <= 3999))
                {
                    var context = new Context(inputNumber);
                    List<IExpression> expression = new List<IExpression>();
                    expression.Add(new ThousandRomanExpression());
                    expression.Add(new HundredsRomanExpression());
                    expression.Add(new TensRomanExpression());
                    expression.Add(new OnesRomanExpression());

                    foreach (IExpression exp in expression)
                    {
                        exp.Interpret(context);
                    }
                    Console.WriteLine(context.Output.ToString());
                    Console.ReadLine();
                }

                else
                    Console.WriteLine("Input number should be between 1 to 3999");
            }
        }





    }
}
