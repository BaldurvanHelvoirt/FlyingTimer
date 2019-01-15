using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace FlyingTimer
{
    public partial class FlyingTimer : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=flyingtimer; Uid=root; Pwd=;");
        private int userid;
        private int trackid;
        private int Laps;
        private int Startime;
        private int MilSec;
        private int MilsecElapsed;
        private int Stoptime;
        SerialPort port;
        private DateTime Date = DateTime.Today;
        public delegate void myDelegate(string sData);
        public FlyingTimer(int UserId)
        {
            InitializeComponent();
            LoadItems();
            userid = UserId;
        }

        #region Load Items

        private void LoadItems()
        {
            GetRacetrack_Overzicht();
            GetDrones_Settings();
            GetCountry();
            Addheaders_Timer();
            Addheaders_Overzicht();
        }

        #endregion

        #region Overzicht

        private void cbDrones_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOverzicht(userid, cbRacetracks.SelectedItem.ToString());
        }
        private void GetRacetrack_Overzicht()
        {
            MySqlCommand GetRacetrack = new MySqlCommand("SELECT trackname FROM racetrack", con);
            try
            {
                con.Open();
                MySqlDataReader reader = GetRacetrack.ExecuteReader();

                while (reader.Read())
                {
                    string Racetracks = reader.GetString("trackname");
                    cbRacetracks.Items.Add(Racetracks);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        private void Addheaders_Overzicht()
        {
            lvMijnOverzicht.View = View.Details;
            lvMijnOverzicht.FullRowSelect = true;

            //ADD COLUMNS
            lvMijnOverzicht.Columns.Add("Laps", 100);
            lvMijnOverzicht.Columns.Add("Time", 100);
            lvMijnOverzicht.Columns.Add("Date", 100);
        }
        private void AddItemsToOverzicht(string laps, string time, string date)
        {
            string[] row = { laps, time, date };
            var listViewItem = new ListViewItem(row);
            lvMijnOverzicht.Items.Add(listViewItem);
        }
        public void GetOverzicht(int userid, string trackname)
        {
            con.Open();
            MySqlCommand GetRaceOverzicht = new MySqlCommand("SELECT laps, time, date FROM time WHERE users_userid = @Userid AND racetrack_racetreckid = " +
                                                             "(SELECT racetreckid FROM racetrack WHERE trackname = @Trackname)", con);
            GetRaceOverzicht.Parameters.AddWithValue("@Userid", userid);
            GetRaceOverzicht.Parameters.AddWithValue("@Trackname", trackname);

            MySqlDataReader reader = GetRaceOverzicht.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            if (count > 0)
            {
                string Countries = reader.GetString("laps");
                string Time = reader.GetString("time");
                string Date = reader.GetString("date");
                AddItemsToOverzicht(Countries, Time, Date);
                con.Close();
            }
            else
            {
                con.Close();
                MessageBox.Show("Geen records gevonden");
            }
        }

        #endregion

        #region Settings
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbState.Items.Count == 0)
            {
                
                GetState(cbCountry.SelectedItem.ToString());
            }
            else
            {
                cbState.Items.Clear();
                GetState(cbCountry.SelectedItem.ToString());
            }
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCity.Items.Count == 0)
            {
                GetCity(cbState.SelectedItem.ToString());
            }
            else
            {
                cbCity.Items.Clear();
                GetCity(cbState.SelectedItem.ToString());
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRacetrack.Items.Count == 0)
            {
                GetRacetrack(cbCity.SelectedItem.ToString());
            }
            else
            {
                cbRacetrack.Items.Clear();
                GetRacetrack(cbCity.SelectedItem.ToString());
            }
        }

        private void cbRacetrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTrackId(cbRacetrack.SelectedItem.ToString());
        }

        private void btnSelectSettings_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tcTimer;
            DisableComboBox();
        }

        private void GetCountry()
        {
            MySqlCommand GetCountries = new MySqlCommand("SELECT countryid, countryname FROM country", con);
            try
            {
                con.Open();
                MySqlDataReader reader = GetCountries.ExecuteReader();
                
                while (reader.Read())
                {
                    string Countries = reader.GetString("countryname");
                    cbCountry.Items.Add(Countries);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        private void GetState(string country)
        {
            MySqlCommand GetStates = new MySqlCommand("SELECT statename FROM state WHERE country_countryid = (SELECT countryid FROM country WHERE countryname = @Country)", con);
            GetStates.Parameters.AddWithValue("@Country", country);
            try
            {
                con.Open();
                MySqlDataReader reader = GetStates.ExecuteReader();

                while (reader.Read())
                {
                    string States = reader.GetString("statename");
                    cbState.Items.Add(States);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        private void GetCity(string state)
        {
            MySqlCommand GetCities = new MySqlCommand("SELECT cityname FROM city WHERE state_stateid = (SELECT stateid FROM state WHERE statename = @State)", con);
            GetCities.Parameters.AddWithValue("@State", state);
            try
            {
                con.Open();
                MySqlDataReader reader = GetCities.ExecuteReader();

                while (reader.Read())
                {
                    string Cities = reader.GetString("cityname");
                    cbCity.Items.Add(Cities);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        private void GetRacetrack(string city)
        {
            MySqlCommand GetRacetrack = new MySqlCommand("SELECT trackname FROM racetrack WHERE city_cityid = (SELECT cityid FROM city WHERE cityname = @City)", con);
            GetRacetrack.Parameters.AddWithValue("@City", city);
            try
            {
                con.Open();
                MySqlDataReader reader = GetRacetrack.ExecuteReader();

                while (reader.Read())
                {
                    string Racetrack = reader.GetString("trackname");
                    cbRacetrack.Items.Add(Racetrack);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }

        public int GetTrackId(string trackname)
        {
            int TrackId = 0;
            con.Open();
            MySqlCommand GetUserId = new MySqlCommand("SELECT racetreckid FROM racetrack WHERE trackname = @Trackname", con);
            GetUserId.Parameters.AddWithValue("@Trackname", trackname);
            MySqlDataReader reader = GetUserId.ExecuteReader();
            while (reader.Read())
            {
                TrackId = reader.GetInt32(reader.GetOrdinal("racetreckid"));
            }
            con.Close();
            trackid = TrackId;
            return trackid;
        }

        private void GetDrones_Settings()
        {
            MySqlCommand GetDrone = new MySqlCommand("SELECT merk FROM drone", con);
            try
            {
                con.Open();
                MySqlDataReader reader = GetDrone.ExecuteReader();

                while (reader.Read())
                {
                    string Drones = reader.GetString("merk");
                    cbDrone.Items.Add(Drones);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
            }
        }
        
        private void DisableComboBox()
        {
            cbCountry.Enabled = false;
            cbState.Enabled = false;
            cbCity.Enabled = false;
            cbRacetrack.Enabled = false;
            cbDrone.Enabled = false;
        }

        #endregion

        #region Timer

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            tmTime.Start();
        }
        private void tmTime_Tick(object sender, EventArgs e)
        {
            MilsecElapsed++;
            lblMilSec.Text = MilsecElapsed.ToString();
            if (MilsecElapsed == 10)
            {
                Laps++;
                lblLaps.Text = Laps.ToString();
                AddTimeToListVieuw(lblLaps.Text, lblMilSec.Text);
                MilsecElapsed = 0;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            tmTime.Stop();
            SaveLapTimes(trackid, userid, Date);
        }
        private void Addheaders_Timer()
        {
            lvLaptimes.View = View.Details;
            lvLaptimes.FullRowSelect = true;

            //ADD COLUMNS
            lvLaptimes.Columns.Add("Laps", 150);
            lvLaptimes.Columns.Add("Time", 150);
        }
        private void AddTimeToListVieuw(string laps, string time)
        {
            string[] row = { laps, time };
            var listViewItem = new ListViewItem(row);
            lvLaptimes.Items.Add(listViewItem);
        }

        private void SaveLapTimes(int racetrackid, int userid, DateTime date)
        {
            con.Open();
            foreach (ListViewItem item in lvLaptimes.Items)
            {
                MySqlCommand Laptimes = new MySqlCommand("INSERT INTO time (racetrack_racetreckid, users_userid, laps, time, date) VALUES (@trackid, @users, @laps, @time, @date)", con);
                Laptimes.Parameters.Add("@trackid", racetrackid);
                Laptimes.Parameters.Add("@users", userid);
                Laptimes.Parameters.Add("@laps", item.SubItems[0].Text);
                Laptimes.Parameters.Add("@time", item.SubItems[1].Text);
                Laptimes.Parameters.Add("@date", date);
                Laptimes.ExecuteNonQuery();
            }
            con.Close();
            EnableComboBox();
        }

        private void EnableComboBox()
        {
            cbCountry.Enabled = true;
            cbState.Enabled = true;
            cbCity.Enabled = true;
            cbRacetrack.Enabled = true;
            cbDrone.Enabled = true;
        }

        #endregion

        #region Arduino

        private void btnConnect_Click(object sender, EventArgs e)
        {

            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.DtrEnable = true;
            port.DataReceived += port_DataReceived;
            port.Open();
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string sData;
            port.ReadTimeout = 20;
            try
            {
                sData = port.ReadExisting();
                this.BeginInvoke(new myDelegate(Text_Out), sData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }
        private void Text_Out(string sData)
        {
            richTextBox1.AppendText(sData);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Laps++;
            lblLaps.Text = Laps.ToString();
            AddTimeToListVieuw(lblLaps.Text, lblMilSec.Text);
            MilsecElapsed = 0;
        }

        #endregion
    }
}
