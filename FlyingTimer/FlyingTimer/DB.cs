using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace FlyingTimer
{
    class DB
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
    }
}
