namespace WeatherForecast
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.City_lbl = new System.Windows.Forms.Label();
            this.City_txtbox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Condition_lbl = new System.Windows.Forms.Label();
            this.Details_lbl = new System.Windows.Forms.Label();
            this.Sunrise_lbl = new System.Windows.Forms.Label();
            this.Sunset_lbl = new System.Windows.Forms.Label();
            this.SunriseValue_lbl = new System.Windows.Forms.Label();
            this.SunsetValues_lbl = new System.Windows.Forms.Label();
            this.PressureValues_Lbl = new System.Windows.Forms.Label();
            this.WindSpeedValues_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WindSpeed_lbl = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.Showing_lbl = new System.Windows.Forms.Label();
            this.ShowingCityValues_lbl = new System.Windows.Forms.Label();
            this.Temp_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // City_lbl
            // 
            this.City_lbl.AutoSize = true;
            this.City_lbl.BackColor = System.Drawing.Color.Transparent;
            this.City_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.City_lbl.Location = new System.Drawing.Point(53, 15);
            this.City_lbl.Name = "City_lbl";
            this.City_lbl.Size = new System.Drawing.Size(49, 27);
            this.City_lbl.TabIndex = 0;
            this.City_lbl.Text = "City";
            this.City_lbl.Click += new System.EventHandler(this.City_lbl_Click);
            // 
            // City_txtbox
            // 
            this.City_txtbox.Location = new System.Drawing.Point(108, 22);
            this.City_txtbox.Name = "City_txtbox";
            this.City_txtbox.Size = new System.Drawing.Size(189, 20);
            this.City_txtbox.TabIndex = 1;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.Transparent;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(303, 16);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(74, 29);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Condition_lbl
            // 
            this.Condition_lbl.AutoSize = true;
            this.Condition_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Condition_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Condition_lbl.Location = new System.Drawing.Point(188, 150);
            this.Condition_lbl.Name = "Condition_lbl";
            this.Condition_lbl.Size = new System.Drawing.Size(94, 27);
            this.Condition_lbl.TabIndex = 3;
            this.Condition_lbl.Text = "Condition";
            // 
            // Details_lbl
            // 
            this.Details_lbl.AutoSize = true;
            this.Details_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Details_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Details_lbl.Location = new System.Drawing.Point(188, 186);
            this.Details_lbl.Name = "Details_lbl";
            this.Details_lbl.Size = new System.Drawing.Size(76, 27);
            this.Details_lbl.TabIndex = 4;
            this.Details_lbl.Text = "Details";
            // 
            // Sunrise_lbl
            // 
            this.Sunrise_lbl.AutoSize = true;
            this.Sunrise_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Sunrise_lbl.Location = new System.Drawing.Point(23, 318);
            this.Sunrise_lbl.Name = "Sunrise_lbl";
            this.Sunrise_lbl.Size = new System.Drawing.Size(95, 27);
            this.Sunrise_lbl.TabIndex = 5;
            this.Sunrise_lbl.Text = "Sunrise :";
            this.Sunrise_lbl.Click += new System.EventHandler(this.Sunrise_lbl_Click);
            // 
            // Sunset_lbl
            // 
            this.Sunset_lbl.AutoSize = true;
            this.Sunset_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Sunset_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Sunset_lbl.Location = new System.Drawing.Point(26, 351);
            this.Sunset_lbl.Name = "Sunset_lbl";
            this.Sunset_lbl.Size = new System.Drawing.Size(90, 27);
            this.Sunset_lbl.TabIndex = 6;
            this.Sunset_lbl.Text = "Sunset :";
            // 
            // SunriseValue_lbl
            // 
            this.SunriseValue_lbl.AutoSize = true;
            this.SunriseValue_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SunriseValue_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunriseValue_lbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseValue_lbl.ForeColor = System.Drawing.Color.White;
            this.SunriseValue_lbl.Location = new System.Drawing.Point(124, 329);
            this.SunriseValue_lbl.Name = "SunriseValue_lbl";
            this.SunriseValue_lbl.Size = new System.Drawing.Size(26, 13);
            this.SunriseValue_lbl.TabIndex = 7;
            this.SunriseValue_lbl.Text = "N/A";
            this.SunriseValue_lbl.Click += new System.EventHandler(this.SunriseValue_lbl_Click);
            // 
            // SunsetValues_lbl
            // 
            this.SunsetValues_lbl.AutoSize = true;
            this.SunsetValues_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SunsetValues_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunsetValues_lbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetValues_lbl.ForeColor = System.Drawing.Color.White;
            this.SunsetValues_lbl.Location = new System.Drawing.Point(122, 362);
            this.SunsetValues_lbl.Name = "SunsetValues_lbl";
            this.SunsetValues_lbl.Size = new System.Drawing.Size(26, 13);
            this.SunsetValues_lbl.TabIndex = 8;
            this.SunsetValues_lbl.Text = "N/A";
            // 
            // PressureValues_Lbl
            // 
            this.PressureValues_Lbl.AutoSize = true;
            this.PressureValues_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.PressureValues_Lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PressureValues_Lbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureValues_Lbl.ForeColor = System.Drawing.Color.White;
            this.PressureValues_Lbl.Location = new System.Drawing.Point(337, 370);
            this.PressureValues_Lbl.Name = "PressureValues_Lbl";
            this.PressureValues_Lbl.Size = new System.Drawing.Size(26, 13);
            this.PressureValues_Lbl.TabIndex = 12;
            this.PressureValues_Lbl.Text = "N/A";
            this.PressureValues_Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // WindSpeedValues_lbl
            // 
            this.WindSpeedValues_lbl.AutoSize = true;
            this.WindSpeedValues_lbl.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedValues_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindSpeedValues_lbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedValues_lbl.ForeColor = System.Drawing.Color.White;
            this.WindSpeedValues_lbl.Location = new System.Drawing.Point(337, 340);
            this.WindSpeedValues_lbl.Name = "WindSpeedValues_lbl";
            this.WindSpeedValues_lbl.Size = new System.Drawing.Size(26, 13);
            this.WindSpeedValues_lbl.TabIndex = 11;
            this.WindSpeedValues_lbl.Text = "N/A";
            this.WindSpeedValues_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(201, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pressure :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // WindSpeed_lbl
            // 
            this.WindSpeed_lbl.AutoSize = true;
            this.WindSpeed_lbl.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeed_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeed_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.WindSpeed_lbl.Location = new System.Drawing.Point(201, 329);
            this.WindSpeed_lbl.Name = "WindSpeed_lbl";
            this.WindSpeed_lbl.Size = new System.Drawing.Size(130, 27);
            this.WindSpeed_lbl.TabIndex = 9;
            this.WindSpeed_lbl.Text = "Wind Speed:";
            this.WindSpeed_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(23, 150);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(150, 120);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // Showing_lbl
            // 
            this.Showing_lbl.AutoSize = true;
            this.Showing_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Showing_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showing_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Showing_lbl.Location = new System.Drawing.Point(11, 74);
            this.Showing_lbl.Name = "Showing_lbl";
            this.Showing_lbl.Size = new System.Drawing.Size(172, 23);
            this.Showing_lbl.TabIndex = 14;
            this.Showing_lbl.Text = "Current Weather At";
            // 
            // ShowingCityValues_lbl
            // 
            this.ShowingCityValues_lbl.AutoSize = true;
            this.ShowingCityValues_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ShowingCityValues_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowingCityValues_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowingCityValues_lbl.ForeColor = System.Drawing.Color.White;
            this.ShowingCityValues_lbl.Location = new System.Drawing.Point(189, 78);
            this.ShowingCityValues_lbl.Name = "ShowingCityValues_lbl";
            this.ShowingCityValues_lbl.Size = new System.Drawing.Size(36, 19);
            this.ShowingCityValues_lbl.TabIndex = 15;
            this.ShowingCityValues_lbl.Text = "N/A";
            // 
            // Temp_lbl
            // 
            this.Temp_lbl.AutoSize = true;
            this.Temp_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Temp_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Temp_lbl.Location = new System.Drawing.Point(188, 222);
            this.Temp_lbl.Name = "Temp_lbl";
            this.Temp_lbl.Size = new System.Drawing.Size(131, 27);
            this.Temp_lbl.TabIndex = 16;
            this.Temp_lbl.Text = "Temperature";
            this.Temp_lbl.Click += new System.EventHandler(this.Temp_lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 432);
            this.Controls.Add(this.Temp_lbl);
            this.Controls.Add(this.ShowingCityValues_lbl);
            this.Controls.Add(this.Showing_lbl);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.PressureValues_Lbl);
            this.Controls.Add(this.WindSpeedValues_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WindSpeed_lbl);
            this.Controls.Add(this.SunsetValues_lbl);
            this.Controls.Add(this.SunriseValue_lbl);
            this.Controls.Add(this.Sunset_lbl);
            this.Controls.Add(this.Sunrise_lbl);
            this.Controls.Add(this.Details_lbl);
            this.Controls.Add(this.Condition_lbl);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.City_txtbox);
            this.Controls.Add(this.City_lbl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label City_lbl;
        private System.Windows.Forms.TextBox City_txtbox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label Condition_lbl;
        private System.Windows.Forms.Label Details_lbl;
        private System.Windows.Forms.Label Sunrise_lbl;
        private System.Windows.Forms.Label Sunset_lbl;
        private System.Windows.Forms.Label SunriseValue_lbl;
        private System.Windows.Forms.Label SunsetValues_lbl;
        private System.Windows.Forms.Label PressureValues_Lbl;
        private System.Windows.Forms.Label WindSpeedValues_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WindSpeed_lbl;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label Showing_lbl;
        private System.Windows.Forms.Label ShowingCityValues_lbl;
        private System.Windows.Forms.Label Temp_lbl;
    }
}

