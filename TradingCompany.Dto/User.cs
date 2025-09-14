using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Dto
{
    public class User
    {
        public int UserId { get; set; }
        public int FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BankCardNumber { get; set; }
        public bool IsMale { get; set; }
        public string RestoreKey  { get; set; }
        public Role Role { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
