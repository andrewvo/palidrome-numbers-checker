using System.Linq;

namespace PalindroneNumbersKata
{
    public class ValidatePalidrone : IValidatePalindrone
    {
        public bool Validate(int individualNumber)
        {

            var stringNumber = individualNumber.ToString();
            var charArray = stringNumber.ToCharArray();
            var backwardCharArray = charArray.Reverse().ToArray();
            var reversedNumber = int.Parse(backwardCharArray);

            return reversedNumber == individualNumber;
        }
    }
}
