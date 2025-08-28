using System.IO.Ports;

namespace isConnected_handle
{
    public partial class Form1 : Form
    {
        //khai bao cap do class de su dung duoc nhieu noi
        SerialPort port = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            initializeSerialPort();
            setConnectionStatus(false);
        }
        private void initializeSerialPort()
        {
            //khoi tao cong com
            port.PortName = "COM1";
            port.BaudRate = 115200;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {

            // Neu cong dang dong, thuc hien mo cong va cap nhat giao dien
            port.Open();
            setConnectionStatus(true);

        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            // Neu cong dang mo, thuc hien dong cong va cap nhat giao dien
            port.Close();
            setConnectionStatus(false);
        }

        private void setConnectionStatus(bool isConnected)
        {
            if (isConnected)
            {
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
                btn_Connect.Text = "Disconnect"; // thay doi chu
            }
            else
            {
                label1.Text = "Not connected";
                label1.ForeColor = Color.Red;
                btn_Connect.Text = "Connect"; // Thay doi chu
            }
        }
    }
}
