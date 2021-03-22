using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account : Transaction
    {
        public string accId { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public Account() { }
        public Account(string accid, string accname, double balance)
        {
            accId = accid;
            accName = accname;
            accBalance = balance;
        }
        
        
        

        virtual public void Transfer(int amount, Account acc)
        {
            if (accBalance > amount)
            {
                accBalance = accBalance - amount;
                accBalance = accBalance + amount;
                Console.WriteLine("Balance Transfered.");
                Transaction t = new Transaction(this, acc, amount, "Money Transfer");
                this.addtransaction(t);
                acc.addtransaction(t);
            }
            else
                Console.WriteLine("Invalid Amount.");
        }
        public int TotalNumberOfTransaction { get; set; }

        private Transaction[] listOfTransaction;

        public void addtransaction(Transaction transaction)
        {
            listOfTransaction[TotalNumberOfTransaction++] = transaction;


        }
        public void showAllTransactions()
        {
            for (int i = 0; i < (TotalNumberOfTransaction + 1); i++)
            {
                listOfTransaction[i].ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + accId);
            Console.WriteLine("Balance: " + accBalance);

        }
    }
}

