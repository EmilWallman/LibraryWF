﻿using System;
namespace librarywf
{
    public class User
    {

        public string username;
        public string password;
        public string ssn;
        public bool isAdmin;


        public User(string username, string password, string ssn, bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
            this.ssn = ssn;
        }
    }
    public class CurrentUser
    {
        public string ssn;
        public string username;
        public string password;
    }
}
