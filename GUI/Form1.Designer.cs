namespace ServoController
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
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Servo1 = new System.Windows.Forms.TrackBar();
            this.Servo2 = new System.Windows.Forms.TrackBar();
            this.Servo3 = new System.Windows.Forms.TrackBar();
            this.Servo6 = new System.Windows.Forms.TrackBar();
            this.Servo5 = new System.Windows.Forms.TrackBar();
            this.Servo4 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(13, 13);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 9;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(140, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(74, 22);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(169, 406);
            this.SpeedBar.Maximum = 5;
            this.SpeedBar.Minimum = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(139, 45);
            this.SpeedBar.TabIndex = 10;
            this.SpeedBar.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Snelheid";
            // 
            // Servo1
            // 
            this.Servo1.Location = new System.Drawing.Point(47, 89);
            this.Servo1.Maximum = 180;
            this.Servo1.Name = "Servo1";
            this.Servo1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Servo1.Size = new System.Drawing.Size(45, 214);
            this.Servo1.TabIndex = 0;
            this.Servo1.Value = 90;
            this.Servo1.ValueChanged += new System.EventHandler(this.Servo1_ValueChanged);
            // 
            // Servo2
            // 
            this.Servo2.Location = new System.Drawing.Point(107, 89);
            this.Servo2.Maximum = 180;
            this.Servo2.Name = "Servo2";
            this.Servo2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Servo2.Size = new System.Drawing.Size(45, 214);
            this.Servo2.TabIndex = 1;
            this.Servo2.Value = 90;
            this.Servo2.ValueChanged += new System.EventHandler(this.Servo2_ValueChanged);
            // 
            // Servo3
            // 
            this.Servo3.Location = new System.Drawing.Point(169, 89);
            this.Servo3.Maximum = 180;
            this.Servo3.Name = "Servo3";
            this.Servo3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Servo3.Size = new System.Drawing.Size(45, 214);
            this.Servo3.TabIndex = 2;
            this.Servo3.Value = 90;
            this.Servo3.ValueChanged += new System.EventHandler(this.Servo3_ValueChanged);
            // 
            // Servo6
            // 
            this.Servo6.Location = new System.Drawing.Point(372, 89);
            this.Servo6.Maximum = 110;
            this.Servo6.Minimum = 70;
            this.Servo6.Name = "Servo6";
            this.Servo6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Servo6.Size = new System.Drawing.Size(45, 214);
            this.Servo6.TabIndex = 6;
            this.Servo6.Value = 90;
            this.Servo6.ValueChanged += new System.EventHandler(this.Servo6_ValueChanged);
            // 
            // Servo5
            // 
            this.Servo5.BackColor = System.Drawing.SystemColors.Control;
            this.Servo5.Location = new System.Drawing.Point(306, 89);
            this.Servo5.Maximum = 180;
            this.Servo5.Name = "Servo5";
            this.Servo5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Servo5.Size = new System.Drawing.Size(45, 214);
            this.Servo5.TabIndex = 5;
            this.Servo5.Value = 90;
            this.Servo5.ValueChanged += new System.EventHandler(this.Servo5_ValueChanged);
            // 
            // Servo4
            // 
            this.Servo4.Location = new System.Drawing.Point(235, 89);
            this.Servo4.Maximum = 180;
            this.Servo4.Name = "Servo4";
            this.Servo4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Servo4.Size = new System.Drawing.Size(45, 214);
            this.Servo4.TabIndex = 3;
            this.Servo4.Value = 90;
            this.Servo4.ValueChanged += new System.EventHandler(this.Servo4_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label2.Location = new System.Drawing.Point(167, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Servos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "6";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(17, 406);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 45);
            this.ResetButton.TabIndex = 17;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 234);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Run_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Reverse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Reverse_MouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(423, 330);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ms";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Remove_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(657, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(575, 41);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 26;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Servo4);
            this.Controls.Add(this.Servo5);
            this.Controls.Add(this.Servo6);
            this.Controls.Add(this.Servo3);
            this.Controls.Add(this.Servo2);
            this.Controls.Add(this.Servo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.cmbSerialPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Servo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Servo1;
        private System.Windows.Forms.TrackBar Servo2;
        private System.Windows.Forms.TrackBar Servo3;
        private System.Windows.Forms.TrackBar Servo6;
        private System.Windows.Forms.TrackBar Servo5;
        private System.Windows.Forms.TrackBar Servo4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

