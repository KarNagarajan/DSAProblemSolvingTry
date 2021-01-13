
namespace HandsOnTry
{
    internal class CountEachCharacterAndSay
    {
        internal string CountAndSay(int n)
        {
            var originalString = "1";

            for (var i = 1; i < n; i++)
            {
                var tempString = string.Empty;
                var j = 0;

                while (j < originalString.Length)
                {
                    var count = 1;
                    while (j + 1 < originalString.Length && originalString[j] == originalString[j + 1])
                    {
                        count++;
                        j++;
                    }

                    tempString = tempString + count + originalString[j];
                    j++;
                }

                originalString = tempString;
            }

            return originalString;
        }
    }
}