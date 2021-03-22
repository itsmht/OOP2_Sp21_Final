using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Transaction
    {
        public Account sender { get; set; }
        public Account reciever { get; set; }
        public int amount { get; set; }
        public string additionalInfo { get; set; }
        public Transaction() { }
        public Transaction(Account sender, Account reciever, int amount, string additionalInfo)
            
        {
            this.sender = sender;
            this.reciever = reciever;
            this.amount = amount;
            this.additionalInfo = additionalInfo;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Sender Name: {0} Account ID: {1}", sender.accName, sender.accId);
            Console.WriteLine("Receiver Name:{0} Account ID:{1}", reciever.accName, reciever.accId);
            Console.WriteLine("Ammount:" + amount);
            Console.WriteLine("Additional Information:" + additionalInfo);
            Console.WriteLine();
        }
    }
}


