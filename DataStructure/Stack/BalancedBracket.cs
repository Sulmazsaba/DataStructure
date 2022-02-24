using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{

    public class BalancedBracket
    {
        public class Stack
        {
            private int top = -1;
            char[] brackets = new char[100];

            public void Push(char character)
            {
                if (brackets.Length == top)
                {
                    throw new InvalidOperationException();
                }

                brackets[++top] = character;
            }

            public char Pop()
            {
                if (IsEmpty())
                    throw new InvalidOperationException();

                var element = brackets[top];
                top--;
                return element;
            }

            public bool IsEmpty() => top == -1;
            public bool IsFull() => top == brackets.Length;
        }

        public static bool AreBracketsBalanced(char[] expressions)
        {
            Stack stack = new Stack();

            foreach (char exp in expressions)
            {
                if (exp == '(' || exp == '{' || exp == '[')
                {
                    //if (stack.IsFull())
                    //    return false;
                    stack.Push(exp);
                }
                else if (stack.IsEmpty())
                    return false;

                if (exp == ')')
                {
                    if (stack.Pop() != '(')
                        return false;
                }
                else if (exp == ']')
                {
                    if (stack.Pop() != '[')
                        return false;

                }
                else if (exp == '}')
                {
                    if (stack.Pop() != '{')
                        return false;
                }
            }

            if (!stack.IsEmpty())
                return false;

            return true;
        }
    }
}
