namespace LibraryManagment.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.DgvAddCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.TxtCustomerIdNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.TxtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.BtnCustomerSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAddCustumer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddCustomer)).BeginInit();
            this.PnlSearch.SuspendLayout();
            this.GrpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAddCustomer
            // 
            this.DgvAddCustomer.AllowUserToAddRows = false;
            this.DgvAddCustomer.AllowUserToDeleteRows = false;
            this.DgvAddCustomer.AllowUserToOrderColumns = true;
            this.DgvAddCustomer.AllowUserToResizeColumns = false;
            this.DgvAddCustomer.AllowUserToResizeRows = false;
            this.DgvAddCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAddCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvAddCustomer.Location = new System.Drawing.Point(405, 12);
            this.DgvAddCustomer.Name = "DgvAddCustomer";
            this.DgvAddCustomer.Size = new System.Drawing.Size(383, 171);
            this.DgvAddCustomer.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            // 
            // PnlSearch
            // 
            this.PnlSearch.Controls.Add(this.GrpSearch);
            this.PnlSearch.Location = new System.Drawing.Point(12, 12);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(373, 171);
            this.PnlSearch.TabIndex = 6;
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.TxtCustomerIdNumber);
            this.GrpSearch.Controls.Add(this.label3);
            this.GrpSearch.Controls.Add(this.TxtCustomerName);
            this.GrpSearch.Controls.Add(this.TxtCustomerSurname);
            this.GrpSearch.Controls.Add(this.label2);
            this.GrpSearch.Controls.Add(this.LblCustomerName);
            this.GrpSearch.Location = new System.Drawing.Point(13, 14);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(357, 141);
            this.GrpSearch.TabIndex = 0;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "Müştərinin axtarışı";
            // 
            // TxtCustomerIdNumber
            // 
            this.TxtCustomerIdNumber.Location = new System.Drawing.Point(174, 72);
            this.TxtCustomerIdNumber.Name = "TxtCustomerIdNumber";
            this.TxtCustomerIdNumber.Size = new System.Drawing.Size(177, 20);
            this.TxtCustomerIdNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(174, 16);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(177, 20);
            this.TxtCustomerName.TabIndex = 3;
            // 
            // TxtCustomerSurname
            // 
            this.TxtCustomerSurname.Location = new System.Drawing.Point(174, 42);
            this.TxtCustomerSurname.Name = "TxtCustomerSurname";
            this.TxtCustomerSurname.Size = new System.Drawing.Size(177, 20);
            this.TxtCustomerSurname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(6, 23);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(20, 13);
            this.LblCustomerName.TabIndex = 0;
            this.LblCustomerName.Text = "Ad";
            // 
            // BtnCustomerSearch
            // 
            this.BtnCustomerSearch.Location = new System.Drawing.Point(12, 189);
            this.BtnCustomerSearch.Name = "BtnCustomerSearch";
            this.BtnCustomerSearch.Size = new System.Drawing.Size(120, 33);
            this.BtnCustomerSearch.TabIndex = 1;
            this.BtnCustomerSearch.Text = "Axtar";
            this.BtnCustomerSearch.UseVisualStyleBackColor = true;
            this.BtnCustomerSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Yenilə";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAddCustumer
            // 
            this.BtnAddCustumer.Location = new System.Drawing.Point(444, 189);
            this.BtnAddCustumer.Name = "BtnAddCustumer";
            this.BtnAddCustumer.Size = new System.Drawing.Size(120, 33);
            this.BtnAddCustumer.TabIndex = 10;
            this.BtnAddCustumer.Text = "Əlavə et";
            this.BtnAddCustumer.UseVisualStyleBackColor = true;
            this.BtnAddCustumer.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddCustumer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCustomerSearch);
            this.Controls.Add(this.DgvAddCustomer);
            this.Controls.Add(this.PnlSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "Müştərinin axtarışı";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddCustomer)).EndInit();
            this.PnlSearch.ResumeLayout(false);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.Button BtnCustomerSearch;
        private System.Windows.Forms.TextBox TxtCustomerIdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAddCustumer;
    }
}