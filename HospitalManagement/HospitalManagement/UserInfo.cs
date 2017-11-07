using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class UserInfo
    {
        public string Identifier { get; set; }
        public string Username { get; set; }
        private string password;


        public UserInfo(string id, string usename, string pword)
        {
            this.Identifier = id;
            this.Username = usename;
            this.password = pword;
        }

        public Boolean PasswordIsCorrect (string passwordAttempt)
        {
            if (passwordAttempt.Equals(this.password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
