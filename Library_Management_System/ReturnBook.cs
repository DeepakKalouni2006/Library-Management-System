using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        string? connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;
        int bookid;

        public ReturnBook(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
            label10.Text = DateTime.Now.ToString("dd MMMM yyyy");
            cuiSpinner1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            cuiButton9.Visible = false;
            panel3.Visible = false;
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

        private async void cuiButton8_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            if (cuiTextBox1.Text == "")
            {
                MessageBox.Show("Please enter an Issue ID.", "Missing Issue ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cuiTextBox1.Text, out int id))
            {
                MessageBox.Show("Enter Valid Issue ID", "Valid Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cuiTextBox1.Text = "";
                return;
            }
            else
            {
                ShowLoading();
                await Task.Delay(1000);
                using (SqlConnection con = new SqlConnection(connectionDb))
                {
                    con.Open();
                    string query1 = @"SELECT StudentRecord.StudentName,LibraryData.BookID, LibraryData.BookName, IssueBooks.Status, IssueBooks.IssueDate,IssueBooks.ReturnDate
                                    FROM StudentRecord
	                                INNER JOIN IssueBooks ON StudentRecord.StudentID=IssueBooks.StudentID
                                    INNER JOIN LibraryData ON LibraryData.BookID=IssueBooks.BookID WHERE IssueBooks.IssueId=@issueid;";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("@issueid", int.Parse(cuiTextBox1.Text));
                    SqlDataReader reader = cmd1.ExecuteReader();
                    HideLoading();
                    if (reader.Read())
                    {
                        MessageBox.Show("Issue Id found!","Search Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        string? status = reader["Status"].ToString();
                        bookid = Convert.ToInt32(reader["BookId"]);
                        if (status == "Returned")
                        {
                            MessageBox.Show("This book has already been returned.\n\n" +
                                            "No further action is required.", "Already Returned",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information
                                            );
                            cuiTextBox1.Text = "";
                            return;
                        }

                        else
                        {
                            label8.Text = reader["StudentName"].ToString();
                            label9.Text = reader["BookName"].ToString();
                            label5.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            cuiButton9.Visible = true;
                            panel3.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No issue record was found for this Issue ID.", "Issue Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cuiTextBox1.Text = "";
                        return;
                    }
                }
            }

        }

        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                con.Open();
                string? query = @"BEGIN TRANSACTION
                                  UPDATE IssueBooks SET Status='Returned', ReturnDate=@returndate WHERE IssueId=@issueid;
                                  UPDATE LibraryData SET Quantity=Quantity+1 WHERE BookID=@bookid;
                                  COMMIT TRANSACTION";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@issueid", int.Parse(cuiTextBox1.Text));
                cmd.Parameters.AddWithValue("@returndate", DateTime.Today);
                cmd.Parameters.AddWithValue("@bookid", bookid);
                cmd.ExecuteNonQuery();
                HideLoading();
                MessageBox.Show("Book Returned Successfully!\n\n" +
                                "Issue ID: " + cuiTextBox1.Text + "\n" +
                                "Return Date: " + DateTime.Today.ToString("dd-MM-yyyy"), "Return Successful",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information
                                 );
                cuiTextBox1.Text = "";
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                cuiButton9.Visible = false;
                panel3.Visible = false;
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
