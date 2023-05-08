using Berkeley1.Service.Implementations;
using Berkeley1.Service.Interfaces;
using Berkeley2.Interfaces;
using System.Text.RegularExpressions;

namespace Berkeley2.Implementations
{
    public class PalindromeService : IPalindromeService
    {
        private readonly IStringService _stringService;

        /// <summary>
        /// Constructor creates an instance of the string service from exercise 1.
        /// We can then use the reverse method.
        /// Typically this would be injected but make sure you are not injecting the debug version:-).
        /// </summary>
        public PalindromeService()
        {
            _stringService = new StringService();
        }

        /// <summary>
        /// Remove all non characters. Use a regular expression.
        /// </summary>
        /// <param name="palindrome"></param>
        /// <returns></returns>
        public bool IsPalindrome(string palindrome)
        {
            if (string.IsNullOrEmpty(palindrome))
                return false;

            palindrome = Regex.Replace(palindrome, "[^0-9A-Za-z]", "");

            var len = palindrome.Length / 2;

            var part1 = palindrome.Substring(0, len);
            string part2;
            if (palindrome.Length % 2 == 0)
            {
                part2 = _stringService.ReverseString(palindrome.Substring(len));
            }
            else
            {
                part2 = _stringService.ReverseString(palindrome.Substring(len + 1));
            }

            return part1.Equals(part2, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
