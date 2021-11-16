using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryApplication
{
    public class Account
    {
        public Account(string userName, string password, int salary, bool isAdmin)
        {
            UserName = userName;
            Password = password;
            Salary = salary;
            IsAdmin = isAdmin;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int Salary { get; set; }
        public bool IsAdmin { get; set; }
    }
}
