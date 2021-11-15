using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeDesignPatternApp.SubModel;

namespace FacadeDesignPatternApp.Model
{
    class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1} loan\n",
                cust.Name, amount);
            bool eligible = true;
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
