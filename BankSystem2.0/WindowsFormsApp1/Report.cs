using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet2.Bank1' table. You can move, or remove it, as needed.
            this.bank1TableAdapter.Fill(this._BankSystem2_0DataSet2.Bank1);
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet1.Bank1' table. You can move, or remove it, as needed.
            this.bank1TableAdapter.Fill(this._BankSystem2_0DataSet1.Bank1);
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet1.v_Bank_Loans_Report' table. You can move, or remove it, as needed.
            this.v_Bank_Loans_ReportTableAdapter.Fill(this._BankSystem2_0DataSet1.v_Bank_Loans_Report);
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet.v_Bank_Loans_Report' table. You can move, or remove it, as needed.
            this.v_Bank_Loans_ReportTableAdapter.Fill(this._BankSystem2_0DataSet.v_Bank_Loans_Report);
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this._BankSystem2_0DataSet.Customer);

        }

        private void dataGridViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
