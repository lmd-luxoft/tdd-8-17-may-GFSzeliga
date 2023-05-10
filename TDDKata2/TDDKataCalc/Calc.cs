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
            else if(!string.IsNullOrEmpty(digits) && digits.Length < 3 && Int32.TryParse(digits, out parsedNumber))
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
    }
}