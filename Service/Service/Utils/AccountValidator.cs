using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Utils
{
    

    public class AccountValidator
    {
        public List<string> ValidateAccount(Account account)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(account.AccName))
            {
                errors.Add("Account name must not be empty.");
            }
            else if (!IsUppercase(account.AccName))
            {
                errors.Add("Account name must start with an uppercase letter and have subsequent uppercase letters after whitespace.");
            }

            if (string.IsNullOrWhiteSpace(account.AccPass))
            {
                errors.Add("Account password must not be empty.");
            }

            if (string.IsNullOrWhiteSpace(account.AccPhone))
            {
                errors.Add("Account phone number must not be empty.");
            }
            else if (account.AccPhone.Length != 10 || !IsNumeric(account.AccPhone))
            {
                errors.Add("Account phone number must be a 10-digit number.");
            }

            if (!IsValidDateOfBirth(account.AccDob))
            {
                errors.Add("Account date of birth must be at least 20 years ago.");
            }

            return errors;
        }

        private bool IsUppercase(string value)
        {
            string[] nameParts = value.Split(' ');

            foreach (string part in nameParts)
            {
                if (part.Length > 0 && !char.IsUpper(part[0]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        private bool IsValidDateOfBirth(DateTime dob)
        {
            return (DateTime.Now.Year - dob.Year) > 20;
        }
    }

}
