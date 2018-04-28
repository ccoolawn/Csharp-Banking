namespace Banking_Polymorphism
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFromAcct = new System.Windows.Forms.ComboBox();
            this.cboToAcct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTransType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransAmt = new System.Windows.Forms.TextBox();
            this.btnSubmitTrans = new System.Windows.Forms.Button();
            this.txtTransDescript = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDisplayAccts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(27, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(215, 319);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Acct. Number";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Acct. Type";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of current Accounts";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Location = new System.Drawing.Point(258, 119);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(594, 316);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Transaction Type";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Transaction Date";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Transaction Amount";
            this.columnHeader6.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(255, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of Account Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(869, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Withdraw | Deposit | Transfer Funds";
            // 
            // cboFromAcct
            // 
            this.cboFromAcct.FormattingEnabled = true;
            this.cboFromAcct.Location = new System.Drawing.Point(964, 170);
            this.cboFromAcct.Name = "cboFromAcct";
            this.cboFromAcct.Size = new System.Drawing.Size(121, 29);
            this.cboFromAcct.TabIndex = 5;
            // 
            // cboToAcct
            // 
            this.cboToAcct.FormattingEnabled = true;
            this.cboToAcct.Location = new System.Drawing.Point(964, 201);
            this.cboToAcct.Name = "cboToAcct";
            this.cboToAcct.Size = new System.Drawing.Size(121, 29);
            this.cboToAcct.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(880, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(880, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(880, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type:";
            // 
            // cboTransType
            // 
            this.cboTransType.FormattingEnabled = true;
            this.cboTransType.Location = new System.Drawing.Point(964, 138);
            this.cboTransType.Name = "cboTransType";
            this.cboTransType.Size = new System.Drawing.Size(121, 29);
            this.cboTransType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(880, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amt:";
            // 
            // txtTransAmt
            // 
            this.txtTransAmt.Location = new System.Drawing.Point(964, 231);
            this.txtTransAmt.Name = "txtTransAmt";
            this.txtTransAmt.Size = new System.Drawing.Size(121, 30);
            this.txtTransAmt.TabIndex = 12;
            // 
            // btnSubmitTrans
            // 
            this.btnSubmitTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTrans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmitTrans.Location = new System.Drawing.Point(883, 367);
            this.btnSubmitTrans.Name = "btnSubmitTrans";
            this.btnSubmitTrans.Size = new System.Drawing.Size(183, 57);
            this.btnSubmitTrans.TabIndex = 13;
            this.btnSubmitTrans.Text = "Submit Transaction";
            this.btnSubmitTrans.UseVisualStyleBackColor = true;
            // 
            // txtTransDescript
            // 
            this.txtTransDescript.Location = new System.Drawing.Point(964, 259);
            this.txtTransDescript.Multiline = true;
            this.txtTransDescript.Name = "txtTransDescript";
            this.txtTransDescript.Size = new System.Drawing.Size(121, 83);
            this.txtTransDescript.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(880, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description:";
            // 
            // btnDisplayAccts
            // 
            this.btnDisplayAccts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAccts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplayAccts.Location = new System.Drawing.Point(26, 462);
            this.btnDisplayAccts.Name = "btnDisplayAccts";
            this.btnDisplayAccts.Size = new System.Drawing.Size(216, 42);
            this.btnDisplayAccts.TabIndex = 16;
            this.btnDisplayAccts.Text = "Display Accts";
            this.btnDisplayAccts.UseVisualStyleBackColor = true;
            this.btnDisplayAccts.Click += new System.EventHandler(this.btnDisplayAccts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 604);
            this.Controls.Add(this.btnDisplayAccts);
            this.Controls.Add(this.txtTransDescript);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSubmitTrans);
            this.Controls.Add(this.txtTransAmt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTransType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboToAcct);
            this.Controls.Add(this.cboFromAcct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "1st National Bank of CorAna";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFromAcct;
        private System.Windows.Forms.ComboBox cboToAcct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTransType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransAmt;
        private System.Windows.Forms.Button btnSubmitTrans;
        private System.Windows.Forms.TextBox txtTransDescript;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDisplayAccts;
    }
}

