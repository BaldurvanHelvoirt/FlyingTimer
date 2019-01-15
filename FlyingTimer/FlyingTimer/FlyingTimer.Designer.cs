namespace FlyingTimer
{
    partial class FlyingTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tcMijnOverzicht = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRacetracks = new System.Windows.Forms.ComboBox();
            this.lvMijnOverzicht = new System.Windows.Forms.ListView();
            this.tcRacen = new System.Windows.Forms.TabPage();
            this.btnSelectSettings = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRacetrack = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDrone = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tcTimer = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lvLaptimes = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLaps = new System.Windows.Forms.Label();
            this.lblMilSec = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tcUitloggen = new System.Windows.Forms.TabPage();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.tcMain.SuspendLayout();
            this.tcMijnOverzicht.SuspendLayout();
            this.tcRacen.SuspendLayout();
            this.tcTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tcMijnOverzicht);
            this.tcMain.Controls.Add(this.tcRacen);
            this.tcMain.Controls.Add(this.tcTimer);
            this.tcMain.Controls.Add(this.tcUitloggen);
            this.tcMain.Location = new System.Drawing.Point(13, 13);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(491, 411);
            this.tcMain.TabIndex = 0;
            // 
            // tcMijnOverzicht
            // 
            this.tcMijnOverzicht.Controls.Add(this.label1);
            this.tcMijnOverzicht.Controls.Add(this.cbRacetracks);
            this.tcMijnOverzicht.Controls.Add(this.lvMijnOverzicht);
            this.tcMijnOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tcMijnOverzicht.Name = "tcMijnOverzicht";
            this.tcMijnOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tcMijnOverzicht.Size = new System.Drawing.Size(483, 385);
            this.tcMijnOverzicht.TabIndex = 0;
            this.tcMijnOverzicht.Text = "Mijn Overzicht";
            this.tcMijnOverzicht.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mijn Overzicht";
            // 
            // cbRacetracks
            // 
            this.cbRacetracks.FormattingEnabled = true;
            this.cbRacetracks.Location = new System.Drawing.Point(60, 72);
            this.cbRacetracks.Name = "cbRacetracks";
            this.cbRacetracks.Size = new System.Drawing.Size(121, 21);
            this.cbRacetracks.TabIndex = 1;
            this.cbRacetracks.SelectedIndexChanged += new System.EventHandler(this.cbDrones_SelectedIndexChanged);
            // 
            // lvMijnOverzicht
            // 
            this.lvMijnOverzicht.Location = new System.Drawing.Point(60, 111);
            this.lvMijnOverzicht.Name = "lvMijnOverzicht";
            this.lvMijnOverzicht.Size = new System.Drawing.Size(351, 240);
            this.lvMijnOverzicht.TabIndex = 0;
            this.lvMijnOverzicht.UseCompatibleStateImageBehavior = false;
            // 
            // tcRacen
            // 
            this.tcRacen.Controls.Add(this.btnSelectSettings);
            this.tcRacen.Controls.Add(this.label10);
            this.tcRacen.Controls.Add(this.cbRacetrack);
            this.tcRacen.Controls.Add(this.label9);
            this.tcRacen.Controls.Add(this.label8);
            this.tcRacen.Controls.Add(this.label7);
            this.tcRacen.Controls.Add(this.label6);
            this.tcRacen.Controls.Add(this.cbDrone);
            this.tcRacen.Controls.Add(this.cbCity);
            this.tcRacen.Controls.Add(this.cbState);
            this.tcRacen.Controls.Add(this.cbCountry);
            this.tcRacen.Controls.Add(this.label5);
            this.tcRacen.Location = new System.Drawing.Point(4, 22);
            this.tcRacen.Name = "tcRacen";
            this.tcRacen.Padding = new System.Windows.Forms.Padding(3);
            this.tcRacen.Size = new System.Drawing.Size(483, 385);
            this.tcRacen.TabIndex = 1;
            this.tcRacen.Text = "Race Settings";
            this.tcRacen.UseVisualStyleBackColor = true;
            // 
            // btnSelectSettings
            // 
            this.btnSelectSettings.Location = new System.Drawing.Point(147, 236);
            this.btnSelectSettings.Name = "btnSelectSettings";
            this.btnSelectSettings.Size = new System.Drawing.Size(121, 23);
            this.btnSelectSettings.TabIndex = 11;
            this.btnSelectSettings.Text = "Start Race";
            this.btnSelectSettings.UseVisualStyleBackColor = true;
            this.btnSelectSettings.Click += new System.EventHandler(this.btnSelectSettings_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Track:";
            // 
            // cbRacetrack
            // 
            this.cbRacetrack.FormattingEnabled = true;
            this.cbRacetrack.Location = new System.Drawing.Point(147, 181);
            this.cbRacetrack.Name = "cbRacetrack";
            this.cbRacetrack.Size = new System.Drawing.Size(121, 21);
            this.cbRacetrack.TabIndex = 9;
            this.cbRacetrack.SelectedIndexChanged += new System.EventHandler(this.cbRacetrack_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Drone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country:";
            // 
            // cbDrone
            // 
            this.cbDrone.FormattingEnabled = true;
            this.cbDrone.Location = new System.Drawing.Point(147, 208);
            this.cbDrone.Name = "cbDrone";
            this.cbDrone.Size = new System.Drawing.Size(121, 21);
            this.cbDrone.TabIndex = 4;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(147, 154);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 3;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(147, 127);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
            this.cbState.TabIndex = 2;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(147, 100);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 1;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Race Settings";
            // 
            // tcTimer
            // 
            this.tcTimer.Controls.Add(this.richTextBox1);
            this.tcTimer.Controls.Add(this.btnConnect);
            this.tcTimer.Controls.Add(this.lblUsername);
            this.tcTimer.Controls.Add(this.lvLaptimes);
            this.tcTimer.Controls.Add(this.label4);
            this.tcTimer.Controls.Add(this.label3);
            this.tcTimer.Controls.Add(this.lblLaps);
            this.tcTimer.Controls.Add(this.lblMilSec);
            this.tcTimer.Controls.Add(this.btnStop);
            this.tcTimer.Controls.Add(this.btnStart);
            this.tcTimer.Controls.Add(this.label2);
            this.tcTimer.Location = new System.Drawing.Point(4, 22);
            this.tcTimer.Name = "tcTimer";
            this.tcTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tcTimer.Size = new System.Drawing.Size(483, 385);
            this.tcTimer.TabIndex = 3;
            this.tcTimer.Text = "Timer";
            this.tcTimer.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(299, 329);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 40);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(56, 329);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 40);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 20);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "label10";
            // 
            // lvLaptimes
            // 
            this.lvLaptimes.FullRowSelect = true;
            this.lvLaptimes.GridLines = true;
            this.lvLaptimes.HideSelection = false;
            this.lvLaptimes.Location = new System.Drawing.Point(70, 54);
            this.lvLaptimes.Name = "lvLaptimes";
            this.lvLaptimes.Size = new System.Drawing.Size(305, 200);
            this.lvLaptimes.TabIndex = 13;
            this.lvLaptimes.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Laps:";
            // 
            // lblLaps
            // 
            this.lblLaps.AutoSize = true;
            this.lblLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaps.Location = new System.Drawing.Point(167, 257);
            this.lblLaps.Margin = new System.Windows.Forms.Padding(0);
            this.lblLaps.Name = "lblLaps";
            this.lblLaps.Size = new System.Drawing.Size(18, 20);
            this.lblLaps.TabIndex = 10;
            this.lblLaps.Text = "0";
            // 
            // lblMilSec
            // 
            this.lblMilSec.AutoSize = true;
            this.lblMilSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilSec.Location = new System.Drawing.Point(294, 257);
            this.lblMilSec.Margin = new System.Windows.Forms.Padding(0);
            this.lblMilSec.Name = "lblMilSec";
            this.lblMilSec.Size = new System.Drawing.Size(27, 20);
            this.lblMilSec.TabIndex = 9;
            this.lblMilSec.Text = "00";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(218, 329);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 40);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(137, 329);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laptimes - Current Session";
            // 
            // tcUitloggen
            // 
            this.tcUitloggen.Location = new System.Drawing.Point(4, 22);
            this.tcUitloggen.Name = "tcUitloggen";
            this.tcUitloggen.Padding = new System.Windows.Forms.Padding(3);
            this.tcUitloggen.Size = new System.Drawing.Size(483, 385);
            this.tcUitloggen.TabIndex = 2;
            this.tcUitloggen.Text = "Uitloggen";
            this.tcUitloggen.UseVisualStyleBackColor = true;
            // 
            // tmTime
            // 
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // FlyingTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 436);
            this.Controls.Add(this.tcMain);
            this.Name = "FlyingTimer";
            this.Text = "FlyingTimer";
            this.tcMain.ResumeLayout(false);
            this.tcMijnOverzicht.ResumeLayout(false);
            this.tcMijnOverzicht.PerformLayout();
            this.tcRacen.ResumeLayout(false);
            this.tcRacen.PerformLayout();
            this.tcTimer.ResumeLayout(false);
            this.tcTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tcMijnOverzicht;
        private System.Windows.Forms.TabPage tcRacen;
        private System.Windows.Forms.TabPage tcUitloggen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRacetracks;
        private System.Windows.Forms.ListView lvMijnOverzicht;
        private System.Windows.Forms.TabPage tcTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMilSec;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLaps;
        private System.Windows.Forms.ListView lvLaptimes;
        private System.Windows.Forms.ComboBox cbDrone;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRacetrack;
        private System.Windows.Forms.Button btnSelectSettings;
    }
}