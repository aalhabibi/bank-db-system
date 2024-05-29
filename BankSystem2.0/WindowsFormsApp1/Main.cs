using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet2.Loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter1.Fill(this._BankSystem2_0DataSet2.Loan);
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this._BankSystem2_0DataSet1.Customer);
            // TODO: This line of code loads data into the 'bankSystemDataSet.Loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.bankSystemDataSet.Loan);
            // TODO: This line of code loads data into the 'bankSystemDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankSystemDataSet.Customer);
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// Insert Customer
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "INSERT INTO CUSTOMER (LName, FName, Phone, SSN, Address, Bdate, BranchNo, BankCode) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox15.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Insertion Completed");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)// Show Customer
        {
            this.customerTableAdapter1.Fill(this._BankSystem2_0DataSet1.Customer);
        }

        private void button2_Click(object sender, EventArgs e)//Update Customer
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "UPDATE CUSTOMER SET LName='" + textBox1.Text + "',  FName='" + textBox2.Text + "', Phone='" + textBox15.Text + "', Address='" + textBox4.Text + "', Bdate='" + textBox5.Text + "', BranchNo='" + textBox6.Text + "', BankCode='" + textBox7.Text + "' WHERE SSN='"+textBox3.Text+"'";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Update Completed");
        }

        private void button3_Click(object sender, EventArgs e)//Delete Customer
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "DELETE FROM CUSTOMER WHERE SSN='" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Deletion Completed");
        }

        private void button8_Click(object sender, EventArgs e)// Show Loan
        {
            this.loanTableAdapter1.Fill(this._BankSystem2_0DataSet2.Loan);
        }

        private void button5_Click(object sender, EventArgs e)// Insert Loan
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "INSERT INTO Loan (LoanNo, LoanType, LoanAmount, BranchNo, BankCode, SSN, EmpNo) VALUES('" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Insertion Completed");
        }

        private void button6_Click(object sender, EventArgs e)//Update Loan
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "UPDATE Loan SET LoanType='" + textBox9.Text + "',  LoanAmount='" + textBox10.Text + "', BranchNo='" + textBox11.Text + "', BankCode='" + textBox12.Text + "', SSN='" + textBox13.Text + "', EmpNo='" + textBox14.Text + "' WHERE LoanNo='" + textBox8.Text + "'";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Update Completed");
        }

        private void button7_Click(object sender, EventArgs e)//Delete Loan
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=AALHABIBI\\MSSQLSERVER01;Initial Catalog=BankSystem2.0;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "DELETE FROM Loan WHERE LoanNo='" + textBox8.Text + "'";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Deletion Completed");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)//Select by SSN
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)// Go to Form 2
        {
            CustomerLoanJoin form2 = new CustomerLoanJoin();
            form2.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SelectCustomerBySSN form3 = new SelectCustomerBySSN();
            form3.Show();
            this.Hide();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            ReportForm form5 = new ReportForm();
            form5.Show();
            this.Hide();
        }

        private void Customer_Enter(object sender, EventArgs e)
        {

        }
    }
}