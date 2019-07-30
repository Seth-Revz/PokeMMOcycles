using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeMMOCycleGUI
{
    public partial class Options : Form
    {
        private Point p;
        private PokeMMO_Cycle parent;


        public Options(PokeMMO_Cycle p)
        {
            parent = p;
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Location = new Point(Location.X + e.Location.X - p.X, Location.Y + e.Location.Y - p.Y);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Close();
        }

        private void AnimatedSprits_CheckedChanged(object sender, EventArgs e)
        {
            parent.updatePics = true;
        }

        private void interval_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RefreshInterval = (int)this.Interval.Value;
            parent.SetRefreshTime((int)this.Interval.Value);

        }

        private void apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
