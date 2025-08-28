using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//caution
using Microsoft.Data.SqlClient;
//them thu vien

namespace WpfCrudApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo MainWindow:\n" + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private string connectionString = "Data Source=DESKTOP-DGA4LS3\\SQLEXPRESS;Initial Catalog=WpfCrudDb;Integrated Security=True;TrustServerCertificate=True;";
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgProducts.ItemsSource = dt.DefaultView;
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Products (ProductName, Price, Quantity) VALUES (@name, @price, @quantity)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem != null)
            {
                DataRowView row = (DataRowView)dgProducts.SelectedItem;
                int productId = (int)row["ProductId"];

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Products SET ProductName = @name, Price = @price, Quantity = @quantity WHERE ProductId = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem != null)
            {
                DataRowView row = (DataRowView)dgProducts.SelectedItem;
                int productId = (int)row["ProductId"];

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE ProductId = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
        }
    }
}