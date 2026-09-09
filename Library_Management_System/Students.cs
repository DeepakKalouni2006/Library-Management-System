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
    public partial class Students : Form
    {
        string connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;
        public Students(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
            Course();
        }
        private void Course()
        {
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                string query = "SELECT CourseID, CourseName FROM Course";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "CourseName";
                comboBox1.ValueMember = "CourseID";
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
        private async void cuiButton8_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            UpdateStudent f8 = new UpdateStudent(username);
            f8.Show();
            this.Hide();
        }
        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            if (cuiTextBox1.Text == "" || cuiButton2.Text == "" || cuiButton3.Text == "" || cuiButton4.Text == "")
            {
                ShowLoading();
                await Task.Delay(1000);
                HideLoading();
                MessageBox.Show("Fields cannot be Empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionDb))
                {
                    ShowLoading();
                    await Task.Delay(1000);
                    string query = @"INSERT INTO StudentRecord(StudentName,Gmail,Phone,Address,CourseID) 
                                     VALUES(@studentName,@gmail,@phone,@address,@courseID);
                                     SELECT SCOPE_IDENTITY() AS StudentID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@studentName", cuiTextBox1.Text);
                    cmd.Parameters.AddWithValue("@gmail", cuiTextBox2.Text);
                    cmd.Parameters.AddWithValue("@phone", cuiTextBox3.Text);
                    cmd.Parameters.AddWithValue("@address", cuiTextBox4.Text);
                    cmd.Parameters.AddWithValue("@courseID", comboBox1.SelectedValue);
                    con.Open();
                    int studentID = Convert.ToInt32(cmd.ExecuteScalar());
                    HideLoading();
                    MessageBox.Show(
                                    "Student Added Successfully!\n\n" +
                                    "Your Student ID: " + studentID +
                                    "\n\nPlease keep this ID safe.",
                                    "Registration Successful",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information
                                     );
                    cuiTextBox1.Text = "";
                    cuiTextBox2.Text = "";
                    cuiTextBox3.Text = "";
                    cuiTextBox4.Text = "";
                    comboBox1.SelectedIndex = -1;
                }
            }
        }
        private async void cuiButton10_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(500);
            HideLoading();
            DeleteStudent f9 = new DeleteStudent(username);
            f9.Show();
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




    }
}
