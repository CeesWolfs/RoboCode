using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ServoController
{
    public partial class Form1 : Form
    {
        public SerialClass ComPort;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "1";
            dataGridView1.Columns[1].Name = "2";
            dataGridView1.Columns[2].Name = "3";
            dataGridView1.Columns[3].Name = "4";
            dataGridView1.Columns[4].Name = "5";
            dataGridView1.Columns[5].Name = "6";
            for(int x = 0; x < 6; x++)
            {
                dataGridView1.Columns[x].Width = 45;
            }
            dataGridView1.AllowUserToAddRows = false;
            this.Load += Form1_Load;
            this.KeyPreview = true;
            ComPort = new SerialClass("", 0);
        }
        void Form1_Load(object sender, EventArgs e)
        {
            var ports = System.IO.Ports.SerialPort.GetPortNames();
            cmbSerialPorts.DataSource = ports;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbSerialPorts.SelectedIndex > -1)
            { 
                Connect(cmbSerialPorts.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
        }

        private void Connect(string v)
        {
            ComPort.name = v;
            ComPort.Baudrate = 9600;
            ComPort.Open();
            if (!ComPort.IsOpen)
            {
                MessageBox.Show("Error cannot connect with serial port");
                return;
            }
            ComPort.Open();
            ResetButton.PerformClick();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //herstel alle waardes naar 90 de stansaard waarde
            Servo1.Value = 90;
            Servo2.Value = 90;
            Servo3.Value = 90;
            Servo4.Value = 90;
            Servo5.Value = 90;
            Servo6.Value = 90;
            System.Threading.Thread.Sleep(2000); //geef de servo's tijd om terug te keren
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //lees de gedrukte toets af en zet de juiste waardes voor de servos
            switch (e.KeyCode)
            {
                case Keys.Q:
                    if (Servo1.Value + SpeedBar.Value < Servo1.Maximum)
                    {
                        Servo1.Value += SpeedBar.Value;
                    }
                    else
                    {
                        Servo1.Value = Servo1.Maximum;
                    }
                    break;
                case Keys.A:
                    if (Servo1.Value - SpeedBar.Value > Servo1.Minimum)
                    {
                        Servo1.Value -= SpeedBar.Value;
                    }
                    else
                    {
                        Servo1.Value = Servo1.Minimum;
                    }
                    break;
                case Keys.W:
                    if (Servo2.Value + SpeedBar.Value < Servo2.Maximum)
                    {
                        Servo2.Value += SpeedBar.Value;
                    }
                    else
                    {
                        Servo2.Value = Servo2.Maximum;
                    }
                    break;
                case Keys.S:
                    if (Servo2.Value - SpeedBar.Value > Servo2.Minimum)
                    {
                        Servo2.Value -= SpeedBar.Value;
                    }
                    else
                    {
                        Servo2.Value = Servo2.Minimum;
                    }
                    break;
                case Keys.E:
                    if (Servo3.Value + SpeedBar.Value < Servo3.Maximum)
                    {
                        Servo3.Value += SpeedBar.Value;
                    }
                    else
                    {
                        Servo3.Value = Servo3.Maximum;
                    }
                    break;
                case Keys.D:
                    if (Servo3.Value - SpeedBar.Value > Servo3.Minimum)
                    {
                        Servo3.Value -= SpeedBar.Value;
                    }
                    else
                    {
                        Servo3.Value = Servo3.Minimum;
                    }
                    break;
                case Keys.R:
                    if (Servo4.Value + SpeedBar.Value < Servo4.Maximum)
                    {
                        Servo4.Value += SpeedBar.Value;
                    }
                    else
                    {
                        Servo4.Value = Servo4.Maximum;
                    }
                    break;
                case Keys.F:
                    if (Servo4.Value - SpeedBar.Value > Servo4.Minimum)
                    {
                        Servo4.Value -= SpeedBar.Value;
                    }
                    else
                    {
                        Servo4.Value = Servo4.Minimum;
                    }
                    break;
                case Keys.T:
                    if (Servo5.Value + SpeedBar.Value < Servo5.Maximum)
                    {
                        Servo5.Value += SpeedBar.Value;
                    }
                    else
                    {
                        Servo5.Value = Servo5.Maximum;
                    }
                    break;
                case Keys.G:
                    if (Servo5.Value - SpeedBar.Value > Servo5.Minimum)
                    {
                        Servo5.Value -= SpeedBar.Value;
                    }
                    else
                    {
                        Servo5.Value = Servo5.Minimum;
                    }
                    break;
                case Keys.Y:
                    if (Servo6.Value + SpeedBar.Value < Servo6.Maximum)
                    {
                        Servo6.Value += SpeedBar.Value;
                    }
                    else
                    {
                        Servo6.Value = Servo6.Maximum;
                    }
                    break;
                case Keys.H:
                    if (Servo6.Value - SpeedBar.Value > Servo6.Minimum)
                    {
                        Servo6.Value -= SpeedBar.Value;
                    }
                    else
                    {
                        Servo6.Value = Servo6.Minimum;
                    }
                    break;
                default:
                    break;
            }
        }

        private void Servo6_ValueChanged(object sender, EventArgs e)
        {
            // Stuur de nieuwe waardes naar de arduino.
             byte[] buf = new byte[2];
             buf[0] = 5;
             buf[1] = (byte)Servo6.Value;
             ComPort.Write(buf, 2);
        }

        private void Servo5_ValueChanged(object sender, EventArgs e)
        {
            // Stuur de nieuwe waardes naar de arduino.
            byte[] buf = new byte[2];
            buf[0] = 4;
            buf[1] = (byte)Servo5.Value;
            ComPort.Write(buf, 2);
        }

        private void Servo4_ValueChanged(object sender, EventArgs e)
        {
            // Stuur de nieuwe waardes naar de arduino.
            byte[] buf = new byte[2];
            buf[0] = 3;
            buf[1] = (byte)Servo4.Value;
            ComPort.Write(buf, 2);
        }

        private void Servo3_ValueChanged(object sender, EventArgs e)
        {
            // Stuur de nieuwe waardes naar de arduino.
            byte[] buf = new byte[2];
            buf[0] = 2;
            buf[1] = (byte)Servo3.Value;
            ComPort.Write(buf, 2);
        }

        private void Servo2_ValueChanged(object sender, EventArgs e)
        {
            // Stuur de nieuwe waardes naar de arduino.
            byte[] buf = new byte[2];
            buf[0] = 1;
            buf[1] = (byte)Servo2.Value;
            ComPort.Write(buf, 2);
        }

        private void Servo1_ValueChanged(object sender, EventArgs e)
        {
            // Stuur de nieuwe waardes naar de arduino.
            byte[] buf = new byte[2];
            buf[0] = 0;
            buf[1] = (byte)Servo1.Value;
            ComPort.Write(buf, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verwijder de laatste rij
            string[] row = new string[] { Servo1.Value.ToString(), Servo2.Value.ToString(), Servo3.Value.ToString(), Servo4.Value.ToString(), Servo5.Value.ToString(), Servo6.Value.ToString()};
            dataGridView1.Rows.Add(row);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Controleer of de ingoeverde waarde een juiste waarde is
            if (Convert.ToString(e.FormattedValue) != string.Empty)
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i) && i <= 180 && i >= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Alleen getallen tussen de 0 en 180");
                }
            }
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
              dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
        }

        private async void Run_Click(object sender, EventArgs e)
        {
            // Loop door de datatable en schrijf de juiste waarden naar de servos
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.CurrentCell = row.Cells[0];
                Servo1.Value = Convert.ToInt32(row.Cells[0].Value);
                Servo2.Value = Convert.ToInt32(row.Cells[1].Value);
                Servo3.Value = Convert.ToInt32(row.Cells[2].Value);
                Servo4.Value = Convert.ToInt32(row.Cells[3].Value);
                Servo5.Value = Convert.ToInt32(row.Cells[4].Value);
                Servo6.Value = Convert.ToInt32(row.Cells[5].Value);
                await WaitMethod();
            }
        }
   
        private async void Reverse_MouseClick(object sender, MouseEventArgs e)
        {
            // Loop achteruit door de datatable en schrijf de juiste waarden naar de servos
            for (int x = dataGridView1.Rows.Count; x > 0; x--)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[x - 1].Cells[0];
                Servo1.Value = Convert.ToInt32(dataGridView1.Rows[x - 1].Cells[0].Value);
                Servo2.Value = Convert.ToInt32(dataGridView1.Rows[x - 1].Cells[1].Value);
                Servo3.Value = Convert.ToInt32(dataGridView1.Rows[x - 1].Cells[2].Value);
                Servo4.Value = Convert.ToInt32(dataGridView1.Rows[x - 1].Cells[3].Value);
                Servo5.Value = Convert.ToInt32(dataGridView1.Rows[x - 1].Cells[4].Value);
                Servo6.Value = Convert.ToInt32(dataGridView1.Rows[x - 1].Cells[5].Value);
                await WaitMethod();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Sla de datatabel op
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveDataGridViewToCSV(saveFileDialog1.FileName);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //Laad de datatabel
            OpenFileDialog openFileCsv = new OpenFileDialog();
            string fileRow;
            string[] fileDataField;

            if (openFileCsv.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                string csvPath = openFileCsv.FileName;

                if (System.IO.File.Exists(csvPath))
                {
                    System.IO.StreamReader fileReader = new System.IO.StreamReader(csvPath, false);


                    //Reading Data
                    while (fileReader.Peek() != -1)
                    {
                        fileRow = fileReader.ReadLine();
                        fileDataField = fileRow.Split(',');
                        dataGridView1.Rows.Add(fileDataField);
                    }
                    fileReader.Dispose();
                    fileReader.Close();
                }
                else
                {
                    MessageBox.Show("CSV Bestand niet gevonden.");
                }
            }
        }

        //Help functies
        void SaveDataGridViewToCSV(string filename)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow dataRowObject in dataGridView1.Rows)
            {
                //Checking for New Row in DataGridView
                if (!dataRowObject.IsNewRow)
                {
                    string dataFromGrid = "";

                    dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                    for (int i = 1; i < dataGridView1.ColumnCount; i++)
                    {
                        dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();
                    }
                    sb.Append(dataFromGrid).Append('\n');                 
                }
            }
            File.WriteAllText(filename, sb.ToString());
        }
        async System.Threading.Tasks.Task WaitMethod()
        {
            // Wacht zonder de GUI te laten vastlopen;
            await System.Threading.Tasks.Task.Delay((int)numericUpDown1.Value);
        }
    }
}
