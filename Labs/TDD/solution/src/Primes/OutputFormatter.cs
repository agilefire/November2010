using System.Collections.Generic;
using System.Text;

namespace Primes
{
    public class OutputFormatter
    {
        public List<string> Format(string input)
        {
            var elements = input.Split(",".ToCharArray());

            var result = new List<string>();

            var lineCount = 0;

            for (var i = 0; i < elements.Length; i += 5)
            {
                var stringBuilder = new StringBuilder();

                for (var j = i; j < i + 5; j++)
                {
                    stringBuilder.Append(elements[j]);
                    stringBuilder.Append(",");
                    if (j == elements.Length - 1)
                        break;
                }

                var theString = stringBuilder.ToString();

                if (theString.EndsWith(","))
                    theString = theString.Substring(0, theString.Length - 1);

                if (lineCount > 0 && (lineCount%10 == 0))
                    result.Add("Count: " + i);

                lineCount += 1;

                result.Add(theString);
            }


            return result;
        }
    }
}