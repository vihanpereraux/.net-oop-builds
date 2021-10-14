using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice question
            Program p1 = new Program();
            p1.abstIntfPractice();
            p1.questionFive();
        }

        //Practice question - Method
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

        public void questionFive()
        {
            IAccount savingAccount = new SavingAccount();
            savingAccount.printAccountData();
            IAccount currentAccount = new CurrentAccount();
            currentAccount.printAccountData();
            Console.ReadLine();
        }
    }
}
