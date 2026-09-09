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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class DeleteStudent : Form
    {
        string connectionDB = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        string? username;

        public DeleteStudent(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;

        }
        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            LoadCategories();
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
            panel3.Visible = false;
            cuiButton9.Visible = false;
        }

        private void LoadData()
        {
            if (cuiTextBox1.Text == "")
            {
                MessageBox.Show("Please enter a Student ID.","Input Required",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if (!int.TryParse(cuiTextBox1.Text, out int id))
            {
                MessageBox.Show("Enter Valid Student ID", "Valid Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionDB))
                {
                    string query = @"SELECT StudentRecord.StudentID,
                                    StudentRecord.StudentName,
                                    Course.CourseName,
                                    StudentRecord.Gmail,
                                    StudentRecord.Phone,
                                    StudentRecord.Address
                                    FROM StudentRecord INNER JOIN Course ON StudentRecord.CourseID=Course.CourseID WHERE StudentID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("id", int.Parse(cuiTextBox1.Text));

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Student Record Found Successfully.","Record Found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        label10.Text = reader["StudentName"].ToString();
                        label11.Text = reader["CourseName"].ToString();
                        label12.Text = reader["Gmail"].ToString();
                        label13.Text = reader["Phone"].ToString();
                        label14.Text = reader["Address"].ToString();

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
                        panel3.Visible = true;
                        cuiButton9.Visible = true;             
                    }
                    else
                    {
                        MessageBox.Show("No student record found with the entered Student ID.","Record Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        cuiTextBox1.Text = "";
                    }
                }
            }

        }
        private void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection(connectionDB))
            {
                string query = "SELECT CourseID, CourseName FROM Course";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
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
            await Task.Delay(800);
            HideLoading();
            LoadData();
        }

        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student's record? " +
                "This action cannot be undone.","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionDB))
                {
                    string query = "DELETE FROM StudentRecord WHERE StudentID=@id";
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id",cuiTextBox1.Text);
                    cmd.ExecuteNonQuery();
                    ShowLoading();
                    await Task.Delay(500);
                    HideLoading();
                    MessageBox.Show("Student record deleted successfully.","Delete Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cuiTextBox1.Text = "";
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
                    cuiButton9.Visible = false;
                    panel3.Visible = false;
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
