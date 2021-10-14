using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            // Practice question
            p1.abstIntfPractice();

            // Question 05
            p1.questionFive();

            // Exceptions - Practice
            p1.exceptionPractice();

            // Exceptions - Practice 02
            p1.exceptionPracticeTwo();
        }

        // Practice question - Method
        public void abstIntfPractice()
        {
            Circle circle1 = new Circle();
            circle1.name = "Blue Circle";
            circle1.color = "Blue";
            circle1.radius = 10;
            circle1.getArea();
            circle1.getPerimeter();
            Console.WriteLine($"Name of this shape is : {circle1.name} and the color is {circle1.color}");
            Console.ReadLine();
        }

        // Question 05 - Method
        public void questionFive()
        {
            IAccount savingAccount = new SavingAccount();
            savingAccount.printAccountData();
            IAccount currentAccount = new CurrentAccount();
            currentAccount.printAccountData();
            Console.ReadLine();
        }

        // Exceptions - Practice - Method
        public void exceptionPractice()
        {
            try
            {
                Console.Write("Enter number : ");
                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Your number is : {number}.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Exception occured - Error - {e.Message}");
            }
            
            Console.ReadLine();
        }

        // Exceptions - Practice 02 - Method
        public void exceptionPracticeTwo()
        {
            try
            {
                int n1 = 0;
                int n2 = 0;
                int div = 0;

                Console.Write("Enter number one : ");
                n1 = Int32.Parse(Console.ReadLine());

                Console.Write("Ënter number two : ");
                n2 = Int32.Parse(Console.ReadLine());

                div = n1 / n2;
            }
            catch (FormatException e) 
            {
                Console.WriteLine($"Exception occured - Error - {e.Message}");
            }
            catch (DivideByZeroException e) 
            {
                Console.WriteLine($"Exception occured - Error - {e.Message}");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Exception occured - Error - {e.Message}");
            }
        }


    }
}
