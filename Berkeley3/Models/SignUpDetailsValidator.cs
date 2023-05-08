using FluentValidation;
using System.Collections.Generic;

namespace Berkeley3.Models
{
    /// <summary>
    /// This is a simple implementation of a fluent validator class.
    /// It is used to check that the email is unique and the contents of the password.
    /// </summary>
    public class SignUpDetailsValidator : AbstractValidator<SignUpDetails>
    {
        public SignUpDetailsValidator()
        {
            RuleFor(x => x.Email).Must(EmailValidate).WithMessage("The email address must be unique");
            RuleFor(x => x.Password).Must(PasswordValidate).WithMessage("Password must have 1 uppercase character and one number");
        }

        /// <summary>
        /// I have hard coded a list of email addresses for validation.
        /// In a 'real world' implementation of this we would inject a service class or even a repository to return the list of email address for validation.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EmailValidate(string email)
        {
            var listOfEmails = new List<string>() { "matthew@claygate.com", "bertie@claygatek9s.com", "ruby@esherk9s.com", "dexter@waltonk9s.com" };
            return !listOfEmails.Contains(email);
        }

        /// <summary>
        /// This can be done using annotations with a regular expression but....
        /// Rather than adding a complicated (and difficult to maintain regular expression use the fluent validator and write a method code).
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool PasswordValidate(string password)
        {
            var hasUpperCaseChar = false;
            var hasNumber = false;
            foreach (char c in password.ToCharArray())
            {
                if (char.IsUpper(c) && !hasUpperCaseChar)
                    hasUpperCaseChar = true;
                if (char.IsDigit(c) && !hasNumber)
                    hasNumber = true;
            }
            return hasUpperCaseChar && hasNumber;
        }
    }
}