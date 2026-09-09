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
    public partial class UpdateStudent : Form
    {
        string connectionDB = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        string? username;
        public UpdateStudent(string? user)
        {
            InitializeComponent();
            HideLoading();
            username = user;
            LoadCategories();
        }
        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            LoadCategories();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            cuiTextBox2.Visible = false;
            cuiTextBox3.Visible = false;
            cuiTextBox4.Visible = false;
            cuiTextBox5.Visible = false;

            comboBox1.Visible = false;
            cuiButton9.Visible = false;
        }
        void LoadData()
        {
            if (cuiTextBox1.Text == "")
            {
                MessageBox.Show("Please enter a Student ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cuiTextBox1.Text, out int id))
            {
                MessageBox.Show("Enter Valid Student ID", "Valid Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                using (SqlConnection con = new SqlConnection(connectionDB))
                {
                    string query = "SELECT *FROM StudentRecord WHERE StudentID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("id", int.Parse(cuiTextBox1.Text));

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Student Record Found Successfully.", "Record Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cuiTextBox2.Text = reader["StudentName"].ToString();
                        cuiTextBox3.Text = reader["Gmail"].ToString();
                        cuiTextBox4.Text = reader["Phone"].ToString();
                        cuiTextBox5.Text = reader["Address"].ToString();
                        comboBox1.SelectedValue = Convert.ToInt32(reader["CourseID"]);
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        comboBox1.Visible = true;
                        cuiTextBox2.Visible = true;
                        cuiTextBox3.Visible = true;
                        cuiTextBox4.Visible = true;
                        cuiTextBox5.Visible = true;
                        cuiButton9.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Found!", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cuiTextBox1.Text = "";
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;

                        cuiTextBox2.Visible = false;
                        cuiTextBox3.Visible = false;
                        cuiTextBox4.Visible = false;
                        cuiTextBox5.Visible = false;

                        comboBox1.Visible = false;
                        cuiButton9.Visible = false;
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

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "CourseName";
                comboBox1.ValueMember = "CourseID";
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
            await Task.Delay(1000);
            HideLoading();

            LoadData();
        }

        private async void cuiButton9_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            using (SqlConnection con = new SqlConnection(connectionDB))
            {
                string query = "UPDATE StudentRecord SET StudentName=@studentName,Gmail=@gmail,Phone=@phone,Address=@address,CourseID=@courseID WHERE StudentID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentName", cuiTextBox2.Text);
                cmd.Parameters.AddWithValue("@gmail", cuiTextBox3.Text);
                cmd.Parameters.AddWithValue("@phone", cuiTextBox4.Text);
                cmd.Parameters.AddWithValue("@address", cuiTextBox5.Text);
                cmd.Parameters.AddWithValue("@courseID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@id", int.Parse(cuiTextBox1.Text));
                con.Open();
                cmd.ExecuteNonQuery();

                HideLoading();
                MessageBox.Show("Student Record is Updated Successfully.", "Update Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cuiTextBox1.Text = "";
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                cuiTextBox2.Visible = false;
                cuiTextBox3.Visible = false;
                cuiTextBox4.Visible = false;
                cuiTextBox5.Visible = false;
                cuiButton9.Visible = false;
                comboBox1.Visible = false;
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
