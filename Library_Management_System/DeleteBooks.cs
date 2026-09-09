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
    public partial class DeleteBooks : Form
    {
        string connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;
        public DeleteBooks(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
        }
        private void DeleteBooks_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            cuiButton9.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
        }

        void RemoveBook()
        {
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                con.Open();
                string query = "SELECT Quantity FROM LibraryData WHERE BookID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", (cuiTextBox1.Text));
                int quantity = (int)cmd.ExecuteScalar();
                if (quantity > 1)
                {
                    string updateQuery = "UPDATE LibraryData SET Quantity=Quantity-1 WHERE BookID=@id AND Quantity>1";
                    SqlCommand Updatecmd = new SqlCommand(updateQuery, con);
                    Updatecmd.Parameters.AddWithValue("@id", (cuiTextBox1.Text));
                    Updatecmd.ExecuteNonQuery();
                    MessageBox.Show("One copy removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cuiButton9.Visible = false;
                    panel3.Visible = false;

                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    cuiTextBox1.Text = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show("This is the last available copy.Deleting it will permanently remove the book from the library." +
                        "Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM LibraryData WHERE BookID=@id AND Quantity=1";
                        SqlCommand Deletecmd = new SqlCommand(deleteQuery, con);
                        Deletecmd.Parameters.AddWithValue("@id", (cuiTextBox1.Text));
                        Deletecmd.ExecuteNonQuery();
                        MessageBox.Show("The last copy has been removed." +
                            "The book has been deleted from the library.", "Book Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cuiButton9.Visible = false;
                        panel3.Visible = false;

                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        cuiTextBox1.Text = "";
                    }
                }
            }
        }
        void LoadData()
        {
            if (cuiTextBox1.Text == "")
            {
                MessageBox.Show("Please enter Book ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cuiButton9.Visible = false;
                panel3.Visible = false;

                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                return;
            }
            else if (!int.TryParse(cuiTextBox1.Text, out int id))
            {
                MessageBox.Show("Enter Valid Book ID", "Valid Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cuiButton9.Visible = false;
                panel3.Visible = false;

                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                cuiTextBox1.Text = "";
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionDb))
                {
                    string query = @"SELECT LibraryData.BookName,
                                 LibraryData.AuthorName,
                                 Categories.CategoryName, 
                                 LibraryData.Quantity,
                                 LibraryData.RackNo FROM LibraryData    
                                 INNER JOIN Categories ON LibraryData.CategoryID = Categories.CategoryID where BookID=@id;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(cuiTextBox1.Text));

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Book Found Successfully.", "Record Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label10.Text = reader["BookName"].ToString();
                        label11.Text = reader["AuthorName"].ToString();
                        label12.Text = reader["CategoryName"].ToString();
                        label13.Text = reader["Quantity"].ToString();
                        label14.Text = reader["RackNo"].ToString();

                        panel3.Visible = true;
                        cuiButton9.Visible = true;

                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = true;
                        label13.Visible = true;
                        label14.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No Book found with the entered Book ID.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cuiButton9.Visible = false;
                        panel3.Visible = false;

                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        cuiTextBox1.Text = "";

                    }
                }
            }

        }

        private async void cuiButton8_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();

            LoadData();
        }

        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();

            RemoveBook();
        }

        private async void cuiButton1_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            DashBoard f1 = new DashBoard(username);
            f1.Show();
            this.Hide();
        }
        private async void cuiButton2_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            AddBook f2 = new AddBook(username);
            f2.Show();
            this.Hide();
        }

        private async void cuiButton3_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            ViewBooks f3 = new ViewBooks(username);
            f3.Show();
            this.Hide();
        }

        private async void cuiButton4_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            IssueBook f4 = new IssueBook(username);
            f4.Show();
            this.Hide();
        }

        private async void cuiButton5_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            ReturnBook f5 = new ReturnBook(username);
            f5.Show();
            this.Hide();
        }

        private async void cuiButton6_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            Students f6 = new Students(username);
            f6.Show();
            this.Hide();
        }

        private async void cuiButton7_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(2000);
            HideLoading();
            StudentRecord f7 = new StudentRecord(username);
            f7.Show();
            this.Hide();
        }

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
