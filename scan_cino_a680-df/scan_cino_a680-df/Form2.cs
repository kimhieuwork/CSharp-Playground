using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scan_cino_a680_df
{
    public partial class Form2 : Form
    {
        //bien de luu tru instance cua Form1
        private Form1 _form1;

        //Constructor moi nhan instance cua Form1
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || comboBox5.SelectedIndex == -1)
            {
            MessageBox.Show("Please choose option for each box", "Loi cau hinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Su dung .SelectedItem.ToString() de lay gia tri chuoi
                _form1.serialPort.PortName = comboBox1.SelectedIndex.ToString(); // Chinh theo cong tren may scan
                _form1.serialPort.BaudRate = int.Parse(comboBox2.SelectedIndex.ToString()); // toc do baud, check device manager
                _form1.serialPort.DataBits = int.Parse(comboBox3.SelectedIndex.ToString());

                //chuyen doi chuoi sang enum cho Parity va Stopbits
                string selectedParity = comboBox4.SelectedIndex.ToString();
                _form1.serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), selectedParity);
                string selectedStopBits = comboBox5.SelectedIndex.ToString();
                _form1.serialPort.StopBits = (StopBits)Enum.Parse(typeof (StopBits), selectedStopBits);
                // sau khi gan, dong form 2 va display form 1
                _form1.Show();
                this.Close();
            }catch(Exception ex)
            {
                //bat cac loi co the xay ra
                MessageBox.Show("Error ! : " + ex.Message);
            }
        }
    }
}
