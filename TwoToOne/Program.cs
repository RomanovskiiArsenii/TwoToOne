/*
Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, 
the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
Use method "public static string Longest(string s1, string s2)"

Example:
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"
*/

using System.Text;

class Program
{   
    /// <summary>
    /// Метод принимает две строки из букв, объединяет их по принципу объединения
    /// множеств (повторяющиеся символы удаляются) и сортирует по возрастанию.
    /// </summary>
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            HashSet<char> set = new();                                  //множество
            StringBuilder output = new();                               

            foreach (char c in s1) set.Add(c);                          //добавление в множество символов первой строки
            foreach (char c in s2) set.Add(c);                          //объединение множеств

            foreach (char c in set.OrderBy(t => t)) output.Append(c);   //сортировка
            return output.ToString();                                   
        }
    }
    static void Main(string[] args)
    {
        string a = "DCBA";
        string b = "FEDC";
        string c = TwoToOne.Longest(a, b);
        Console.WriteLine(c);                   //ABCDEF
    }
}