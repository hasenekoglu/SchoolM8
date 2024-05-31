using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace SchoolM8
{
    public class UserSession
    {
        private static UserSession _instance;

        public int UserId { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        public void SetUser(int userId, string email, string role)
        {
            UserId = userId;
            Email = email;
            Role = role;
        }

        public void ClearUser()
        {
            UserId = 0;
            Email = string.Empty;
            Role = string.Empty;
        }

    }
}
