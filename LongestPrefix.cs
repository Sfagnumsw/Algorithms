
namespace OkLetsGo
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string shortestString = strs[0];
            foreach (var i in strs)
            {
                if (i.Length <= shortestString.Length)
                {
                    shortestString = i;
                }
            }

            string prefix = shortestString;
            foreach (var i in strs)
            {
                for (int j = prefix.Length - 1; j >= 0;)
                {
                    if (i[j] != prefix[j])
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                        j = prefix.Length - 1;
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            return prefix;
        }
    }
}
