namespace WindowsFormsApp1
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLoanAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._BankSystem2_0DataSet2 = new WindowsFormsApp1._BankSystem2_0DataSet();
            this.bank1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BankSystem2_0DataSet1 = new WindowsFormsApp1._BankSystem2_0DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BankSystem2_0DataSet = new WindowsFormsApp1._BankSystem2_0DataSet();
            this.bankSystem20DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.TableAdapterManager();
            this.vBankLoansReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_Bank_Loans_ReportTableAdapter = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.v_Bank_Loans_ReportTableAdapter();
            this.vBankLoansReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bank1TableAdapter = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.Bank1TableAdapter();
            this.bank1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bank1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystem20DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBankLoansReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBankLoansReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport.AutoGenerateColumns = false;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankNameDataGridViewTextBoxColumn,
            this.customerCountDataGridViewTextBoxColumn,
            this.branchCountDataGridViewTextBoxColumn,
            this.employeeCountDataGridViewTextBoxColumn,
            this.totalLoanAmountDataGridViewTextBoxColumn});
            this.dataGridViewReport.DataSource = this.bank1BindingSource3;
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(681, 367);
            this.dataGridViewReport.TabIndex = 0;
            this.dataGridViewReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReport_CellContentClick);
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerCountDataGridViewTextBoxColumn
            // 
            this.customerCountDataGridViewTextBoxColumn.DataPropertyName = "CustomerCount";
            this.customerCountDataGridViewTextBoxColumn.HeaderText = "CustomerCount";
            this.customerCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerCountDataGridViewTextBoxColumn.Name = "customerCountDataGridViewTextBoxColumn";
            this.customerCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchCountDataGridViewTextBoxColumn
            // 
            this.branchCountDataGridViewTextBoxColumn.DataPropertyName = "BranchCount";
            this.branchCountDataGridViewTextBoxColumn.HeaderText = "BranchCount";
            this.branchCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchCountDataGridViewTextBoxColumn.Name = "branchCountDataGridViewTextBoxColumn";
            this.branchCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeCountDataGridViewTextBoxColumn
            // 
            this.employeeCountDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCount";
            this.employeeCountDataGridViewTextBoxColumn.HeaderText = "EmployeeCount";
            this.employeeCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeCountDataGridViewTextBoxColumn.Name = "employeeCountDataGridViewTextBoxColumn";
            this.employeeCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalLoanAmountDataGridViewTextBoxColumn
            // 
            this.totalLoanAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalLoanAmount";
            this.totalLoanAmountDataGridViewTextBoxColumn.HeaderText = "TotalLoanAmount";
            this.totalLoanAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalLoanAmountDataGridViewTextBoxColumn.Name = "totalLoanAmountDataGridViewTextBoxColumn";
            this.totalLoanAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalLoanAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // bank1BindingSource3
            // 
            this.bank1BindingSource3.DataMember = "Bank1";
            this.bank1BindingSource3.DataSource = this._BankSystem2_0DataSet2;
            // 
            // _BankSystem2_0DataSet2
            // 
            this._BankSystem2_0DataSet2.DataSetName = "_BankSystem2_0DataSet";
            this._BankSystem2_0DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bank1BindingSource
            // 
            this.bank1BindingSource.DataMember = "Bank1";
            this.bank1BindingSource.DataSource = this._BankSystem2_0DataSet1;
            // 
            // _BankSystem2_0DataSet1
            // 
            this._BankSystem2_0DataSet1.DataSetName = "_BankSystem2_0DataSet";
            this._BankSystem2_0DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this._BankSystem2_0DataSet;
            // 
            // _BankSystem2_0DataSet
            // 
            this._BankSystem2_0DataSet.DataSetName = "_BankSystem2_0DataSet";
            this._BankSystem2_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankSystem20DataSetBindingSource
            // 
            this.bankSystem20DataSetBindingSource.DataSource = this._BankSystem2_0DataSet;
            this.bankSystem20DataSetBindingSource.Position = 0;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.Belongs_toTableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vBankLoansReportBindingSource
            // 
            this.vBankLoansReportBindingSource.DataMember = "v_Bank_Loans_Report";
            this.vBankLoansReportBindingSource.DataSource = this._BankSystem2_0DataSet;
            // 
            // v_Bank_Loans_ReportTableAdapter
            // 
            this.v_Bank_Loans_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // vBankLoansReportBindingSource1
            // 
            this.vBankLoansReportBindingSource1.DataMember = "v_Bank_Loans_Report";
            this.vBankLoansReportBindingSource1.DataSource = this._BankSystem2_0DataSet1;
            // 
            // bank1TableAdapter
            // 
            this.bank1TableAdapter.ClearBeforeFill = true;
            // 
            // bank1BindingSource1
            // 
            this.bank1BindingSource1.DataMember = "Bank1";
            this.bank1BindingSource1.DataSource = this._BankSystem2_0DataSet1;
            // 
            // bank1BindingSource2
            // 
            this.bank1BindingSource2.DataMember = "Bank1";
            this.bank1BindingSource2.DataSource = this._BankSystem2_0DataSet;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(705, 391);
            this.Controls.Add(this.dataGridViewReport);
            this.Name = "ReportForm";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystem20DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBankLoansReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBankLoansReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank1BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.BindingSource bankSystem20DataSetBindingSource;
        private _BankSystem2_0DataSet _BankSystem2_0DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private _BankSystem2_0DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private _BankSystem2_0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vBankLoansReportBindingSource;
        private _BankSystem2_0DataSetTableAdapters.v_Bank_Loans_ReportTableAdapter v_Bank_Loans_ReportTableAdapter;
        private _BankSystem2_0DataSet _BankSystem2_0DataSet1;
        private System.Windows.Forms.BindingSource vBankLoansReportBindingSource1;
        private System.Windows.Forms.BindingSource bank1BindingSource;
        private _BankSystem2_0DataSetTableAdapters.Bank1TableAdapter bank1TableAdapter;
        private System.Windows.Forms.BindingSource bank1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLoanAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bank1BindingSource2;
        private _BankSystem2_0DataSet _BankSystem2_0DataSet2;
        private System.Windows.Forms.BindingSource bank1BindingSource3;
    }
}