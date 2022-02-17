using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            BalancedParentheses balancedParentheses = new BalancedParentheses();
            balancedParentheses.BalanceCheck();
            Console.ReadLine();
        }
    }
}
