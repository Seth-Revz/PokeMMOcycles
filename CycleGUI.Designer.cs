namespace PokeMMOCycleGUI
{
    partial class PokeMMO_Cycle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeMMO_Cycle));
            this.CurrentCycle = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentCycle
            // 
            this.CurrentCycle.AutoSize = true;
            this.CurrentCycle.BackColor = System.Drawing.Color.Transparent;
            this.CurrentCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CurrentCycle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentCycle.Location = new System.Drawing.Point(2, 9);
            this.CurrentCycle.Name = "CurrentCycle";
            this.CurrentCycle.Size = new System.Drawing.Size(92, 29);
            this.CurrentCycle.TabIndex = 0;
            this.CurrentCycle.Text = "Cycle 0";
            this.CurrentCycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentCycle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.CurrentCycle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimeLeft.Location = new System.Drawing.Point(111, 12);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeLeft.Size = new System.Drawing.Size(166, 24);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "Time left : 00:00:00";
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = global::PokeMMOCycleGUI.Properties.Settings.Default.RefreshInterval;
            this.timer.Tick += new System.EventHandler(this.Update);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokeMMOCycleGUI.Properties.Resources.escapeRope;
            this.pictureBox1.Location = new System.Drawing.Point(372, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 17);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Exit";
            this.pictureBox1.Click += new System.EventHandler(this.Exit_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PokeMMOCycleGUI.Properties.Resources.options;
            this.pictureBox2.Location = new System.Drawing.Point(372, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Options";
            this.pictureBox2.Click += new System.EventHandler(this.Option_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // PokeMMO_Cycle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.CurrentCycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PokeMMO_Cycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeMMO Cycle";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Update);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentCycle;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

