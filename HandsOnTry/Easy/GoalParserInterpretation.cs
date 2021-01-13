
namespace HandsOnTry.Easy
{
    internal class GoalParserInterpretation
    {
        internal string Interpret(string command)
        {
            var output = string.Empty;
            var length = command.Length;
            var i = 0;

            while (i < length)
            {
                var character = command[i];
                if (character == 'G')
                {
                    output += character;
                    i++;
                    continue;
                }

                if (i + 1 < length)
                {
                    if (command[i] == '(' && command[i + 1] == ')')
                    {
                        output += 'o';
                        i += 2;
                        continue;
                    }

                    if (command[i] == '(' && command[i + 1] == 'a')
                    {
                        output += 'a';
                        output += 'l';
                        i += 4;
                        continue;
                    }
                }

                i++;
            }

            return output;
        }
    }
}
