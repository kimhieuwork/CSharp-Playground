using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;


namespace scan_cino_a680_df
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private string filePath = "scanned_code.txt"; //du lieu quet duoc

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cau hinh cong COM
            serialPort = new SerialPort();
            serialPort.PortName = "COM1"; // Chinh theo cong tren may scan
            serialPort.BaudRate = 115200; // toc do baud, check device manager
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;

            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong mo duoc cong COM: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string scannedData = serialPort.ReadLine().Trim(); // doc data tu tay scan

                //luu vao file txt
                File.AppendAllText(filePath, scannedData + Environment.NewLine);

                //display
                this.Invoke(() => {
                    txtCode.Text = scannedData;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Write Data: " + ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
