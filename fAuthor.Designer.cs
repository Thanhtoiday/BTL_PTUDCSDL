namespace appBTLQlyTV
{
    partial class fAuthor
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvAuthorList = new System.Windows.Forms.DataGridView();
            this.bntDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthorList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(159, 98);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(201, 29);
            this.txtYear.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvAuthorList);
            this.panel1.Location = new System.Drawing.Point(47, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 382);
            this.panel1.TabIndex = 26;
            // 
            // dtgvAuthorList
            // 
            this.dtgvAuthorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAuthorList.Location = new System.Drawing.Point(3, 3);
            this.dtgvAuthorList.Name = "dtgvAuthorList";
            this.dtgvAuthorList.Size = new System.Drawing.Size(320, 376);
            this.dtgvAuthorList.TabIndex = 0;
            this.dtgvAuthorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAuthorList_CellClick);
            this.dtgvAuthorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAuthorList_CellContentClick);
            // 
            // bntDel
            // 
            this.bntDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDel.Location = new System.Drawing.Point(266, 140);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(94, 47);
            this.bntDel.TabIndex = 24;
            this.bntDel.Text = "Xóa";
            this.bntDel.UseVisualStyleBackColor = true;
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(44, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 47);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Năm sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên tác giả";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(159, 55);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(201, 29);
            this.txtAuthorName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // fAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 583);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label2);
            this.Name = "fAuthor";
            this.Text = "fAuthor";
            this.Load += new System.EventHandler(this.fAuthor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvAuthorList;
        private System.Windows.Forms.Button bntDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
    }
}