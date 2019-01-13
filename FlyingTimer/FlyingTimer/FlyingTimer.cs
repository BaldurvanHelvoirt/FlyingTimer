using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace FlyingTimer
{
    public partial class FlyingTimer : Form
    {
        Database DB = new Database();
        DataTable DT = new DataTable();
        DataTable DME = new DataTable();
        DataTable DMO = new DataTable();
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=flyingtimer; Uid=root; Pwd=;");
        private int Laps;
        private int Startime;
        private int MilSec;
        private int MilsecElapsed;
        private int Stoptime;
        public FlyingTimer()
        {
            InitializeComponent();
            GetDrones();
            Addheaders();
        }

        private void GetDrones()
        {
            MySqlCommand drone = new MySqlCommand("SELECT merk FROM drone", con);
            MySqlDataAdapter DRO = new MySqlDataAdapter(drone);
            DRO.Fill(DME);
            cbDrones.ValueMember = "merk";
            cbDrones.DisplayMember = "merk";
            cbDrones.DataSource = DME;
            con.Close();
        }
        private void cbDrones_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDroneModel(cbDrones.SelectedItem.ToString());
        }

        private void GetDroneModel(string drones)
        {
            MySqlCommand model = new MySqlCommand("SELECT model FROM drone WHERE merk = @drones", con);
            model.Parameters.AddWithValue("@drones", drones);
            MySqlDataAdapter MOD = new MySqlDataAdapter(model);
            MOD.Fill(DMO);
            cbModel.ValueMember = "model";
            cbModel.DisplayMember = "model";
            cbModel.DataSource = DMO;
            con.Close();
        }

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
            if (MilsecElapsed == 100)
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
            SaveLapTimes();
        }

        private void AddTimeToListVieuw(string laps, string time)
        {
            string[] row = { laps, time };
            var listViewItem = new ListViewItem(row);
            lvLaptimes.Items.Add(listViewItem);
        }

        private void SaveLapTimes()
        {
            foreach (ListViewItem item in lvLaptimes.Items)
            {
                con.Open();
                MySqlCommand Laptimes = new MySqlCommand("INSERT INTO time (racetrack_racetreckid, races_racesid, laps, time, date) VALUES (@trackid, @raceid, @laps, @time, @date)", con);
                //Laptimes.Parameters.Add("@trackid", lblRaceTrack.Text);
                //Laptimes.Parameters.Add("@racekid", lblRaceId.Text);
                Laptimes.Parameters.Add("@laps", item.Text);
                Laptimes.Parameters.Add("@time", item.Text);
                Laptimes.Parameters.Add("@date", DateTime.Today);
                Laptimes.ExecuteNonQuery();
            }
            con.Close();
        }

        private void HideTabs()
        {
            tcMain.Appearance = TabAppearance.FlatButtons;
            tcMain.ItemSize = new Size(0, 1);
            tcMain.SizeMode = TabSizeMode.Fixed;
        }

        private void Addheaders()
        {
            lvLaptimes.View = View.Details;
            lvLaptimes.FullRowSelect = true;

            //ADD COLUMNS
            lvLaptimes.Columns.Add("Laps", 150);
            lvLaptimes.Columns.Add("Time", 150);
        }
    }
}
