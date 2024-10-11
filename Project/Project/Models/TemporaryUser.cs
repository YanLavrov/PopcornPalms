using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    internal class TemporaryUser
    {
        public static string Id;
        public static string PIB;
        public static string Login;
        public static string PhoneNumber;
        public static string Password;

        public TemporaryUser() { }

        public TemporaryUser(User user)
        {
            Id = user.Id;
            PIB = user.PIB;
            Login = user.Login;
            PhoneNumber = user.PhoneNumber;
            Password = user.Password;
        }
    }
}
