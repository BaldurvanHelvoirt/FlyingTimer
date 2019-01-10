﻿namespace FlyingTimer
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
            this.cbDrones = new System.Windows.Forms.ComboBox();
            this.lv = new System.Windows.Forms.ListView();
            this.tcRacen = new System.Windows.Forms.TabPage();
            this.tcTimer = new System.Windows.Forms.TabPage();
            this.lblMilSec = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tcUitloggen = new System.Windows.Forms.TabPage();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.lblLaps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvLaptimes = new System.Windows.Forms.ListView();
            this.tcMain.SuspendLayout();
            this.tcMijnOverzicht.SuspendLayout();
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
            this.tcMijnOverzicht.Controls.Add(this.cbDrones);
            this.tcMijnOverzicht.Controls.Add(this.lv);
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
            // cbDrones
            // 
            this.cbDrones.FormattingEnabled = true;
            this.cbDrones.Location = new System.Drawing.Point(60, 72);
            this.cbDrones.Name = "cbDrones";
            this.cbDrones.Size = new System.Drawing.Size(121, 21);
            this.cbDrones.TabIndex = 1;
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(60, 111);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(351, 240);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // tcRacen
            // 
            this.tcRacen.Location = new System.Drawing.Point(4, 22);
            this.tcRacen.Name = "tcRacen";
            this.tcRacen.Padding = new System.Windows.Forms.Padding(3);
            this.tcRacen.Size = new System.Drawing.Size(483, 385);
            this.tcRacen.TabIndex = 1;
            this.tcRacen.Text = "Race Settings";
            this.tcRacen.UseVisualStyleBackColor = true;
            // 
            // tcTimer
            // 
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
        private System.Windows.Forms.ComboBox cbDrones;
        private System.Windows.Forms.ListView lv;
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
    }
}