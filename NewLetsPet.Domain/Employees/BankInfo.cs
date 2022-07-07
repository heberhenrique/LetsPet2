using System;
namespace NewLetsPet.Domain.Employees
{
	public class BankInfo
	{
        public string Bank { get; set; }
        public string Agency { get; set; }
        public string AccountNumber { get; set; }
        public string PixType { get; set; }
        public string Pix { get; set; }

        public BankInfo()
        {

        }

        public BankInfo(string bank, string agency, string accountNumber, string pixType, string pix)
        {
            Bank = bank;
            Agency = agency;
            AccountNumber = accountNumber;
            PixType = pixType;
            Pix = pix;
        }
    }
}

