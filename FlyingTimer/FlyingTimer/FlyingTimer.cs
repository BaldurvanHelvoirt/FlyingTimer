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
            MySqlCommand Users = new MySqlCommand("SELECT * FROM drone", con);
            MySqlDataAdapter MAD = new MySqlDataAdapter(Users);
            MAD.Fill(DT);
            cbDrones.ValueMember = "merk";
            cbDrones.DisplayMember = "merk";
            cbDrones.DataSource = DT;
            /*
            foreach (DataRow Data in DT.Rows)
            {
                cbDrones.Items.Add(Data.ToString());
            }
            */
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
        }

        private void AddTimeToListVieuw(string laps, string time)
        {
            string[] row = { laps, time };
            var listViewItem = new ListViewItem(row);
            lvLaptimes.Items.Add(listViewItem);
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
