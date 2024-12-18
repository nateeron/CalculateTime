namespace CalculateTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.in_timestamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.in_datetime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.in_Microsecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.in_Second = new System.Windows.Forms.TextBox();
            this.out_timestamp = new System.Windows.Forms.TextBox();
            this.out_datetime = new System.Windows.Forms.TextBox();
            this.out_microsecond = new System.Windows.Forms.TextBox();
            this.out_Second = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.in_minutes = new System.Windows.Forms.TextBox();
            this.out_minutes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.in_timestamp_Full = new System.Windows.Forms.TextBox();
            this.out_timestamp_Full = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CB_in_timestamp_Full = new System.Windows.Forms.CheckBox();
            this.CB_in_timestamp = new System.Windows.Forms.CheckBox();
            this.out_timestamp_Full7 = new System.Windows.Forms.TextBox();
            this.out_timestamp7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // in_timestamp
            // 
            this.in_timestamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_timestamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.in_timestamp.Location = new System.Drawing.Point(235, 87);
            this.in_timestamp.Name = "in_timestamp";
            this.in_timestamp.Size = new System.Drawing.Size(132, 23);
            this.in_timestamp.TabIndex = 0;
            this.in_timestamp.TextChanged += new System.EventHandler(this.in_timestamp_TextChanged);
            this.in_timestamp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.in_timestamp_KeyDown);
            this.in_timestamp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.in_timestamp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TimeStamp :";
            // 
            // in_datetime
            // 
            this.in_datetime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_datetime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.in_datetime.Location = new System.Drawing.Point(235, 116);
            this.in_datetime.Name = "in_datetime";
            this.in_datetime.Size = new System.Drawing.Size(132, 23);
            this.in_datetime.TabIndex = 0;
            this.in_datetime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.in_datetime_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DateTime  d/M/yyyy H:mm:ss :";
            // 
            // in_Microsecond
            // 
            this.in_Microsecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_Microsecond.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.in_Microsecond.Location = new System.Drawing.Point(235, 145);
            this.in_Microsecond.Name = "in_Microsecond";
            this.in_Microsecond.Size = new System.Drawing.Size(132, 23);
            this.in_Microsecond.TabIndex = 0;
            this.in_Microsecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.in_Microsecond_KeyDown);
            this.in_Microsecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.in_Microsecond_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Microsecond 86400000000:1D :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(103, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Second 86400:1D :";
            // 
            // in_Second
            // 
            this.in_Second.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_Second.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.in_Second.Location = new System.Drawing.Point(235, 174);
            this.in_Second.Name = "in_Second";
            this.in_Second.Size = new System.Drawing.Size(132, 23);
            this.in_Second.TabIndex = 2;
            this.in_Second.KeyDown += new System.Windows.Forms.KeyEventHandler(this.in_Second_KeyDown);
            this.in_Second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.in_Second_KeyPress);
            // 
            // out_timestamp
            // 
            this.out_timestamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_timestamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_timestamp.Location = new System.Drawing.Point(373, 88);
            this.out_timestamp.Name = "out_timestamp";
            this.out_timestamp.ReadOnly = true;
            this.out_timestamp.Size = new System.Drawing.Size(147, 23);
            this.out_timestamp.TabIndex = 0;
            // 
            // out_datetime
            // 
            this.out_datetime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_datetime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_datetime.Location = new System.Drawing.Point(373, 117);
            this.out_datetime.Name = "out_datetime";
            this.out_datetime.ReadOnly = true;
            this.out_datetime.Size = new System.Drawing.Size(147, 23);
            this.out_datetime.TabIndex = 0;
            // 
            // out_microsecond
            // 
            this.out_microsecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_microsecond.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_microsecond.Location = new System.Drawing.Point(373, 146);
            this.out_microsecond.Name = "out_microsecond";
            this.out_microsecond.ReadOnly = true;
            this.out_microsecond.Size = new System.Drawing.Size(147, 23);
            this.out_microsecond.TabIndex = 0;
            // 
            // out_Second
            // 
            this.out_Second.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_Second.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_Second.Location = new System.Drawing.Point(373, 175);
            this.out_Second.Name = "out_Second";
            this.out_Second.ReadOnly = true;
            this.out_Second.Size = new System.Drawing.Size(147, 23);
            this.out_Second.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(522, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(522, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Day";
            // 
            // in_minutes
            // 
            this.in_minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_minutes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.in_minutes.Location = new System.Drawing.Point(235, 203);
            this.in_minutes.Name = "in_minutes";
            this.in_minutes.Size = new System.Drawing.Size(132, 23);
            this.in_minutes.TabIndex = 2;
            this.in_minutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // out_minutes
            // 
            this.out_minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_minutes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_minutes.Location = new System.Drawing.Point(373, 204);
            this.out_minutes.Name = "out_minutes";
            this.out_minutes.ReadOnly = true;
            this.out_minutes.Size = new System.Drawing.Size(147, 23);
            this.out_minutes.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(103, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Minutes  1440:1D :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(522, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Day";
            // 
            // in_timestamp_Full
            // 
            this.in_timestamp_Full.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_timestamp_Full.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.in_timestamp_Full.Location = new System.Drawing.Point(235, 32);
            this.in_timestamp_Full.Name = "in_timestamp_Full";
            this.in_timestamp_Full.Size = new System.Drawing.Size(132, 23);
            this.in_timestamp_Full.TabIndex = 0;
            this.in_timestamp_Full.TextChanged += new System.EventHandler(this.in_timestamp_Full_TextChanged);
            this.in_timestamp_Full.KeyDown += new System.Windows.Forms.KeyEventHandler(this.in_timestamp_Full_KeyDown);
            this.in_timestamp_Full.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.in_timestamp_Full_KeyPress);
            // 
            // out_timestamp_Full
            // 
            this.out_timestamp_Full.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_timestamp_Full.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_timestamp_Full.Location = new System.Drawing.Point(373, 33);
            this.out_timestamp_Full.Name = "out_timestamp_Full";
            this.out_timestamp_Full.ReadOnly = true;
            this.out_timestamp_Full.Size = new System.Drawing.Size(147, 23);
            this.out_timestamp_Full.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(140, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "TimeStamp :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(235, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "1734537808000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(235, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "1734537808";
            // 
            // CB_in_timestamp_Full
            // 
            this.CB_in_timestamp_Full.AutoSize = true;
            this.CB_in_timestamp_Full.Checked = true;
            this.CB_in_timestamp_Full.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_in_timestamp_Full.Location = new System.Drawing.Point(526, 38);
            this.CB_in_timestamp_Full.Name = "CB_in_timestamp_Full";
            this.CB_in_timestamp_Full.Size = new System.Drawing.Size(15, 14);
            this.CB_in_timestamp_Full.TabIndex = 4;
            this.CB_in_timestamp_Full.UseVisualStyleBackColor = true;
            // 
            // CB_in_timestamp
            // 
            this.CB_in_timestamp.AutoSize = true;
            this.CB_in_timestamp.Checked = true;
            this.CB_in_timestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_in_timestamp.Location = new System.Drawing.Point(526, 93);
            this.CB_in_timestamp.Name = "CB_in_timestamp";
            this.CB_in_timestamp.Size = new System.Drawing.Size(15, 14);
            this.CB_in_timestamp.TabIndex = 4;
            this.CB_in_timestamp.UseVisualStyleBackColor = true;
            // 
            // out_timestamp_Full7
            // 
            this.out_timestamp_Full7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_timestamp_Full7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_timestamp_Full7.Location = new System.Drawing.Point(373, 6);
            this.out_timestamp_Full7.Name = "out_timestamp_Full7";
            this.out_timestamp_Full7.ReadOnly = true;
            this.out_timestamp_Full7.Size = new System.Drawing.Size(147, 23);
            this.out_timestamp_Full7.TabIndex = 0;
            // 
            // out_timestamp7
            // 
            this.out_timestamp7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.out_timestamp7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.out_timestamp7.Location = new System.Drawing.Point(373, 61);
            this.out_timestamp7.Name = "out_timestamp7";
            this.out_timestamp7.ReadOnly = true;
            this.out_timestamp7.Size = new System.Drawing.Size(147, 23);
            this.out_timestamp7.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(522, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "+7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(526, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "+7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 254);
            this.Controls.Add(this.CB_in_timestamp);
            this.Controls.Add(this.CB_in_timestamp_Full);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.out_minutes);
            this.Controls.Add(this.out_Second);
            this.Controls.Add(this.in_minutes);
            this.Controls.Add(this.in_Second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.out_microsecond);
            this.Controls.Add(this.in_Microsecond);
            this.Controls.Add(this.out_datetime);
            this.Controls.Add(this.out_timestamp_Full7);
            this.Controls.Add(this.out_timestamp_Full);
            this.Controls.Add(this.out_timestamp7);
            this.Controls.Add(this.out_timestamp);
            this.Controls.Add(this.in_timestamp_Full);
            this.Controls.Add(this.in_datetime);
            this.Controls.Add(this.in_timestamp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CalculateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox in_timestamp;
        private Label label1;
        private TextBox in_datetime;
        private Label label2;
        private TextBox in_Microsecond;
        private Label label3;
        private Label label4;
        private TextBox in_Second;
        private TextBox out_timestamp;
        private TextBox out_datetime;
        private TextBox out_microsecond;
        private TextBox out_Second;
        private Label label5;
        private Label label6;
        private TextBox in_minutes;
        private TextBox out_minutes;
        private Label label7;
        private Label label8;
        private TextBox in_timestamp_Full;
        private TextBox out_timestamp_Full;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox CB_in_timestamp_Full;
        private CheckBox CB_in_timestamp;
        private TextBox out_timestamp_Full7;
        private TextBox out_timestamp7;
        private Label label12;
        private Label label13;
    }
}