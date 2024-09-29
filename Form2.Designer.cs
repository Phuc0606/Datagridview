namespace BTDatagridview
{
    partial class Form2
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptnThem = new System.Windows.Forms.Button();
            this.ptnSua = new System.Windows.Forms.Button();
            this.ptnXoa = new System.Windows.Forms.Button();
            this.ptnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNV.Location = new System.Drawing.Point(23, 29);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(549, 409);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSNV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lương CB";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // ptnThem
            // 
            this.ptnThem.Location = new System.Drawing.Point(655, 29);
            this.ptnThem.Name = "ptnThem";
            this.ptnThem.Size = new System.Drawing.Size(75, 49);
            this.ptnThem.TabIndex = 1;
            this.ptnThem.Text = "Thêm";
            this.ptnThem.UseVisualStyleBackColor = true;
            this.ptnThem.Click += new System.EventHandler(this.ptnThem_Click);
            // 
            // ptnSua
            // 
            this.ptnSua.Location = new System.Drawing.Point(655, 101);
            this.ptnSua.Name = "ptnSua";
            this.ptnSua.Size = new System.Drawing.Size(75, 45);
            this.ptnSua.TabIndex = 2;
            this.ptnSua.Text = "Sửa";
            this.ptnSua.UseVisualStyleBackColor = true;
            this.ptnSua.Click += new System.EventHandler(this.ptnSua_Click);
            // 
            // ptnXoa
            // 
            this.ptnXoa.Location = new System.Drawing.Point(655, 169);
            this.ptnXoa.Name = "ptnXoa";
            this.ptnXoa.Size = new System.Drawing.Size(75, 48);
            this.ptnXoa.TabIndex = 3;
            this.ptnXoa.Text = "Xóa";
            this.ptnXoa.UseVisualStyleBackColor = true;
            this.ptnXoa.Click += new System.EventHandler(this.ptnXoa_Click);
            // 
            // ptnDong
            // 
            this.ptnDong.Location = new System.Drawing.Point(655, 258);
            this.ptnDong.Name = "ptnDong";
            this.ptnDong.Size = new System.Drawing.Size(75, 48);
            this.ptnDong.TabIndex = 4;
            this.ptnDong.Text = "Đóng";
            this.ptnDong.UseVisualStyleBackColor = true;
            this.ptnDong.Click += new System.EventHandler(this.ptnDong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptnDong);
            this.Controls.Add(this.ptnXoa);
            this.Controls.Add(this.ptnSua);
            this.Controls.Add(this.ptnThem);
            this.Controls.Add(this.dgvNV);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button ptnThem;
        private System.Windows.Forms.Button ptnSua;
        private System.Windows.Forms.Button ptnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button ptnDong;
    }
}