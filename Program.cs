using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace OkLetsGo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parentheses a = new Parentheses();
            var b = a.GenerateParenthesis(3);
            var c = b;
        }
    }
}