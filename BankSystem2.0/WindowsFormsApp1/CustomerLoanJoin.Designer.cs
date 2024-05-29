namespace WindowsFormsApp1
{
    partial class CustomerLoanJoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoanJoin));
            this.bank111BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bank111BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bank111DataGridView = new System.Windows.Forms.DataGridView();
            this.fillBy3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameSearchToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameSearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank111BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BankSystem2_0DataSet = new WindowsFormsApp1._BankSystem2_0DataSet();
            this.bank111TableAdapter = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.Bank111TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bank111BindingNavigator)).BeginInit();
            this.bank111BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bank111DataGridView)).BeginInit();
            this.fillBy3ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bank111BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bank111BindingNavigator
            // 
            this.bank111BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bank111BindingNavigator.BindingSource = this.bank111BindingSource;
            this.bank111BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bank111BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bank111BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bank111BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bank111BindingNavigatorSaveItem});
            this.bank111BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bank111BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bank111BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bank111BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bank111BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bank111BindingNavigator.Name = "bank111BindingNavigator";
            this.bank111BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bank111BindingNavigator.Size = new System.Drawing.Size(705, 27);
            this.bank111BindingNavigator.TabIndex = 0;
            this.bank111BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bank111BindingNavigatorSaveItem
            // 
            this.bank111BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bank111BindingNavigatorSaveItem.Enabled = false;
            this.bank111BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bank111BindingNavigatorSaveItem.Image")));
            this.bank111BindingNavigatorSaveItem.Name = "bank111BindingNavigatorSaveItem";
            this.bank111BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bank111BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bank111DataGridView
            // 
            this.bank111DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bank111DataGridView.AutoGenerateColumns = false;
            this.bank111DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bank111DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bank111DataGridView.DataSource = this.bank111BindingSource;
            this.bank111DataGridView.Location = new System.Drawing.Point(12, 66);
            this.bank111DataGridView.Name = "bank111DataGridView";
            this.bank111DataGridView.RowHeadersWidth = 51;
            this.bank111DataGridView.RowTemplate.Height = 24;
            this.bank111DataGridView.Size = new System.Drawing.Size(681, 257);
            this.bank111DataGridView.TabIndex = 1;
            // 
            // fillBy3ToolStrip
            // 
            this.fillBy3ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameSearchToolStripLabel,
            this.nameSearchToolStripTextBox,
            this.fillBy3ToolStripButton});
            this.fillBy3ToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillBy3ToolStrip.Name = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Size = new System.Drawing.Size(705, 27);
            this.fillBy3ToolStrip.TabIndex = 2;
            this.fillBy3ToolStrip.Text = "fillBy3ToolStrip";
            // 
            // nameSearchToolStripLabel
            // 
            this.nameSearchToolStripLabel.Name = "nameSearchToolStripLabel";
            this.nameSearchToolStripLabel.Size = new System.Drawing.Size(143, 24);
            this.nameSearchToolStripLabel.Text = "Customer Full Name";
            // 
            // nameSearchToolStripTextBox
            // 
            this.nameSearchToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameSearchToolStripTextBox.Name = "nameSearchToolStripTextBox";
            this.nameSearchToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillBy3ToolStripButton
            // 
            this.fillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy3ToolStripButton.Name = "fillBy3ToolStripButton";
            this.fillBy3ToolStripButton.Size = new System.Drawing.Size(99, 24);
            this.fillBy3ToolStripButton.Text = "Search Loans";
            this.fillBy3ToolStripButton.Click += new System.EventHandler(this.fillBy3ToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LoanNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "LoanNo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LoanType";
            this.dataGridViewTextBoxColumn2.HeaderText = "LoanType";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoanAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "LoanAmount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmpNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "EmpNo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // bank111BindingSource
            // 
            this.bank111BindingSource.DataMember = "Bank111";
            this.bank111BindingSource.DataSource = this._BankSystem2_0DataSet;
            // 
            // _BankSystem2_0DataSet
            // 
            this._BankSystem2_0DataSet.DataSetName = "_BankSystem2_0DataSet";
            this._BankSystem2_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bank111TableAdapter
            // 
            this.bank111TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.Belongs_toTableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CustomerLoanJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(705, 347);
            this.Controls.Add(this.fillBy3ToolStrip);
            this.Controls.Add(this.bank111DataGridView);
            this.Controls.Add(this.bank111BindingNavigator);
            this.Name = "CustomerLoanJoin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank111BindingNavigator)).EndInit();
            this.bank111BindingNavigator.ResumeLayout(false);
            this.bank111BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bank111DataGridView)).EndInit();
            this.fillBy3ToolStrip.ResumeLayout(false);
            this.fillBy3ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bank111BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _BankSystem2_0DataSet _BankSystem2_0DataSet;
        private System.Windows.Forms.BindingSource bank111BindingSource;
        private _BankSystem2_0DataSetTableAdapters.Bank111TableAdapter bank111TableAdapter;
        private _BankSystem2_0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bank111BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bank111BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bank111DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip fillBy3ToolStrip;
        private System.Windows.Forms.ToolStripLabel nameSearchToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameSearchToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy3ToolStripButton;
    }
}