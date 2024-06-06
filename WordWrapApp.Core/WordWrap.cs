using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordWrapApp.Core
{
    public class WordWrap
    {
        public static string Wrap(string inputString, int columnWidth)
        {
            string[] words = inputString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string formattedStringWithoutExtraSpaces = string.Join(" ", words);
            string resultString = "";
            string maxWidthString = "";

            for (int i = 0; i < formattedStringWithoutExtraSpaces.Length; i++)
            {

                // Check for spaces
                if (formattedStringWithoutExtraSpaces[i].ToString() == " ")
                {
                    resultString += "\n";
                    maxWidthString = "";
                    continue;
                };

                maxWidthString += formattedStringWithoutExtraSpaces[i].ToString();
                resultString += formattedStringWithoutExtraSpaces[i].ToString();

                // Check for last character in the string
                if (i == formattedStringWithoutExtraSpaces.Length - 1)
                {
                    resultString += "\n";
                    continue;
                }

                // Check for word width
                if (maxWidthString.Length == columnWidth)
                {
                    resultString += "\n";
                    maxWidthString = "";

                    // Check if the next character isn`t a space
                    if (i + 1 < formattedStringWithoutExtraSpaces.Length && formattedStringWithoutExtraSpaces[i + 1].ToString() == " ")
                    {
                        i++;
                    }
                }
            }

            return resultString;
        }
    }
}
