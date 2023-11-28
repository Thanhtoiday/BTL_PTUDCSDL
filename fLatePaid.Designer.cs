namespace appBTLQlyTV
{
    partial class fLatePaid
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvLatePaidList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLateBook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLateDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmudNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLatePaidDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPaidDate = new System.Windows.Forms.DateTimePicker();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLatePaidList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tính thời gian trả muộn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvLatePaidList);
            this.panel2.Location = new System.Drawing.Point(446, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 690);
            this.panel2.TabIndex = 18;
            // 
            // dtgvLatePaidList
            // 
            this.dtgvLatePaidList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLatePaidList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLatePaidList.Location = new System.Drawing.Point(4, 4);
            this.dtgvLatePaidList.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvLatePaidList.Name = "dtgvLatePaidList";
            this.dtgvLatePaidList.RowHeadersWidth = 51;
            this.dtgvLatePaidList.Size = new System.Drawing.Size(1417, 683);
            this.dtgvLatePaidList.TabIndex = 0;
            this.dtgvLatePaidList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLatePaidList_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtLateBook);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLateDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nmudNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpLatePaidDate);
            this.panel1.Controls.Add(this.dtpPaidDate);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Location = new System.Drawing.Point(11, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 690);
            this.panel1.TabIndex = 17;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(193, 478);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(107, 58);
            this.btnDel.TabIndex = 39;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 608);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(403, 58);
            this.button2.TabIndex = 38;
            this.button2.Text = "Tính số tiền sách trả muộn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 543);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 58);
            this.button1.TabIndex = 37;
            this.button1.Text = "Tính tiền trả muộn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(313, 543);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 58);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(16, 478);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 58);
            this.btnCreate.TabIndex = 34;
            this.btnCreate.Text = "Lập phiếu ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(312, 478);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 58);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.Color.White;
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSum.Location = new System.Drawing.Point(312, 425);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(109, 34);
            this.txtSum.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Số tiền phạt";
            // 
            // txtLateBook
            // 
            this.txtLateBook.BackColor = System.Drawing.Color.White;
            this.txtLateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateBook.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLateBook.Location = new System.Drawing.Point(312, 367);
            this.txtLateBook.Margin = new System.Windows.Forms.Padding(4);
            this.txtLateBook.Name = "txtLateBook";
            this.txtLateBook.Size = new System.Drawing.Size(109, 34);
            this.txtLateBook.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Số tiền sách trả muộn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = " Tính ngày trả muộn";
            // 
            // txtLateDate
            // 
            this.txtLateDate.BackColor = System.Drawing.Color.White;
            this.txtLateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLateDate.Location = new System.Drawing.Point(312, 315);
            this.txtLateDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLateDate.Name = "txtLateDate";
            this.txtLateDate.ReadOnly = true;
            this.txtLateDate.Size = new System.Drawing.Size(109, 34);
            this.txtLateDate.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Số lượng";
            // 
            // nmudNumber
            // 
            this.nmudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudNumber.Location = new System.Drawing.Point(140, 137);
            this.nmudNumber.Margin = new System.Windows.Forms.Padding(4);
            this.nmudNumber.Name = "nmudNumber";
            this.nmudNumber.Size = new System.Drawing.Size(160, 34);
            this.nmudNumber.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày trả muộn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày trả";
            // 
            // dtpLatePaidDate
            // 
            this.dtpLatePaidDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLatePaidDate.CustomFormat = "dd/MM/yyyy";
            this.dtpLatePaidDate.Location = new System.Drawing.Point(4, 282);
            this.dtpLatePaidDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLatePaidDate.Name = "dtpLatePaidDate";
            this.dtpLatePaidDate.Size = new System.Drawing.Size(265, 22);
            this.dtpLatePaidDate.TabIndex = 10;
            // 
            // dtpPaidDate
            // 
            this.dtpPaidDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaidDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPaidDate.Location = new System.Drawing.Point(4, 218);
            this.dtpPaidDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.Size = new System.Drawing.Size(265, 22);
            this.dtpPaidDate.TabIndex = 9;
            this.dtpPaidDate.Value = new System.DateTime(2023, 11, 14, 0, 0, 0, 0);
            this.dtpPaidDate.ValueChanged += new System.EventHandler(this.dtpPaidDate_ValueChanged);
            // 
            // cbBook
            // 
            this.cbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(9, 75);
            this.cbBook.Margin = new System.Windows.Forms.Padding(4);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(364, 37);
            this.cbBook.TabIndex = 1;
            this.cbBook.Text = "Chọn sách";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(9, 15);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(364, 37);
            this.cbCustomer.TabIndex = 0;
            this.cbCustomer.Text = "Chọn khách hàng";
            // 
            // fLatePaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 818);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fLatePaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLatePaid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLatePaidList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvLatePaidList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLateBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmudNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpLatePaidDate;
        private System.Windows.Forms.DateTimePicker dtpPaidDate;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbCustomer;
    }
}