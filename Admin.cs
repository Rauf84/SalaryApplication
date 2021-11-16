using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryApplication
{
    class Admin : Account
    {
        public Admin(string UserName, string Password, int Salary, bool IsAdmin) : base(UserName, Password, Salary, IsAdmin)
        {
        }
    }
}
