using Berkeley3.Domain;
using Berkeley3.Implementations;
using Berkeley3.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Berkeley3.Models
{
    /// <summary>
    /// This is a simple implementation of a fluent validator class.
    /// It is used to check that the email is unique and the contents of the password.
    /// </summary>
    public class SignUpDetailsValidator : AbstractValidator<SignUpDetails>
    {
        private IEmailRepository _emailRepository;
        private List<Email> emails;

        public SignUpDetailsValidator()
        {
            RuleFor(x => x.Email).Must(EmailValidate).WithMessage("The email address must be unique");
            RuleFor(x => x.Password).Must(PasswordValidate).WithMessage("Password must have 1 uppercase character and one number");
            // Create a repository. Typically this would be done with a DI framework. The example in Berkeley1 demonstrates Ninject so here I will
            // just create an instance of the repository class.
            _emailRepository = new EmailRepository();
            emails = _emailRepository.List();
        }

        /// <summary>
        /// Validate the emails using the repository which has returned a list of emails.
        /// If the list of emails was very large then a more complex validation might be needed for performance gain.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EmailValidate(string email)
        {
            return !emails.Any(e => e.Address.Equals(email, StringComparison.OrdinalIgnoreCase));
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