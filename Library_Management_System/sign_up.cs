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
    public partial class sign_up : Form
    {
        string connectionDB = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        
        public sign_up()
        {
            InitializeComponent();
            HideLoading();
        }

        private async void cuiButton1_Click(object sender, EventArgs e)
        {
            ShowLoading();
            this.Refresh();
            if (cuiTextBox1.Text==""||cuiTextBox2.Text==""||cuiTextBox3.Text=="")
            {
                await Task.Delay(1000);
                HideLoading();
                MessageBox.Show("These Fields Cannot be Empty","Login Failed");
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionDB))
                {
                    string Checkedquery = "SELECT COUNT(*) FROM Account WHERE Username = @username";
                    SqlCommand Checkedcmd = new SqlCommand(Checkedquery, con);
                    Checkedcmd.Parameters.AddWithValue("@username", cuiTextBox1.Text);
                    con.Open();
                    int count = (int)Checkedcmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already Exist!");
                        HideLoading();
                        cuiTextBox1.Text = "";
                        cuiTextBox2.Text = "";
                        cuiTextBox3.Text = "";
                        return; 
                    }
                    if (cuiTextBox2.Text == cuiTextBox3.Text)
                    {
                        string query = "INSERT INTO Account (Username,Password) VALUES(@username,@password)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@username", cuiTextBox1.Text);
                        cmd.Parameters.AddWithValue("@password", cuiTextBox2.Text);
                        cmd.ExecuteNonQuery();
                        await Task.Delay(2000);
                        HideLoading();
                        MessageBox.Show("Account Created Successfully");
                        DashBoard f1 = new DashBoard(cuiTextBox1.Text);
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        await Task.Delay(2000);
                        HideLoading();
                        MessageBox.Show("Password Doesn't Match!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.RoyalBlue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;

        }

        private void cuiCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cuiTextBox2.PasswordChar == true && cuiTextBox3.PasswordChar==true)
            {
                cuiTextBox2.PasswordChar = false;
                cuiTextBox3.PasswordChar = false;
            }
            else
            {
                cuiTextBox2.PasswordChar = true;
                cuiTextBox3.PasswordChar = true;
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
