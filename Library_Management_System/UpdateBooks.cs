using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class UpdateBooks : Form
    {

        string connectionDB = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        string? username;
        public UpdateBooks(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
        }
        private void UpdateBooks_Load(object sender, EventArgs e)
        {
            LoadCategories();
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            cuiTextBox2.Visible = false;
            cuiTextBox3.Visible = false;
            cuiTextBox4.Visible = false;
            cuiTextBox5.Visible = false;
            cuiButton2.Visible = false;
            comboBox1.Visible = false;
        }

        async void LoadData()
        {
            ShowLoading();
            await Task.Delay(1000);
            if (cuiTextBox1.Text == "")
            {
                HideLoading();
                MessageBox.Show("Please Enter Book ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                cuiTextBox2.Visible = false;
                cuiTextBox3.Visible = false;
                cuiTextBox4.Visible = false;
                cuiTextBox5.Visible = false;
                cuiButton2.Visible = false;
                comboBox1.Visible = false;
                cuiTextBox1.Text = "";
                return;
            }

            else if (!int.TryParse(cuiTextBox1.Text, out int id))
            {
                HideLoading();
                MessageBox.Show("Enter Valid Book ID", "Valid Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                cuiTextBox2.Visible = false;
                cuiTextBox3.Visible = false;
                cuiTextBox4.Visible = false;
                cuiTextBox5.Visible = false;
                cuiButton2.Visible = false;
                comboBox1.Visible = false;
                return;
            }
            
            
            else
            {
                using (SqlConnection con = new SqlConnection(connectionDB))
                {
                    string query = "SELECT *FROM LibraryData WHERE BookID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("id", int.Parse(cuiTextBox1.Text));

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        HideLoading();
                        MessageBox.Show("Book Found Successfully.", "Record Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cuiTextBox2.Text = reader["BookName"].ToString();
                        cuiTextBox3.Text = reader["AuthorName"].ToString();
                        cuiTextBox4.Text = reader["Quantity"].ToString();
                        cuiTextBox5.Text = reader["RackNo"].ToString();
                        comboBox1.SelectedValue = Convert.ToInt32(reader["CategoryID"]);
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label9.Visible = true;
                        comboBox1.Visible = true;
                        cuiTextBox2.Visible = true;
                        cuiTextBox3.Visible = true;
                        cuiTextBox4.Visible = true;
                        cuiTextBox5.Visible = true;
                        cuiButton2.Visible = true;
                    }
                    else
                    {
                        HideLoading();
                        MessageBox.Show("No Book found with the entered Book ID.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cuiTextBox1.Text = "";
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label9.Visible = false;
                        cuiTextBox2.Visible = false;
                        cuiTextBox3.Visible = false;
                        cuiTextBox4.Visible = false;
                        cuiTextBox5.Visible = false;
                        cuiButton2.Visible = false;
                        comboBox1.Visible = false;

                    }
                }
            }
            
        }

        private void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection(connectionDB))
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

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionDB))
            {
                string query = "UPDATE LibraryData SET BookName=@bookName,AuthorName=@authorName,Quantity=@quantity,RackNo=@rackNo,CategoryID=@categoryID WHERE BookID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@bookName", cuiTextBox2.Text);
                cmd.Parameters.AddWithValue("@authorName", cuiTextBox3.Text);
                cmd.Parameters.AddWithValue("@quantity", cuiTextBox4.Text);
                cmd.Parameters.AddWithValue("@rackNo", cuiTextBox5.Text);
                cmd.Parameters.AddWithValue("@categoryID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@id", int.Parse(cuiTextBox1.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Updated Successfully.", "Book Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cuiTextBox1.Text = "";
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                cuiTextBox2.Visible = false;
                cuiTextBox3.Visible = false;
                cuiTextBox4.Visible = false;
                cuiTextBox5.Visible = false;
                cuiButton2.Visible = false;
                comboBox1.Visible = false;
            }
        }
        private async void cuiButton3_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            DashBoard f1 = new DashBoard(username);
            f1.Show();
            this.Hide();
        }

        private async void cuiButton4_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            AddBook f2 = new AddBook(username);
            f2.Show();
            this.Hide();
        }

        private async void cuiButton5_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            ViewBooks f3 = new ViewBooks(username);
            f3.Show();
            this.Hide();
        }

        private async void cuiButton6_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            IssueBook f4 = new IssueBook(username);
            f4.Show();
            this.Hide();
        }

        private async void cuiButton7_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            ReturnBook f5 = new ReturnBook(username);
            f5.Show();
            this.Hide();
        }

        private async void cuiButton8_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            Students f6 = new Students(username);
            f6.Show();
            this.Hide();
        }
        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            StudentRecord f7 = new StudentRecord(username);
            f7.Show();
            this.Hide();
        }
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.DodgerBlue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.RoyalBlue;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
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
    }
}
