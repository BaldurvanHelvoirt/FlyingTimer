﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace FlyingTimer
{
    class Database
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=flyingtimer; Uid=root; Pwd=;");

        public bool CheckLogin(string Login, string Wachtwoord)
        {
            con.Open();
            MySqlCommand Check_login = new MySqlCommand("SELECT * FROM users WHERE username = @Login and password = @password", con);
            Check_login.Parameters.AddWithValue("@Login", Login);
            Check_login.Parameters.AddWithValue("@password", Wachtwoord);
            MySqlDataReader reader = Check_login.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public int GetUserId(string Login)
        {
            int UserId = 0;
            con.Open();
            MySqlCommand GetUserId = new MySqlCommand("SELECT userid FROM users WHERE username = @Login", con);
            GetUserId.Parameters.AddWithValue("@Login", Login);
            MySqlDataReader reader2 = GetUserId.ExecuteReader();
            while (reader2.Read())
            {
                UserId = reader2.GetInt32(reader2.GetOrdinal("userid"));
            }
            return UserId;
        }
        public void RegisterUser(string username, string password, string fname, string lname)
        {
            con.Open();
            MySqlCommand Register = new MySqlCommand("INSERT INTO users (username, password, firstname, lastname) VALUES (@username, @password, @fname, @lname)", con);
            Register.Parameters.AddWithValue("@username", username);
            Register.Parameters.AddWithValue("@password", password);
            Register.Parameters.AddWithValue("@fname", fname);
            Register.Parameters.AddWithValue("@lname", lname);
            Register.ExecuteNonQuery();
            con.Close();
        }
    }
}
