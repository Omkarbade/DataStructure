using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BalancedParentheses
    {
        
            public Stack stack = new Stack();
            public string expression = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";

            public void BalanceCheck()
            {
                char[] arrayOfexpression = expression.ToCharArray();

                for (int i = 0; i < arrayOfexpression.Length; i++)
                {
                    if (arrayOfexpression[i] == '(')
                    {
                        stack.Push(arrayOfexpression[i]);
                    }
                    if (arrayOfexpression[i] == ')')
                    {
                        if (stack.top.Equals('('))
                        {
                            stack.Pop();
                        }
                    }

                }

                if (stack.IsEmpty().Equals(0))
                {
                    System.Console.WriteLine("It's Balanced\n ");
                }
                else
                {
                    System.Console.WriteLine("It's Not Balanced\n ");
                }
            }
    }
}
