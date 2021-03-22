using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Account("Putin", "1234", 12000);
            var b = new Account("Trump", "4321", 4000);
            a.Transfer(1000, b);
            a.showAllTransactions();
            b.showAllTransactions();
        }
    }
}
