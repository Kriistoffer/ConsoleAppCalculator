using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double answerPartial = 0;
            double answerFinal = 0;

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("///                Kristoffer Johanssons Calculator Console Application                ///");
            Console.WriteLine("///          Following mathematical operators are allowed: +, -, *, /, and %.          ///");
            Console.WriteLine("///   If you use decimals, separate your number and the decimals with a comma (',').   ///");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();


            /* Användaren kommer att frågas efter två matematiska operationer, följt av vilka tre tal användaren vill använda.
             * De matematiska operationerna sparas i varsin sträng medan talen sparas i varsin double, vilket tillåter decimaltal.
             */

            Console.WriteLine("Please, enter your first mathematical operator:");
            string firstOperator = Console.ReadLine();

            Console.WriteLine("Please, enter your second mathematical operator:");
            string secondOperator = Console.ReadLine();

            Console.WriteLine("Please, enter your first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter your second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter your third number:");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());

            /* Detta är en matematik-koll för att garantera att matematiska operationer utförs i korrekt ordning.
             * 
             * Det vill säga, om den andra operationen är multiplikation eller division samtidigt som första operationen ej är det
             * så hamnar vi i if-satsen och de två switch-satserna gör att ekvationen beräknas i korrekt ordning.
             * 
             * Om den andra matematiska operationen ej är multiplikation eller division så skippas hela if-satsen och vi
             * hamnar därför i nästa omgång med switch-satser som utför alla de matematiska beräkningarna.
             */

            if (secondOperator == "*" || secondOperator == "/" && firstOperator != "*" || firstOperator != "/")
            {
                switch (secondOperator)
                {
                    case "*": answerPartial = secondNumber * thirdNumber;
                        break;
                    case "/": answerPartial = secondNumber / thirdNumber;
                        break;
                }
                switch (firstOperator)
                {
                    case "+": answerFinal = firstNumber + answerPartial;
                        break;
                    case "-": answerFinal = firstNumber - answerPartial;
                        break;
                }

            }

            switch (firstOperator)
            {
                case "+":
                    answerPartial = firstNumber + secondNumber;
                    break;
                case "-":
                    answerPartial = firstNumber - secondNumber;
                    break;
                case "*":
                    answerPartial = firstNumber * secondNumber;
                    break;
                case "/":
                    answerPartial = firstNumber / secondNumber;
                    break;
                case "%":
                    answerPartial = firstNumber % secondNumber;
                    break;
            }
            switch (secondOperator)
            {
                case "+":
                    answerFinal = answerPartial + thirdNumber;
                    break;
                case "-":
                    answerFinal = answerPartial - thirdNumber;
                    break;
                case "*":
                    answerFinal = answerPartial * thirdNumber;
                    break;
                case "/":
                    answerFinal = answerPartial / thirdNumber;
                    break;
                case "%":
                    answerFinal = answerPartial % thirdNumber;
                    break;
            }

            /* Här skrivs bara ekvationen ut, vilket inkluderar alla valda tal, matematiska operationer, samt svar.*/

            Console.WriteLine();
            Console.WriteLine("Your equation: " + firstNumber + " " + firstOperator + " " + secondNumber + " " + secondOperator + " " + thirdNumber + " " + "=" + " " + answerFinal);
            Console.WriteLine();
        }
    }
}
