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
    public partial class IssuebookRecord : Form
    {
        string connectionDb = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;Trust Server Certificate=True";
        string? username;
        public IssuebookRecord(string? user)
        {
            InitializeComponent();
            username = user;
            HideLoading();
            styleDataGridView();
            uiDataGridView1.DataBindingComplete += uiDataGridView1_DataBindingComplete;
            Showdata();
        }
        private async void Showdata()
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            using (SqlConnection con = new SqlConnection(connectionDb))
            {
                con.Open();
                string? query = @"SELECT IssueBooks.IssueId,LibraryData.BookID,
                                  StudentRecord.StudentName,LibraryData.BookName, 
                                  IssueBooks.IssueDate,IssueBooks.ReturnDate, IssueBooks.Status
                                  FROM StudentRecord
	                              INNER JOIN IssueBooks ON StudentRecord.StudentID=IssueBooks.StudentID
                                  INNER JOIN LibraryData ON LibraryData.BookID=IssueBooks.BookID where IssueBooks.IssueId=IssueId;";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                uiDataGridView1.DataSource = dt;
                uiDataGridView1.ClearSelection();
                uiDataGridView1.CurrentCell = null;
            }
        }

        private void uiDataGridView1_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            uiDataGridView1.ClearSelection();
            uiDataGridView1.CurrentCell = null;

        }

        public void styleDataGridView()
        {
            uiDataGridView1.ReadOnly = true;
            uiDataGridView1.AllowUserToDeleteRows = false;
            uiDataGridView1.AllowUserToAddRows = false;

            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.GridColor = ColorTranslator.FromHtml("#E5E7EB");

            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            uiDataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            uiDataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F5F7FB");

            uiDataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            uiDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0B1F4D");
            uiDataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            uiDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            uiDataGridView1.DefaultCellStyle.BackColor = Color.White;
            uiDataGridView1.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#1F2937");
            uiDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            uiDataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F5F7FB");

            uiDataGridView1.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#2563EB");
            uiDataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            uiDataGridView1.RowTemplate.Height = 38;
            uiDataGridView1.RowHeadersVisible = false;
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToResizeRows = false;

            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uiDataGridView1.BorderStyle = BorderStyle.None;
        }
        private void uiDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "ReturnDate")
            {
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Not Returned";
                }
            }
        }
        private async void cuiButton1_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            DashBoard f1 = new DashBoard(username);
            f1.Show();
            this.Hide();
        }

        private async void cuiButton2_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            AddBook f2 = new AddBook(username);
            f2.Show();
            this.Hide();
        }

        private async void cuiButton3_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            ViewBooks f3 = new ViewBooks(username);
            f3.Show();
            this.Hide();
        }

        private async void cuiButton4_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            IssueBook f4 = new IssueBook(username);
            f4.Show();
            this.Hide();
        }

        private async void cuiButton5_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            ReturnBook f5 = new ReturnBook(username);
            f5.Show();
            this.Hide();
        }

        private async void cuiButton6_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            Students f6 = new Students(username);
            f6.Show();
            this.Hide();
        }

        private async void cuiButton7_Click(object sender, EventArgs e)
        {
            ShowLoading();
            await Task.Delay(1000);
            HideLoading();
            StudentRecord f7 = new StudentRecord(username);
            f7.Show();
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
