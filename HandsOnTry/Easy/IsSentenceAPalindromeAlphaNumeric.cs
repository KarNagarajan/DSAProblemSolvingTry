
namespace HandsOnTry.Easy
{
    internal class IsSentenceAPalindromeAlphaNumeric
    {
        internal bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return true;
            }

            var initialPtr = 0;
            var lastPtr = s.Length - 1;
            s = s.ToLower();

            while (initialPtr < lastPtr)
            {
                var initialChar = s[initialPtr];
                var lastChar = s[lastPtr];

                if ((initialChar >= 48 && initialChar <= 57) || (initialChar >= 65 && initialChar <= 90) || (initialChar >= 97 && initialChar <= 122))
                {
                    if ((lastChar >= 48 && lastChar <= 57) || (lastChar >= 65 && lastChar <= 90) || (lastChar >= 97 && lastChar <= 122))
                    {
                        if (initialChar != lastChar)
                        {
                            return false;
                        }

                        initialPtr++;
                        lastPtr--;
                    }
                    else
                    {
                        lastPtr--;
                    }
                }
                else
                {
                    initialPtr++;
                }
            }

            return true;
        }
    }
}