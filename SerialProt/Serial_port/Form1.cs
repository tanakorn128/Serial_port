using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Serial_port
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
            getAviablePort();
           
        }
        void getAviablePort()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            Disconnected.Enabled = false;
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("ยังไม่ได้เลือก Comport ", "แจ้งเตือน", MessageBoxButtons.OK);
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("ยังไม่ได้เลือก Baud Rate","แจ้งเตือน",MessageBoxButtons.OK);
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    Connect.Enabled = false;
                    Disconnected.Enabled = true;
                    MessageBox.Show("เชื่อมต่อสำเร็จ");
                }
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("เชื่อมต่อไม่ได้");
            }
          
        }

        private void Disconnected_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            MessageBox.Show("หยุดการเชื่อมต่อ","แจ้งเตือน", MessageBoxButtons.OK);
            progressBar1.Value = 0;
            Connect.Enabled = true;
            Disconnected.Enabled = false;
            textBox2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = serialPort1.ReadLine();

               // textBox2.Text = textBox2.Text + textBox2.Text + "\r \n";
            }
            catch
            {
                MessageBox.Show("ไม่พบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine(textBox3.Text);
                textBox3.Text = "";
           
            }
            catch
            {
                MessageBox.Show("ไม่พบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("1");
                
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
