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

namespace Arduino_led_yakma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
       
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen) { serialPort1.Open(); }

            }
            catch (Exception ex) { };
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("4");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }
    }   
    
}