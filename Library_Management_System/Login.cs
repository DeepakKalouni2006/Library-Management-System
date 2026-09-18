using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        string connectionDB = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Login()
        {

            InitializeComponent();
            HideLoading();
        }
        private async void cuiButton1_Click(object sender, EventArgs e)
        {
            ShowLoading();
            this.Refresh();
            
            if (cuiTextBox1.Text == "" || cuiTextBox2.Text == "")
            {
                await Task.Delay(500);
                HideLoading();
                this.Refresh();
                MessageBox.Show("Please Fill the Textboxes!","Empty Input Field",MessageBoxButtons.OK, MessageBoxIcon.Warning);            
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionDB))
                {
                    string query = "SELECT *FROM Account where Username= @username AND Password= @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", cuiTextBox1.Text);
                    cmd.Parameters.AddWithValue("@password", cuiTextBox2.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        await Task.Delay(500);
                        HideLoading();
                        DashBoard f1 = new DashBoard(cuiTextBox1.Text);
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        await Task.Delay(1000);
                        HideLoading();
                        MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                
        }

        private void cuiCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cuiTextBox2.PasswordChar == true)
            {
                cuiTextBox2.PasswordChar = false;
            }
            else
            {
                cuiTextBox2.PasswordChar = true;
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            sign_up f2 = new sign_up();
            f2.Show();
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
    }
}
