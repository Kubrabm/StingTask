using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingTask
{
    internal class StringTask
    {
        public static string AddString()
        {
            Console.Write("Insert text: ");
            string text = Console.ReadLine();

            return text;
        }

        public static string Ceaser(int k, string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        int a = (s[i] - 64 + k) % 26 + 64;
                        result += (char)a;
                    }
                    else
                    {
                        int A = (s[i] - 96 + k) % 26 + 96;
                        result += (char)A;
                    }
                }
                else
                {
                    result += s[i];
                }

            }

            return result;
        }

        public static string AntiCeaser(int k, string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                    {
                        int a = (s[i] - 64 - k) % 26 + 64;

                        if (a <= 64)
                        {
                            a = a + 26;

                        }
                        result += (char)a;
                    }
                    else
                    {
                        int A = (s[i] - 96 - k) % 26 + 96;

                        if (A <= 96)
                        {
                            A = A + 26;

                        }
                        result += (char)A;
                    }
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }

        internal static string DifferenceTime(string date1, string date2)
        {
            int h1 = int.Parse(date1.Substring(0, 2));
            int m1 = int.Parse(date1.Substring(3, 2));
            int s1 = int.Parse(date1.Substring(6, 2));

            int h2 = int.Parse(date2.Substring(0, 2));
            int m2 = int.Parse(date2.Substring(3, 2));
            int s2 = int.Parse(date2.Substring(6, 2));

            int diff = h2 * 60 + m2 + s2 / 60 - (h1 * 60 + m1 + s1 / 60);

            return $"{(diff / 60).ToString().PadLeft(2, '0')}:{(diff % 60).ToString().PadLeft(2, '0')}:{((diff % 60) % 60).ToString().PadLeft(2, '0')}";
        }




        internal static string AddDate()
        {
            Console.Write("Insert start date: ");
            string date1 = Console.ReadLine();

            return date1;
        }

        internal static string EndDate()
        {
            Console.Write("Insert end date: ");
            string date2 = Console.ReadLine();

            return date2;
        }
    }
}
