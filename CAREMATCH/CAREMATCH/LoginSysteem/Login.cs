﻿using System.Data;
using CAREMATCH;

namespace Login
{
    class Login
    {
        //database hoort eigenlijk op een andere manier doorgegeven te worden, maar dit werkt voor nu
        public Database database;
        public Login()
        {
            database = new Database();
        }
        //LoginCheck
        public void LoginCheck(string naam, string wachtwoord, LoginForm form1)
        {       
            DataTable dt = new DataTable();
            DataTable dat = new DataTable();
            //sda.Fill(dt);
            //sdaa.Fill(dat);
        }
    }
}

