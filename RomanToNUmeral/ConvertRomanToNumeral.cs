using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class ConvertRomanToNumeral
    {
        public int GetValue(char ToValue)
        {
            switch (ToValue)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }

        public int RomanToNumeral(string UserInput)
        {
            int num = 0, i;
            for (i = 0; i < UserInput.Length - 1;)
            {
                if (GetValue(UserInput[i]) >= GetValue(UserInput[i + 1]))
                {
                    num += GetValue(UserInput[i]);
                    i++;
                }
                else
                {
                    num += GetValue(UserInput[i + 1]) - GetValue(UserInput[i]);
                    i += 2;
                }
            }
            if (i != UserInput.Length)
            {
                num += GetValue(UserInput[i]);
            }

            return num;
        }

        public bool ValidateRoman(string UserInput)
        {

            Regex Check = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
            Match match = Check.Match(UserInput);
            if (match.Length>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
