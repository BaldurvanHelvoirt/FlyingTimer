using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingTimer
{
    public partial class FlyingTimer : Form
    {
        public FlyingTimer()
        {
            InitializeComponent();
            tcMain.Appearance = TabAppearance.FlatButtons;
            tcMain.ItemSize = new Size(0, 1);
            tcMain.SizeMode = TabSizeMode.Fixed;
        }
    }
}
