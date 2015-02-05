using System;

namespace BankOfKurtovoKonare
{
    class Tester
    {
        static void Main()
        {
            Customer pesho = new IndividualCustomer("Petar Petrov","8301125555");
            Customer softUni = new CompanyCustomer("SoftUni","BG 93871904730914");

            Account peshoDeposit = new DepositAcount(pesho, 0.7m, 10000);
            Console.WriteLine("The deposit of pesho is " + peshoDeposit.CalculateInterest(12).ToString("f2"));
            Console.WriteLine();

            Account peshoLoan = new LoanAccount(pesho,0.9m,1000);
            Console.WriteLine("The loan of pesho is " + peshoLoan.CalculateInterest(4).ToString("f2"));

            Account softuniLoan = new LoanAccount(softUni, 12m, 5000);
            Console.WriteLine("The loan of softuni is: " + softuniLoan.CalculateInterest(4).ToString("f2"));
            Console.WriteLine();

            Account peshoMortgage = new LoanAccount(pesho, 2m, 5000);
            Console.WriteLine("The mortgage of pesho is: " + peshoMortgage.CalculateInterest(6).ToString("f2"));

            Account softuniMortgage = new LoanAccount(softUni, 5m, 1000);
            Console.WriteLine("The mortgage of softuni is: " + softuniMortgage.CalculateInterest(6).ToString("f2"));
            Console.WriteLine();
        }
    }
}
