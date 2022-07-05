using System;
using System.Text.RegularExpressions;

namespace NewLetsPet.Domain.Pets.Validators
{
	public class GuardianValidator
	{
		public GuardianValidator()
		{
		}

		public bool Validate(Guardian guardian)
		{
            return ValidateName(guardian);
		}

        /// <summary>
        /// Responsible to validate guardian's name
        /// </summary>
        /// <param name="guardian">animal owner</param>
        /// <returns>Return true if guardian name is valid</returns>
		public bool ValidateName(Guardian guardian)
		{
            if (string.IsNullOrWhiteSpace(guardian.Name) ||
                guardian.Name.Length < 4)
            {
                return false;
            }

            // return numeric characters in a string
            Regex regex = new Regex(@"[\d-]");
            var result = regex.Match(guardian.Name);
            var newStr = regex.Replace(guardian.Name, ""); // replace chars in orinigal string
            if (result.Success)
            {
                return false;
            }

            return true;
        }

    }
}

