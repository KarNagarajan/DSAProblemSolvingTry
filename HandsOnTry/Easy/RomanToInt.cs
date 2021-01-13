using System.Collections.Generic;

namespace HandsOnTry.Easy
{
    internal class RomanToInt
    {
        internal int ConvertRomanToInt(string s)
        {
            var dictionary = new Dictionary<char, int>();
            dictionary.Add('I', 1);
            dictionary.Add('V', 5);
            dictionary.Add('X', 10);
            dictionary.Add('L', 50);
            dictionary.Add('C', 100);
            dictionary.Add('D', 500);
            dictionary.Add('M', 1000);

            if (s.Length == 1)
            {
                return dictionary[s[0]];
            }

            var sum = 0;
            var length = s.Length;
            while (length > 0)
            {
                switch (s[length - 1])
                {
                    case 'I' when length != s.Length && (s[length] == 'V' || s[length] == 'X'):
                        sum -= 1;
                        break;
                    case 'X' when length != s.Length && (s[length] == 'C' || s[length] == 'L'):
                        sum -= 10;
                        break;
                    case 'C' when length != s.Length && (s[length] == 'D' || s[length] == 'M'):
                        sum -= 100;
                        break;
                    default:
                        sum += dictionary[s[length - 1]];
                        break;
                }

                length--;
            }

            return sum;
        }
    }
}