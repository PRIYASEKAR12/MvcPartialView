﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLeaveManagement.Entity
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Login(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}
