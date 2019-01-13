using System;
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

        public void GetOverzicht(string drone, string model, string username)
        {
            con.Open();
            MySqlCommand GetRaceOverzicht = new MySqlCommand("SELECT laps, time, date FROM time WHERE races_racesid = " +
                                                             "(SELECT raceid FROM races WHERE drone_droneid = " +
                                                             "(SELECT droneid FROM drone WHERE drone = @drone AND model = @model AND users_userid = " +
                                                             "(SELECT userid FROM users WHERE username = @username)))", con);
            GetRaceOverzicht.Parameters.AddWithValue("@drone", drone);
            GetRaceOverzicht.Parameters.AddWithValue("@model", model);
            GetRaceOverzicht.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = GetRaceOverzicht.ExecuteReader();
            while (reader.Read())
            {

            }
        }
    }
}
