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

namespace Arac_takip
{
    public partial class ConfigurationDialogForm : Form
    {
        public ConfigurationDialogForm()
        {
            InitializeComponent();
        }

        

        private void ConfigurationDialogForm_Load(object sender, EventArgs e)
        {

            // Seri Port Listesi Oluşturuluyor..
            foreach (string port in SerialPort.GetPortNames())
                m_comboBoxCOMList.Items.Add(port);

            if (SerialPort.GetPortNames().Length > 0)
                m_comboBoxCOMList.SelectedItem = m_comboBoxCOMList.Items[0];

            // Bound Rate Listesi Oluşturuluyor..
            m_comboBoxBaudRateList.Items.Add("9600");
            m_comboBoxBaudRateList.Items.Add("19200");
            m_comboBoxBaudRateList.Items.Add("38400");
            m_comboBoxBaudRateList.Items.Add("115200");

            m_comboBoxBaudRateList.SelectedItem = m_comboBoxBaudRateList.Items[0];
        }

        private void m_buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void m_buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void m_buttonRefresh_Click(object sender, EventArgs e)
        {
            m_comboBoxCOMList.Items.Clear();

            foreach (string port in SerialPort.GetPortNames())
                m_comboBoxCOMList.Items.Add(port);

            if (SerialPort.GetPortNames().Length > 0)
                m_comboBoxCOMList.SelectedItem = m_comboBoxCOMList.Items[0];
        }

        private void m_comboBoxCOMList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
