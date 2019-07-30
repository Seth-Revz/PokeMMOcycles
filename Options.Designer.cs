namespace PokeMMOCycleGUI
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.msLabel = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.AnimatedSprits = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 17);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Exit";
            this.pictureBox1.Click += new System.EventHandler(this.exit_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Pokemon DP", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(33, 14);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(73, 25);
            this.Titre.TabIndex = 4;
            this.Titre.Text = "Options";
            this.Titre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Titre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PokeMMOCycleGUI.Properties.Resources.options;
            this.pictureBox2.Location = new System.Drawing.Point(10, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.BackColor = System.Drawing.Color.Transparent;
            this.intervalLabel.Font = new System.Drawing.Font("Pokemon DP", 12F);
            this.intervalLabel.ForeColor = System.Drawing.Color.White;
            this.intervalLabel.Location = new System.Drawing.Point(12, 84);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(296, 19);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "Select the interval of refreshment (1000ms = 1s)";
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.BackColor = System.Drawing.Color.Transparent;
            this.msLabel.Font = new System.Drawing.Font("Pokemon DP", 12F);
            this.msLabel.ForeColor = System.Drawing.Color.White;
            this.msLabel.Location = new System.Drawing.Point(107, 106);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(23, 19);
            this.msLabel.TabIndex = 9;
            this.msLabel.Text = "ms";
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.Transparent;
            this.Apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Apply.BackgroundImage")));
            this.Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Apply.Location = new System.Drawing.Point(219, 133);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(100, 27);
            this.Apply.TabIndex = 10;
            this.Apply.Text = "Apply setting";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // Interval
            // 
            this.Interval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PokeMMOCycleGUI.Properties.Settings.Default, "RefreshInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Interval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Interval.Location = new System.Drawing.Point(38, 106);
            this.Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(68, 20);
            this.Interval.TabIndex = 7;
            this.Interval.ThousandsSeparator = true;
            this.Interval.Value = global::PokeMMOCycleGUI.Properties.Settings.Default.RefreshInterval;
            this.Interval.ValueChanged += new System.EventHandler(this.interval_ValueChanged);
            // 
            // AnimatedSprits
            // 
            this.AnimatedSprits.AutoSize = true;
            this.AnimatedSprits.BackColor = System.Drawing.Color.Transparent;
            this.AnimatedSprits.Checked = global::PokeMMOCycleGUI.Properties.Settings.Default.AnimatedSprits;
            this.AnimatedSprits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnimatedSprits.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PokeMMOCycleGUI.Properties.Settings.Default, "AnimatedSprits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AnimatedSprits.Font = new System.Drawing.Font("Pokemon DP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimatedSprits.ForeColor = System.Drawing.Color.White;
            this.AnimatedSprits.Location = new System.Drawing.Point(12, 54);
            this.AnimatedSprits.Name = "AnimatedSprits";
            this.AnimatedSprits.Size = new System.Drawing.Size(141, 23);
            this.AnimatedSprits.TabIndex = 6;
            this.AnimatedSprits.Text = "Use Animated sprits";
            this.AnimatedSprits.UseVisualStyleBackColor = false;
            this.AnimatedSprits.CheckedChanged += new System.EventHandler(this.AnimatedSprits_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(329, 179);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.AnimatedSprits);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Options_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox AnimatedSprits;
        private System.Windows.Forms.NumericUpDown Interval;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Button Apply;
    }
}