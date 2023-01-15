using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    public class Parentheses
    ///Учитывая n пары круглых скобок, напишите функцию для генерации всех комбинаций правильно сформированных круглых скобок
    ///Входные данные: n = 3
    ///Выходной сигнал: ["((()))","(()())","(())()","()(())","()()()"]
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            Generate(n, 0, 0, "", list);
            return list;
        }

        public void Generate(int n, int left, int right, string s, List<string> set)
        {
            if (right > left) return;
            if (left.Equals(n) && right.Equals(n))
            {
                set.Add(s);
                return;
            }
            if(left == n)
            {
                Generate(n, left, right + 1, s + ")", set);
                return;
            }
            Generate(n, left + 1, right, s + "(", set);
            Generate(n, left, right + 1, s + ")", set);
        }
    }
}
