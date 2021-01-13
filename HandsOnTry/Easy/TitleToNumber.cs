
namespace HandsOnTry.Easy
{
    internal class TitleToNumber
    {
        internal int ConvertTitleToNumber(string s)
        {
            if (s.Length == 1)
            {
                return s[0] - 64;
            }

            var input = s.ToCharArray();
            var output = 0;

            foreach (var c in input)
            {
                var ch = c - 64;
                output = (output * 26) + ch;
            }

            return output;

            // Solution
            var sum = 0;
            foreach (var c in s)
            {
                var num = c - 'A' + 1;
                sum = sum * 26 + num;
            }

            return sum;
        }
    }
}