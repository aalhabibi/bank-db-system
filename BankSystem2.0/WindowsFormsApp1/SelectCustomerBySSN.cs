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
    public partial class SelectCustomerBySSN : Form
    {
        public SelectCustomerBySSN()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankSystemDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BankSystem2_0DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this._BankSystem2_0DataSet.Customer);
            // TODO: This line of code loads data into the 'bankSystemDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankSystemDataSet.Customer);

        }

        private void selectBySSNToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.SelectBySSN(this.bankSystemDataSet.Customer, ((int)(System.Convert.ChangeType(ssnToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void selectBySSNToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ssnsearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter1.SearchBySSN(this._BankSystem2_0DataSet.Customer, ((int)(System.Convert.ChangeType(ssnToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
