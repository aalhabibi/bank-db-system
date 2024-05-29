namespace WindowsFormsApp1
{
    partial class SelectCustomerBySSN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCustomerBySSN));
            System.Windows.Forms.Label lNameLabel1;
            System.Windows.Forms.Label fNameLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label sSNLabel1;
            System.Windows.Forms.Label addressLabel1;
            System.Windows.Forms.Label bdateLabel1;
            System.Windows.Forms.Label branchNoLabel1;
            System.Windows.Forms.Label bankCodeLabel;
            this.bankSystemDataSet = new WindowsFormsApp1.BankSystemDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsApp1.BankSystemDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BankSystemDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountTableAdapter1 = new WindowsFormsApp1.BankSystemDataSetTableAdapters.AccountTableAdapter();
            this.lNameTextBox1 = new System.Windows.Forms.TextBox();
            this.fNameTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.sSNTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.bdateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.branchNoTextBox1 = new System.Windows.Forms.TextBox();
            this.bankCodeTextBox = new System.Windows.Forms.TextBox();
            this.ssnsearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.ssnToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ssnToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ssnsearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._BankSystem2_0DataSet = new WindowsFormsApp1._BankSystem2_0DataSet();
            this.customerTableAdapter1 = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.TableAdapterManager();
            lNameLabel1 = new System.Windows.Forms.Label();
            fNameLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            sSNLabel1 = new System.Windows.Forms.Label();
            addressLabel1 = new System.Windows.Forms.Label();
            bdateLabel1 = new System.Windows.Forms.Label();
            branchNoLabel1 = new System.Windows.Forms.Label();
            bankCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ssnsearchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bankSystemDataSet;
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
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BankSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(375, 27);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lNameTextBox1);
            this.groupBox1.Controls.Add(lNameLabel1);
            this.groupBox1.Controls.Add(this.bankCodeTextBox);
            this.groupBox1.Controls.Add(bankCodeLabel);
            this.groupBox1.Controls.Add(fNameLabel1);
            this.groupBox1.Controls.Add(this.branchNoTextBox1);
            this.groupBox1.Controls.Add(this.fNameTextBox1);
            this.groupBox1.Controls.Add(branchNoLabel1);
            this.groupBox1.Controls.Add(phoneLabel1);
            this.groupBox1.Controls.Add(this.bdateDateTimePicker1);
            this.groupBox1.Controls.Add(this.phoneTextBox1);
            this.groupBox1.Controls.Add(bdateLabel1);
            this.groupBox1.Controls.Add(sSNLabel1);
            this.groupBox1.Controls.Add(this.addressTextBox1);
            this.groupBox1.Controls.Add(this.sSNTextBox1);
            this.groupBox1.Controls.Add(addressLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 286);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // lNameLabel1
            // 
            lNameLabel1.AutoSize = true;
            lNameLabel1.Location = new System.Drawing.Point(23, 43);
            lNameLabel1.Name = "lNameLabel1";
            lNameLabel1.Size = new System.Drawing.Size(54, 16);
            lNameLabel1.TabIndex = 19;
            lNameLabel1.Text = "LName:";
            // 
            // lNameTextBox1
            // 
            this.lNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "LName", true));
            this.lNameTextBox1.Location = new System.Drawing.Point(106, 40);
            this.lNameTextBox1.Name = "lNameTextBox1";
            this.lNameTextBox1.Size = new System.Drawing.Size(200, 22);
            this.lNameTextBox1.TabIndex = 20;
            // 
            // fNameLabel1
            // 
            fNameLabel1.AutoSize = true;
            fNameLabel1.Location = new System.Drawing.Point(23, 71);
            fNameLabel1.Name = "fNameLabel1";
            fNameLabel1.Size = new System.Drawing.Size(55, 16);
            fNameLabel1.TabIndex = 21;
            fNameLabel1.Text = "FName:";
            // 
            // fNameTextBox1
            // 
            this.fNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "FName", true));
            this.fNameTextBox1.Location = new System.Drawing.Point(106, 68);
            this.fNameTextBox1.Name = "fNameTextBox1";
            this.fNameTextBox1.Size = new System.Drawing.Size(200, 22);
            this.fNameTextBox1.TabIndex = 22;
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(23, 99);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(49, 16);
            phoneLabel1.TabIndex = 23;
            phoneLabel1.Text = "Phone:";
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(106, 96);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox1.TabIndex = 24;
            // 
            // sSNLabel1
            // 
            sSNLabel1.AutoSize = true;
            sSNLabel1.Location = new System.Drawing.Point(23, 127);
            sSNLabel1.Name = "sSNLabel1";
            sSNLabel1.Size = new System.Drawing.Size(38, 16);
            sSNLabel1.TabIndex = 25;
            sSNLabel1.Text = "SSN:";
            // 
            // sSNTextBox1
            // 
            this.sSNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "SSN", true));
            this.sSNTextBox1.Location = new System.Drawing.Point(106, 124);
            this.sSNTextBox1.Name = "sSNTextBox1";
            this.sSNTextBox1.Size = new System.Drawing.Size(200, 22);
            this.sSNTextBox1.TabIndex = 26;
            // 
            // addressLabel1
            // 
            addressLabel1.AutoSize = true;
            addressLabel1.Location = new System.Drawing.Point(23, 155);
            addressLabel1.Name = "addressLabel1";
            addressLabel1.Size = new System.Drawing.Size(61, 16);
            addressLabel1.TabIndex = 27;
            addressLabel1.Text = "Address:";
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(106, 152);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(200, 22);
            this.addressTextBox1.TabIndex = 28;
            // 
            // bdateLabel1
            // 
            bdateLabel1.AutoSize = true;
            bdateLabel1.Location = new System.Drawing.Point(23, 184);
            bdateLabel1.Name = "bdateLabel1";
            bdateLabel1.Size = new System.Drawing.Size(46, 16);
            bdateLabel1.TabIndex = 29;
            bdateLabel1.Text = "Bdate:";
            // 
            // bdateDateTimePicker1
            // 
            this.bdateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource1, "Bdate", true));
            this.bdateDateTimePicker1.Location = new System.Drawing.Point(106, 180);
            this.bdateDateTimePicker1.Name = "bdateDateTimePicker1";
            this.bdateDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.bdateDateTimePicker1.TabIndex = 30;
            // 
            // branchNoLabel1
            // 
            branchNoLabel1.AutoSize = true;
            branchNoLabel1.Location = new System.Drawing.Point(23, 211);
            branchNoLabel1.Name = "branchNoLabel1";
            branchNoLabel1.Size = new System.Drawing.Size(73, 16);
            branchNoLabel1.TabIndex = 31;
            branchNoLabel1.Text = "Branch No:";
            // 
            // branchNoTextBox1
            // 
            this.branchNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "BranchNo", true));
            this.branchNoTextBox1.Location = new System.Drawing.Point(106, 208);
            this.branchNoTextBox1.Name = "branchNoTextBox1";
            this.branchNoTextBox1.Size = new System.Drawing.Size(200, 22);
            this.branchNoTextBox1.TabIndex = 32;
            // 
            // bankCodeLabel
            // 
            bankCodeLabel.AutoSize = true;
            bankCodeLabel.Location = new System.Drawing.Point(23, 239);
            bankCodeLabel.Name = "bankCodeLabel";
            bankCodeLabel.Size = new System.Drawing.Size(77, 16);
            bankCodeLabel.TabIndex = 33;
            bankCodeLabel.Text = "Bank Code:";
            // 
            // bankCodeTextBox
            // 
            this.bankCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "BankCode", true));
            this.bankCodeTextBox.Location = new System.Drawing.Point(106, 236);
            this.bankCodeTextBox.Name = "bankCodeTextBox";
            this.bankCodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.bankCodeTextBox.TabIndex = 34;
            // 
            // ssnsearchToolStrip
            // 
            this.ssnsearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssnsearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssnToolStripLabel,
            this.ssnToolStripTextBox,
            this.ssnsearchToolStripButton});
            this.ssnsearchToolStrip.Location = new System.Drawing.Point(0, 27);
            this.ssnsearchToolStrip.Name = "ssnsearchToolStrip";
            this.ssnsearchToolStrip.Size = new System.Drawing.Size(375, 27);
            this.ssnsearchToolStrip.TabIndex = 35;
            this.ssnsearchToolStrip.Text = "ssnsearchToolStrip";
            // 
            // ssnToolStripLabel
            // 
            this.ssnToolStripLabel.Name = "ssnToolStripLabel";
            this.ssnToolStripLabel.Size = new System.Drawing.Size(39, 24);
            this.ssnToolStripLabel.Text = "SSN:";
            // 
            // ssnToolStripTextBox
            // 
            this.ssnToolStripTextBox.Name = "ssnToolStripTextBox";
            this.ssnToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // ssnsearchToolStripButton
            // 
            this.ssnsearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ssnsearchToolStripButton.Name = "ssnsearchToolStripButton";
            this.ssnsearchToolStripButton.Size = new System.Drawing.Size(108, 24);
            this.ssnsearchToolStripButton.Text = "Search By SSN";
            this.ssnsearchToolStripButton.Click += new System.EventHandler(this.ssnsearchToolStripButton_Click);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this._BankSystem2_0DataSet;
            // 
            // _BankSystem2_0DataSet
            // 
            this._BankSystem2_0DataSet.DataSetName = "_BankSystem2_0DataSet";
            this._BankSystem2_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccountTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BankTableAdapter = null;
            this.tableAdapterManager1.Belongs_toTableAdapter = null;
            this.tableAdapterManager1.BranchTableAdapter = null;
            this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter1;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.LoanTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1._BankSystem2_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(375, 379);
            this.Controls.Add(this.ssnsearchToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "Form3";
            this.Text = "Select Customer By SSN";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ssnsearchToolStrip.ResumeLayout(false);
            this.ssnsearchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BankSystem2_0DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BankSystemDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private BankSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private BankSystemDataSetTableAdapters.AccountTableAdapter accountTableAdapter1;
        private _BankSystem2_0DataSet _BankSystem2_0DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private _BankSystem2_0DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private _BankSystem2_0DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox lNameTextBox1;
        private System.Windows.Forms.TextBox fNameTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox sSNTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.DateTimePicker bdateDateTimePicker1;
        private System.Windows.Forms.TextBox branchNoTextBox1;
        private System.Windows.Forms.TextBox bankCodeTextBox;
        private System.Windows.Forms.ToolStrip ssnsearchToolStrip;
        private System.Windows.Forms.ToolStripLabel ssnToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ssnToolStripTextBox;
        private System.Windows.Forms.ToolStripButton ssnsearchToolStripButton;
    }
}