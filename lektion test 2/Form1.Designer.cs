namespace lektion_test_2
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
            this.Startdatum = new System.Windows.Forms.Label();
            this.AntalPoang = new System.Windows.Forms.Label();
            this.Slutdatum = new System.Windows.Forms.Label();
            this.Kursnamn = new System.Windows.Forms.Label();
            this.Visa = new System.Windows.Forms.Button();
            this.Beraknapoang = new System.Windows.Forms.Button();
            this.Berakna = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.StartDatumLabel = new System.Windows.Forms.DateTimePicker();
            this.SlutDatumLabel = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Startdatum
            // 
            this.Startdatum.AutoSize = true;
            this.Startdatum.Location = new System.Drawing.Point(75, 154);
            this.Startdatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Startdatum.Name = "Startdatum";
            this.Startdatum.Size = new System.Drawing.Size(60, 13);
            this.Startdatum.TabIndex = 0;
            this.Startdatum.Text = "StartDatum";
            // 
            // AntalPoang
            // 
            this.AntalPoang.AutoSize = true;
            this.AntalPoang.Location = new System.Drawing.Point(75, 106);
            this.AntalPoang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AntalPoang.Name = "AntalPoang";
            this.AntalPoang.Size = new System.Drawing.Size(65, 13);
            this.AntalPoang.TabIndex = 1;
            this.AntalPoang.Text = "Antal Poäng";
            // 
            // Slutdatum
            // 
            this.Slutdatum.AutoSize = true;
            this.Slutdatum.Location = new System.Drawing.Point(75, 207);
            this.Slutdatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Slutdatum.Name = "Slutdatum";
            this.Slutdatum.Size = new System.Drawing.Size(54, 13);
            this.Slutdatum.TabIndex = 2;
            this.Slutdatum.Text = "Slutdatum";
            // 
            // Kursnamn
            // 
            this.Kursnamn.AutoSize = true;
            this.Kursnamn.Location = new System.Drawing.Point(75, 44);
            this.Kursnamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kursnamn.Name = "Kursnamn";
            this.Kursnamn.Size = new System.Drawing.Size(54, 13);
            this.Kursnamn.TabIndex = 3;
            this.Kursnamn.Text = "Kursnamn";
            this.Kursnamn.Click += new System.EventHandler(this.label4_Click);
            // 
            // Visa
            // 
            this.Visa.Location = new System.Drawing.Point(133, 268);
            this.Visa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Visa.Name = "Visa";
            this.Visa.Size = new System.Drawing.Size(100, 31);
            this.Visa.TabIndex = 4;
            this.Visa.Text = "Visa";
            this.Visa.UseVisualStyleBackColor = true;
            this.Visa.Click += new System.EventHandler(this.VisaClick);
            // 
            // Beraknapoang
            // 
            this.Beraknapoang.Location = new System.Drawing.Point(270, 268);
            this.Beraknapoang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Beraknapoang.Name = "Beraknapoang";
            this.Beraknapoang.Size = new System.Drawing.Size(100, 31);
            this.Beraknapoang.TabIndex = 5;
            this.Beraknapoang.Text = "Beräkna Poäng";
            this.Beraknapoang.UseVisualStyleBackColor = true;
            this.Beraknapoang.Click += new System.EventHandler(this.Beraknapoang_Click);
            // 
            // Berakna
            // 
            this.Berakna.Location = new System.Drawing.Point(418, 268);
            this.Berakna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Berakna.Name = "Berakna";
            this.Berakna.Size = new System.Drawing.Size(86, 31);
            this.Berakna.TabIndex = 6;
            this.Berakna.Text = "Beräkna";
            this.Berakna.UseVisualStyleBackColor = true;
            this.Berakna.Click += new System.EventHandler(this.Berakna_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 102);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 8;
            // 
            // StartDatumLabel
            // 
            this.StartDatumLabel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatumLabel.Location = new System.Drawing.Point(235, 149);
            this.StartDatumLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartDatumLabel.Name = "StartDatumLabel";
            this.StartDatumLabel.Size = new System.Drawing.Size(151, 20);
            this.StartDatumLabel.TabIndex = 9;
            // 
            // SlutDatumLabel
            // 
            this.SlutDatumLabel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SlutDatumLabel.Location = new System.Drawing.Point(235, 202);
            this.SlutDatumLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SlutDatumLabel.Name = "SlutDatumLabel";
            this.SlutDatumLabel.Size = new System.Drawing.Size(151, 20);
            this.SlutDatumLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SlutDatumLabel);
            this.Controls.Add(this.StartDatumLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Berakna);
            this.Controls.Add(this.Beraknapoang);
            this.Controls.Add(this.Visa);
            this.Controls.Add(this.Kursnamn);
            this.Controls.Add(this.Slutdatum);
            this.Controls.Add(this.AntalPoang);
            this.Controls.Add(this.Startdatum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Startdatum;
        private System.Windows.Forms.Label AntalPoang;
        private System.Windows.Forms.Label Slutdatum;
        private System.Windows.Forms.Label Kursnamn;
        private System.Windows.Forms.Button Visa;
        private System.Windows.Forms.Button Beraknapoang;
        private System.Windows.Forms.Button Berakna;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker StartDatumLabel;
        private System.Windows.Forms.DateTimePicker SlutDatumLabel;
    }
}

