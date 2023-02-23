using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeMMOCycleGUI
{
    public partial class PokeMMO_Cycle : Form
    {
        // pour effectuer le décalage, il faut savoir à quel point de la fenetre on a cliqué
        private Point p;
        private int lastCycle = -1;
        public bool updatePics = false;



        public PokeMMO_Cycle()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Location = new Point(Location.X + e.Location.X - p.X, Location.Y + e.Location.Y - p.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void Update(object sender, EventArgs e)
        {
            PokeMMOCycle pokeCycle = new PokeMMOCycle();
            int cycle = pokeCycle.Cycle;
            CurrentCycle.Text = "Cycle " + cycle;
            TimeSpan timeLeftTS = pokeCycle.TimeLeft;
            TimeLeft.Text = String.Format("Time Left : {0:00}:{1:00}:{2:00}", timeLeftTS.Hours, timeLeftTS.Minutes, timeLeftTS.Seconds);


            if (cycle != lastCycle)
            {
                lastCycle = cycle;
                updatePics = true;
            }

            if(updatePics)
            {
                updatePics = false;
                // updating the list of pokemons to show

                String[,] PokemonList = pokeCycle.PokemonListCurrentCycle;
                int width = this.ClientSize.Width;
                int elmntWidth = (width) / PokemonList.GetLength(0);
                int padding = 5;

                // remove the pictures components from the frame
                Control[] Carray = new Control[this.Controls.Count];

                this.Controls.CopyTo(Carray, 0);
                foreach (Control c in Carray)
                {
                    if (c.Name.Contains("pokemonBox"))
                        this.Controls.Remove(c);
                }

                String extention;

                if (Properties.Settings.Default.AnimatedSprits)
                    extention = ".gif";
                else
                    extention = ".png";


                for(int i = 0; i < PokemonList.GetLength(0)-1; i++)
                {
                    System.Windows.Forms.PictureBox pictureBoxPKM;
                    pictureBoxPKM = new System.Windows.Forms.PictureBox();
                    pictureBoxPKM.Name = "pokemonBox" + (i+1);
                    //((System.ComponentModel.ISupportInitialize)(pictureBoxPKM)).BeginInit();

                    pictureBoxPKM.ErrorImage = global::PokeMMOCycleGUI.Properties.Resources.imageNotFound;
                    pictureBoxPKM.BackgroundImage = Image.FromFile("./resources/pokemonFrame.png");
                    pictureBoxPKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    pictureBoxPKM.Location = new System.Drawing.Point(padding + elmntWidth*i, 40);
                    pictureBoxPKM.Size = new System.Drawing.Size(elmntWidth - 5, elmntWidth + 8);
                    pictureBoxPKM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pictureBoxPKM.BringToFront();
                    pictureBoxPKM.BackColor = System.Drawing.Color.Transparent;
                    try
                    {
                        pictureBoxPKM.Image = Image.FromFile("./resources/" + PokemonList[i, 0] + extention);
                    }
                    catch
                    {
                        pictureBoxPKM.Image = Properties.Resources.imageNotFound;
                    }

                    pictureBoxPKM.Tag = PokemonList[i, 0] + "\nEncounter Rate : " + PokemonList[i, 1] + "% \nLevel : " + PokemonList[i, 2];

                    pictureBoxPKM.MouseHover += pictureBox_MouseHover;

                    this.Controls.Add(pictureBoxPKM);
                    //((System.ComponentModel.ISupportInitialize)(pictureBoxPKM)).EndInit();
                }

                //
                // Zubat
                // 
                System.Windows.Forms.PictureBox pictureBoxZubat;
                pictureBoxZubat = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(pictureBoxZubat)).BeginInit();

                pictureBoxZubat.Name = "pokemonBox0";
                pictureBoxZubat.ErrorImage = global::PokeMMOCycleGUI.Properties.Resources.imageNotFound;
                pictureBoxZubat.Location = new System.Drawing.Point(315, 7);
                pictureBoxZubat.Size = new System.Drawing.Size(40, 40);
                pictureBoxZubat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxZubat.BringToFront();
                pictureBoxZubat.BackColor = System.Drawing.Color.Transparent;
                try
                {
                    pictureBoxZubat.Image = Image.FromFile("./resources/" + PokemonList[PokemonList.GetLength(0) - 1, 0] + extention);
                }
                catch
                {
                    pictureBoxZubat.Image = Properties.Resources.imageNotFound;
                }
                pictureBoxZubat.Tag = "Zubat\nEncounter Rate : " + PokemonList[PokemonList.GetLength(0) - 1, 1] +
                    "% \nLevel : " + PokemonList[PokemonList.GetLength(0)-1, 2];

                pictureBoxZubat.MouseHover += pictureBox_MouseHover;

                this.Controls.Add(pictureBoxZubat);
                ((System.ComponentModel.ISupportInitialize)(pictureBoxZubat)).EndInit();
            }
        }


        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip((Control)sender, ((Control)sender).Tag.ToString());
        }

        private void Option_Click(object sender, EventArgs e)
        {
            Options o = new Options(this);
            o.Show();
        }

        public void SetRefreshTime(int interval)
        {
            this.timer.Interval = interval;
        }
    }
}
