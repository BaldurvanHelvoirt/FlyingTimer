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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tcMijnOverzicht = new System.Windows.Forms.TabPage();
            this.tcRacen = new System.Windows.Forms.TabPage();
            this.tcUitloggen = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tcMijnOverzicht);
            this.tcMain.Controls.Add(this.tcRacen);
            this.tcMain.Controls.Add(this.tcUitloggen);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Location = new System.Drawing.Point(13, 13);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(491, 411);
            this.tcMain.TabIndex = 0;
            // 
            // tcMijnOverzicht
            // 
            this.tcMijnOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tcMijnOverzicht.Name = "tcMijnOverzicht";
            this.tcMijnOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tcMijnOverzicht.Size = new System.Drawing.Size(483, 385);
            this.tcMijnOverzicht.TabIndex = 0;
            this.tcMijnOverzicht.Text = "Mijn Overzicht";
            this.tcMijnOverzicht.UseVisualStyleBackColor = true;
            // 
            // tcRacen
            // 
            this.tcRacen.Location = new System.Drawing.Point(4, 22);
            this.tcRacen.Name = "tcRacen";
            this.tcRacen.Padding = new System.Windows.Forms.Padding(3);
            this.tcRacen.Size = new System.Drawing.Size(483, 385);
            this.tcRacen.TabIndex = 1;
            this.tcRacen.Text = "Racen";
            this.tcRacen.UseVisualStyleBackColor = true;
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 385);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tcMijnOverzicht;
        private System.Windows.Forms.TabPage tcRacen;
        private System.Windows.Forms.TabPage tcUitloggen;
        private System.Windows.Forms.TabPage tabPage1;
    }
}