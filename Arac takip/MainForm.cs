
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
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
namespace Arac_takip
{
    public partial class MainForm : Form
    {
        string m_portName = "COM3";
        int m_baudRate = 115200;

        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void m_connectionConfigurationItem_Click(object sender, EventArgs e)
        {
            ConfigurationDialogForm cdf = new ConfigurationDialogForm();

            // Com ayarları set ediliyor..
            if (cdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_portName = cdf.m_comboBoxCOMList.SelectedItem.ToString();
                m_baudRate = Convert.ToInt32(cdf.m_comboBoxBaudRateList.SelectedItem);
                m_baglantilar_baglan.Enabled = true;

            }
        }

        private void m_serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string veri = m_serialPort.ReadExisting();
            m_richTextBox.Text += veri + "\r\n";
            m_serialPort.DiscardInBuffer();
           /* m_serialPort.BaudRate = m_baudRate;
            m_serialPort.Open();
            if (m_serialPort.ReadExisting().EndsWith("\n"))
            {
                string a = m_serialPort.ReadLine();

                int b = Convert.ToInt32(a);


                textBox2.Text = m_baudRate + "";*/

               // m_serialPort.DiscardInBuffer();
         }

        private void m_baglantilar_baglan_Click(object sender, System.EventArgs e)
        {
            m_serialPort.PortName = m_portName;
            m_serialPort.BaudRate = m_baudRate;
           

            if (!m_serialPort.IsOpen)
            {
                m_serialPort.Open();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void m_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void m_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!m_serialPort.IsOpen)
                    m_serialPort.Open();

                m_serialPort.WriteLine(m_textBox1.Text + "\r");//r basa dönüyo n de de bi alt satıra geçip ekrana yazıyo

                MessageBox.Show("Başarıyla gönderildi");
                //m_textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void m_label1_Click(object sender, EventArgs e)
        {

        }

       

        private void m_testtanılabaslatbutton1_Click(object sender, EventArgs e)
        {
            m_rectangleShapeKontakKapalı.BackColor = Color.Red;
        }


        }
    }

