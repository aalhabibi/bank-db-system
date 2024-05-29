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
    public partial class CustomerLoanJoin : Form
    {
        public CustomerLoanJoin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet.Bank111' table. You can move, or remove it, as needed.
            this.bank111TableAdapter.FillCustomerLoanQuery(this._BankSystem2_0DataSet.Bank111);

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bank111TableAdapter.FillBy3(this._BankSystem2_0DataSet.Bank111, nameSearchToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
