using System.Text.RegularExpressions;

namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            int parsedNumber;
            if (string.Empty == digits)
            {
                return 0;
            }
            else if(!string.IsNullOrEmpty(digits) && TryParseInputString(digits, out parsedNumber))
            {
                var firstNumber = parsedNumber % 10;
                var secondNumber = parsedNumber / 10;
                return firstNumber + secondNumber;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private bool TryParseInputString(string digits, out int parsedNumber)
        {
            Regex regex = new Regex("//[^A-Za-z0-9]\n");
            Match match = regex.Match(digits);
            if (match.Success)
            {
                var stringArray = digits.Split('\n');
                var delimiter = stringArray[0].Substring(stringArray[0].Length-1);
                parsedNumber = Int32.Parse(digits.Split('\n')[1].Replace(delimiter,""));
                return true;
            }
            else if (digits.Length < 3 && Int32.TryParse(digits, out parsedNumber))
            {
                return true;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}