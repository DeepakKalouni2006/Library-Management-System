using CuoreUI.Controls;
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
    public partial class IssueBook : Form
    {
        string connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;
        public IssueBook(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
            cuiTextBox5.Text = DateTime.Now.ToString("dd MMMM yyyy");
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            cuiTextBox3.Visible = false;
            cuiTextBox4.Visible = false;
            cuiTextBox5.Visible = false;
            cuiButton10.Visible = false;
        }
        void BookIssue()
        {
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                string query = @"INSERT INTO IssueBook(StudentID,BookID,IssueDate) 
                               VALUES(@studentid, @bookid,@issuedate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentid", cuiTextBox1.Text);
                cmd.Parameters.AddWithValue("@bookid",cuiTextBox2.Text);
                cmd.Parameters.AddWithValue("@issueDate", cuiTextBox5.Text);
            }
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
            await Task.Delay(500);
            HideLoading();
            StudentRecord f7 = new StudentRecord(username);
            f7.Show();
            this.Hide();
        }
        private void cuiButton8_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                con.Open();
                string? query = @"SELECT StudentName FROM StudentRecord WHERE StudentID=@studentid;
                              SELECT BookName FROM LibraryData WHERE BookID=@bookid;";

                string query2 = "SELECT COUNT(*) FROM LibraryData";
                SqlCommand cmd2 = new SqlCommand(query2, con);

                int total = Convert.ToInt32(cmd2.ExecuteScalar());
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentid",int.Parse( cuiTextBox1.Text));
                cmd.Parameters.AddWithValue("@bookid", int.Parse(cuiTextBox2.Text));

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cuiTextBox3.Text = reader["StudentName"].ToString();
                    if(reader.NextResult()&& reader.Read()&& total < 31)
                    {
                        cuiTextBox4.Text = reader["BookName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the existed Book ID...", "Book not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cuiTextBox2.Text = "";
                        return;
                    }
                    label5.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    cuiTextBox3.Visible = true;
                    cuiTextBox3.Enabled = false;
                    cuiTextBox4.Visible = true;
                    cuiTextBox4.Enabled = false;
                    cuiTextBox5.Visible = true;
                    cuiTextBox5.Enabled = false;
                    cuiButton10.Visible = true;
                    cuiButton8.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Record found with these ID's.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void cuiButton10_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(connectionDb))
            {
                string query1 = "SELECT Quantity FROM LibraryData WHERE BookID=@id";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@id",cuiTextBox2.Text);
                con.Open();
                int quantity = (int)cmd1.ExecuteScalar();
                if (quantity > 1)
                {
                    string query = @"INSERT INTO IssueBooks (StudentID,BookID,IssueDate)
                            VALUES(@studentid,@bookid,@issuedate);
                            SELECT SCOPE_IDENTITY() AS IssueID";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.AddWithValue("@StudentID", int.Parse(cuiTextBox1.Text));
                    cmd2.Parameters.AddWithValue("@BookID", int.Parse(cuiTextBox2.Text));
                    cmd2.Parameters.AddWithValue("@IssueDate", DateTime.Today);

                    string updateQuery = "UPDATE LibraryData SET Quantity=Quantity-1 WHERE BookID=@id AND Quantity>1";
                    SqlCommand cmd3 = new SqlCommand(updateQuery,con);
                    cmd3.Parameters.AddWithValue("@id", cuiTextBox2.Text);
                    cmd3.ExecuteNonQuery();
                    int issueid = Convert.ToInt32(cmd2.ExecuteScalar());

                    MessageBox.Show("Book Issued Successfully!\n\n" +
                                    "Your Issue ID: " + issueid +
                                    "\n\nPlease keep this ID safe.",
                                    "Issue Successful",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information
                                     );
                    cuiTextBox1.Text = "";
                    cuiTextBox2.Text = "";
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    cuiTextBox3.Visible = false;
                    cuiTextBox4.Visible = false;
                    cuiTextBox5.Visible = false;
                    cuiButton10.Visible = false;
                }
                else if (quantity == 1)
                {
                    DialogResult result = MessageBox.Show("This is the last available copy." +
                                            "Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string query = @"INSERT INTO IssueBooks (StudentID,BookID,IssueDate)
                            VALUES(@studentid,@bookid,@issuedate);
                            SELECT SCOPE_IDENTITY() AS IssueID";
                        SqlCommand cmd2 = new SqlCommand(query, con);
                        cmd2.Parameters.AddWithValue("@StudentID", int.Parse(cuiTextBox1.Text));
                        cmd2.Parameters.AddWithValue("@BookID", int.Parse(cuiTextBox2.Text));
                        cmd2.Parameters.AddWithValue("@IssueDate", DateTime.Today);

                        string updateQuery = "UPDATE LibraryData SET Quantity=Quantity-1 WHERE BookID=@id AND Quantity=1";
                        SqlCommand cmd3 = new SqlCommand(updateQuery, con);
                        cmd3.Parameters.AddWithValue("@id", cuiTextBox2.Text);
                        cmd3.ExecuteNonQuery();
                        int issueid = Convert.ToInt32(cmd2.ExecuteScalar());

                        MessageBox.Show("Book Issued Successfully!\n\n" +
                                        "Your Issue ID: " + issueid +
                                        "\n\nPlease keep this ID safe.",
                                        "Issue Successful",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information
                                         );
                    cuiTextBox1.Text = "";
                    cuiTextBox2.Text = "";
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    cuiTextBox3.Visible = false;
                    cuiTextBox4.Visible = false;
                    cuiTextBox5.Visible = false;
                    cuiButton10.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Book is Currently not Available!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cuiTextBox1.Text = "";
                    cuiTextBox2.Text = "";
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    cuiTextBox3.Visible = false;
                    cuiTextBox4.Visible = false;
                    cuiTextBox5.Visible = false;
                    cuiButton10.Visible = false;
                }
            }
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
