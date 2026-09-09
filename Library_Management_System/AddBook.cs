using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
namespace Library_Management_System
{
    public partial class AddBook : Form
    {
        string connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;

        public AddBook(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
        }
        private void AddBook_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryID";
            }
        }

        private async void cuiButton1_Click(object sender, EventArgs e)
        {
            ShowLoading();
            if (!int.TryParse(cuiTextBox1.Text, out int id) || cuiTextBox2.Text == "" || cuiButton3.Text == "" || cuiButton4.Text == "" || cuiButton5.Text == "")
            {
                await Task.Delay(1000);
                HideLoading();
                MessageBox.Show("Fields cannot be Empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                using (SqlConnection con = new SqlConnection(connectionDb))
                {
                    string query = @"INSERT INTO LibraryData (BookID,BookName ,AuthorName ,Quantity,RackNo,CategoryID)
                               VALUES (@id,@Book_name,@Author_name,@quantity,@Rack,@categoryID)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", int.Parse(cuiTextBox1.Text));
                    cmd.Parameters.AddWithValue("@Book_name", cuiTextBox2.Text);
                    cmd.Parameters.AddWithValue("@Author_name", cuiTextBox3.Text);
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(cuiTextBox4.Text));
                    cmd.Parameters.AddWithValue("@Rack", (cuiTextBox5.Text));
                    cmd.Parameters.AddWithValue("@categoryID", comboBox1.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                await Task.Delay(1000);
                HideLoading();
                MessageBox.Show("Book Added Successfully.", "Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cuiTextBox1.Text = "";
                cuiTextBox2.Text = "";
                cuiTextBox3.Text = "";
                cuiTextBox4.Text = "";
                cuiTextBox5.Text = "";
                comboBox1.SelectedIndex = -1;
            }
        }
        private async void cuiButton2_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            UpdateBooks f2 = new UpdateBooks(username);
            f2.Show();
            this.Hide();
        }
        private async void cuiButton3_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            DeleteBooks f8 = new DeleteBooks(username);
            f8.Show();
            this.Hide();
        }
        private async void cuiButton4_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            DashBoard f1 = new DashBoard(username);
            f1.Show();
            this.Hide();
        }
        private async void cuiButton5_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            AddBook f2 = new AddBook(username);
            f2.Show();
            this.Hide();
        }

        private async void cuiButton6_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            ViewBooks f3 = new ViewBooks(username);
            f3.Show();
            this.Hide();
        }

        private async void cuiButton7_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            IssueBook f4 = new IssueBook(username);
            f4.Show();
            this.Hide();
        }

        private async void cuiButton8_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            ReturnBook f5 = new ReturnBook(username);
            f5.Show();
            this.Hide();
        }

        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            Students f6 = new Students(username);
            f6.Show();
            this.Hide();
        }
        private async void cuiButton10_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(2000);
            HideLoading();
            StudentRecord f7 = new StudentRecord(username);
            f7.Show();
            this.Hide();
        }
        private void ShowLoading()
        {
            cuiSpinner1.Visible = true;
            cuiButton1.Enabled = false;
        }

        private void HideLoading()
        {
            cuiSpinner1.Visible = false;
            cuiButton1.Enabled = true;
        }
        //======================================Hover Property===================================================
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DodgerBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.RoyalBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

    }
}
