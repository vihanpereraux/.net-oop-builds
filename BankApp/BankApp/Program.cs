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

            // Exceptions - Question 03
            p1.questionThree();

            // Exceptions - Question 04
            p1.questionFour();

            // Exceptions - Question 05
            p1.exceptionQuestionFive();

            // Exceptions - Question 06
            p1.questionSix();
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
                Console.WriteLine($"Answer is {div}");
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

        // Exceptions - Question 03 - Method
        public void questionThree()
        {
            int index = 6;
            int[] arr = new int[5];
            try
            {
                arr[index] = 100;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds occurred");
            }
            Console.WriteLine("Program execution continued after Exception Handling");
        }

        // Exceptions - Question 04 - Method
        public void questionFour()
        {
            try
            {
                Console.WriteLine("Exception:" + " " + 1 / Convert.ToInt32(0));
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Divide by Zero error");
            }
            Console.ReadLine();
        }

        // Exceptions - Question 05 - Method
        public void exceptionQuestionFive()
        {
            int i = 5;
            int v = 40;
            int[] p = new int[4];
            try
            {
                p[i] = v;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds");
            }
            Console.WriteLine("Remaining program");
        }

        // Exceptions - Question 06 - Method
        public void questionSix()
        {
            try
            {
                string[] list = new string[5];
                list[0] = "Sunday";
                list[1] = "Monday";
                list[2] = "Tuesday";
                list[3] = "Wednesday";
                list[4] = "Thursday";
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Index out of bounds - Error is {e.Message}");
            }
            Console.ReadLine();
        }

    }
}
