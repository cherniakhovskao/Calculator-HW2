using System;

namespace Calculator_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Welcome to Calculator!");
            int userInput = 1;
            double resultNumber = 0;
            while (userInput == 1)
            {
                bool number1 = false;
                bool number2 = false;
                bool incorrectInput = true;
                double num1;
                double num2;
                do
                {
                    Console.WriteLine("Please enter number 1:");
                    number1 = double.TryParse(Console.ReadLine(), out num1);
                    Console.WriteLine("Please enter number 2 (does not equels 0):");
                    number2 = double.TryParse(Console.ReadLine(), out num2);

                    if (num2 == 0 || (!number1) || (!number2))
                    {
                        Console.WriteLine("Your input is not correct");
                        continue;
                    }
                    incorrectInput = false;
                }
                while (incorrectInput);

                bool IncorrectOp = true;

                do
                {
                    Console.Write("Operation: ");

                    string operation = Console.ReadLine();

                    string errorMessage = "";

                    switch (operation)
                    {
                        case "+":
                            resultNumber = num1 + num2;
                            break;
                        case "-":
                            resultNumber += num1 - num2;
                            break;
                        case "/":
                            resultNumber = num1 / num2;
                            break;
                        case "*":
                            resultNumber = num1 * num2;
                            break;
                        case "p":
                            resultNumber = Math.Pow(num1, num2);
                            break;
                        case "r":
                            resultNumber = Math.Pow(num1, (1 / num2));
                            break;

                        default:
                            errorMessage = "Please enter the operation again, your input is not good";
                            break;

                    }



                    if (errorMessage.Length == 0)
                    {
                        Console.WriteLine("Result: " + resultNumber);
                        IncorrectOp = false;
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }

                } while (IncorrectOp);

                Console.WriteLine("Please choose one of the following options to continue:\n 1 - start calculator, \n 2 - continue using last result,\n 3 - exit program)");

                bool incorrectUserChoice = true;
                bool userChoice = false;
                do
                {
                    Console.WriteLine("Your choice? ");
                    userChoice = int.TryParse(Console.ReadLine(), out userInput);

                    if (userInput<1 || userInput >3 || (!userChoice))
                    {
                        Console.WriteLine("Please try again, your input is not correct");
                        continue;
                    }
                    incorrectUserChoice = false;
                }
                while (incorrectUserChoice);
                continue;
            }



            while (userInput == 2)
            {
                bool number2 = false;
                bool incorrectInput = true;
                double num1= resultNumber;
                Console.WriteLine("Your previous result = number 1: "+num1);
                double num2;
                do
                {
                    
                    Console.WriteLine("Please enter number 2 (does not equels 0)");
                    number2 = double.TryParse(Console.ReadLine(), out num2);

                    if (num2 == 0 || (!number2))
                    {
                        Console.WriteLine("Your input is not correct");
                        continue;
                    }
                    incorrectInput = false;
                }
                while (incorrectInput);

                Console.Write("Operation: ");

                string operation = Console.ReadLine();

                string errorMessage = "";

                switch (operation)
                {
                    case "+":
                        resultNumber = num1 + num2;
                        break;
                    case "-":
                        resultNumber += num1 - num2;
                        break;
                    case "/":
                        resultNumber = num1 / num2;
                        break;
                    case "*":
                        resultNumber = num1 * num2;
                        break;
                    case "p":
                        resultNumber = Math.Pow(num1, num2);
                        break;
                    case "r":
                        resultNumber = Math.Pow(num1, (1 / num2));
                        break;

                    default:
                        errorMessage = "Wrong Operation";
                        break;

                }



                if (errorMessage.Length == 0)
                {
                    Console.WriteLine("Result: " + resultNumber);
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }


                Console.WriteLine("Please choose one of the following options to continue: \n 1 - start calculator,\n 2 - continue using last result,\n 3 - exit program)");

                bool incorrectUserChoice = true;
                bool userChoice = true;
                do
                {
                    Console.WriteLine("Your choice?: ");
                    userChoice = int.TryParse(Console.ReadLine(), out userInput);

                    if (userInput < 1 || userInput > 3 || (!userChoice))
                    {
                        Console.WriteLine("Please try again, your input is not correct");
                        continue;
                    }
                    incorrectUserChoice = false;
                }
                while (incorrectUserChoice);
                continue;
            }

            if (userInput == 3)
            {
                Console.WriteLine("Bye-Bye");
                return;
            }


        }
    }
}
