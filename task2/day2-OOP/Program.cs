using System;

namespace day2_OOP
{
    internal class Program
    {
        class Bank
        {
            private int id;
            private string name;
            private double balance;
            private string accountType;
            private string branchName;

            public Bank(int id, string name, double balance, string accountType, string branchName)
            {
                this.id = id;
                this.name = name;
                this.balance = balance;
                this.accountType = accountType;
                this.branchName = branchName;
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine("Successful, you have " + balance);
                }
                else
                {
                    Console.WriteLine("Invalid amount!");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount <= balance && amount > 0)
                {
                    balance -= amount;
                    Console.WriteLine("Successful, you have " + balance);
                }
                else
                {
                    Console.WriteLine("Not enough balance or invalid amount!");
                }
            }

            public void DisplayInfo()
            {
                Console.WriteLine("\n------ Account Info ------");
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Balance: " + balance + " JOD");
                Console.WriteLine("Account Type: " + accountType);
                Console.WriteLine("Branch: " + branchName);
                Console.WriteLine("----------------------------\n");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Insert Your Information \n*********************************************\n");
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter Account Type: ");
            string accountType = Console.ReadLine();

            Console.Write("Enter Branch Name: ");
            string branchName = Console.ReadLine();

            Bank bank = new Bank(id, name, balance, accountType, branchName);

            int choice;
            do
            {
                Console.WriteLine("\n====== BANK MENU ======");
                Console.WriteLine("1. Display Account Info");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bank.DisplayInfo();
                        break;

                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        double dep = double.Parse(Console.ReadLine());
                        bank.Deposit(dep);
                        break;

                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        double wit = double.Parse(Console.ReadLine());
                        bank.Withdraw(wit);
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
