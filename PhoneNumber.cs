using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    public class PhoneNumber
    {
        public IList<string> LetterCombinations(string digits) //принимает строку содержащую цифры например(23),
                                                               //учитывая раскаладку кнопочного телефона, вернуть все доступные комбинации букв, которые содержат эти цифры
                                                               //например 2 = abc, 3 = def ; комбинации = ad,ae,af,bd,be,bf,cd,ce,cf ; (1 и 0 не содержат букв)
        {
            string[] mapping = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
            if (digits.Length.Equals(0)) return new List<string>();
            Queue<string> result = new Queue<string>();
            result.Enqueue("");
            while(result.Peek().Length != digits.Length)
            {
                string first = result.Dequeue();
                string matching = mapping[int.Parse(digits[first.Length].ToString()) - 2];
                foreach(char i in matching)
                {
                    result.Enqueue(first + i);
                }
            }
            return result.ToList();
        }
    }
}
