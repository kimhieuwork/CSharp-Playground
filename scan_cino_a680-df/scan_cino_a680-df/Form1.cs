using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;


namespace scan_cino_a680_df
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;//= new SerialPort("COM1",115200,Parity.None,);
        private string filePath = "scanned_code.txt"; //du lieu quet duoc
        private bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
            Manage_State(isConnected);

        }

        private void Form1_Load()
        {
            //Cau hinh cong COM
            serialPort = new SerialPort();
            serialPort.PortName = "COM1"; // Chinh theo cong tren may scan
            serialPort.BaudRate = 115200; // toc do baud, check device manager
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;

            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string scannedData = serialPort.ReadLine().Trim(); // doc data tu tay scan

                //luu vao file txt
                File.AppendAllText(filePath, scannedData + Environment.NewLine);

                // nho bat thuoc tinh Multiline: true trong properties
                //display
                this.Invoke(() =>
                {
                    txtCode.Text += scannedData + Environment.NewLine;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Write Data: " + ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                isConnected = true;
                Manage_State(isConnected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong ket noi duoc cong: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                isConnected = false;
                Manage_State(isConnected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }
        }
        private void Manage_State(bool connectState)
        {
            if (isConnected)
            {
                label2.Text = "Connected";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Disconnected";
                label2.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }
    }
}
