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
        private SerialPort serialPort;
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || comboBox5.SelectedIndex == -1)
            {
            MessageBox.Show("Please choose option for each box", "Loi cau hinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1 form1 = new Form1();

                form1.Show();
                this.Close();
            }
        }
    }
}
