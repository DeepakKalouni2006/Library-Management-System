using CuoreUI.Controls;
using Microsoft.Data.SqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    public partial class DashBoard : Form
    {
        string connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;
        public DashBoard(string? user)
        {
            InitializeComponent();
            HideLoading();
            LoadChart();
            totalbook();
            totalissue();
            totalstudent();
            username = user;
            label7.Text = "Welcome, " + username;
        }


        private void LoadChart()
        {
            var option = uiBarChart1.Option;

            option.Title.Text = "Books Issued by Category";
            option.Title.SubText = "";
            option.XAxis.Clear();
            option.XAxis.Name = "\n\nBooks Category";
            option.XAxis.Data.Add("Programming");
            option.XAxis.Data.Add("Science");
            option.XAxis.Data.Add("Self-Help");
            option.XAxis.Data.Add("Biography"); 
            option.XAxis.Data.Add("Histroy");
           
            option.Legend.Clear();
            option.Legend.Data.Add("Total Books");
            option.Legend.Data.Add("Issued Books");


            option.YAxis.SetMinValue(0d);
            option.YAxis.SetMaxValue(30d);

        }

        private void totalbook()
        {
            using(SqlConnection con=new SqlConnection(connectionDb))
            {
                con.Open();
                //===========THIS IS FOR TOTAL BOOKS===========
                string query1 = "SELECT COUNT(*) FROM LibraryData;";
                SqlCommand cmd = new SqlCommand(query1,con);
                SqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    label10.Text = reader1[""].ToString();
                }
                else
                {
                    MessageBox.Show("Something Wrong!","failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void totalissue()
        {
            using(SqlConnection con=new SqlConnection(connectionDb))
            {
                con.Open();
                //========= THIS IS FOR TOTAL ISSUE/ RETURN BOOKS RECORD==========
                string query2 = "SELECT COUNT(*) FROM IssueBooks;";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    label11.Text = reader2[""].ToString();
                }
                else
                {
                    MessageBox.Show("Something Wrong!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void totalstudent()
        {
            using(SqlConnection con=new SqlConnection(connectionDb))
            {
                con.Open();
                //========THIS IS FOR TOTAL STUDENTS=================
                string query3 = "SELECT COUNT(*) FROM StudentRecord;";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlDataReader reader3 = cmd3.ExecuteReader();
                if (reader3.Read())
                {
                    label15.Text = reader3[""].ToString();
                }
                else
                {
                    MessageBox.Show("Something Wrong!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            DialogResult result = MessageBox.Show("Are You Sure you want to Logout?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ShowLoading();
                await Task.Delay(1000);
                HideLoading();
                Login f1 = new Login();
                f1.Show();
                this.Hide();
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
        private void label8_Click(object sender, EventArgs e)
        {
            ViewBooks f2 = new ViewBooks(username);
            f2.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            IssuebookRecord f4 = new IssuebookRecord(username);
            f4.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            StudentRecord f5 = new StudentRecord(username);
            f5.Show();
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
