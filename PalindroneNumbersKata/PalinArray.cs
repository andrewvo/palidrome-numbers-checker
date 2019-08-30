using System.Linq;

namespace PalindroneNumbersKata
{
    public class PalinArray 
    {
        private readonly IValidatePalindrone _validatePalindrone;

        public PalinArray(IValidatePalindrone validatePalindrone)
        {
            _validatePalindrone = validatePalindrone;
        }
        public bool Validate(int[] intArray)
        {
            var intList = intArray.ToList();
            return intList.TrueForAll(il => _validatePalindrone.Validate(il));
        }
    }
}
