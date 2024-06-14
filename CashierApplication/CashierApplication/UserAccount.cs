using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }

        public bool ValidateLogin(string uName, string password)
        {
            return this.user_name == uName && this.user_password == password;
        }

        public string GetFullName()
        {
            return this.full_name;
        }
    }

    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }

        public string GetDepartment()
        {
            return this.department;
        }
    }
}
