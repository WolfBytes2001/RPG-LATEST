using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class WordWrap
    {
        //for wrapping words only
        public static string Wrap(string input, int maxWidth)
        {
            string[] words = input.Split(' ');
            StringBuilder result = new StringBuilder();
            int currentLineLength = 0;

            foreach (string word in words)
            {
                if (currentLineLength + word.Length + 1 <= maxWidth)
                {
                    result.Append(word + " ");
                    currentLineLength += word.Length + 1;
                }
                else
                {
                    result.AppendLine();
                    result.Append(word + " ");
                    currentLineLength = word.Length + 1;
                }
            }

            return result.ToString();
        }
    }
}
