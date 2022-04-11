using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AdditionalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "   Предложение  один    Теперь  предложение   два     Предложение    три    ";
            Console.WriteLine(str);

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            string res = regex.Replace(str, " ");

            Console.WriteLine(res);

            StringBuilder stringBuilder = new StringBuilder(res);

            for (int i = 2; i < res.Length; i++)
            {
                if (res[i] >= 'A' && res[i] <= 'Я')
                {
                    stringBuilder[i - 1] = '.';
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
