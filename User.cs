using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryApplication
{
    public class User : Account
    {
        public User(string UserName, string Password, int Salary, bool IsAdmin) : base( UserName, Password, Salary, IsAdmin)
        {
        }
    }
}
