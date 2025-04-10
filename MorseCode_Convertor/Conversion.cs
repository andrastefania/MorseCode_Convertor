using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode_Convertor
{
    public static class Conversion
    {
        public static string FromTextToMorseCode(string text)
        {
            var result = new StringBuilder();
            var morseMap = MorseMapping.GetMorseMap();

            foreach (char ch in text.ToUpper())
            {
                if (morseMap.TryGetValue(ch, out string morseCode))
                {
                    result.Append(morseCode + " ");
                }
                else
                {
                    result.Append("? ");
                }
            }

            return result.ToString().Trim();
        }

        public static string FromMorseCodeToText(string morse)
        {
            var result = new StringBuilder();
            var reverseMorseMap = MorseMapping.GetReverseMorseMap();
            var morseSymbols = morse.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string symbol in morseSymbols)
            {
                if (reverseMorseMap.TryGetValue(symbol, out char ch))
                {
                    result.Append(ch);
                }
                else
                {
                    result.Append("?");
                }
            }

            return result.ToString();
        }
    }

}
