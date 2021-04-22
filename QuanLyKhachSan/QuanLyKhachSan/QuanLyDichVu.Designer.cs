
namespace QuanLyKhachSan
{
    partial class QuanLyDichVu
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
            this.btXoa = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgQuanLyDichVu = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuanLyDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(569, 198);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 61;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(569, 153);
            this.BtSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(100, 28);
            this.BtSua.TabIndex = 60;
            this.BtSua.Text = "Sửa";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click_1);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(569, 103);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 59;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(341, 150);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(151, 22);
            this.txtTenDV.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(341, 106);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(151, 22);
            this.txtMaDV.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Mã Dịch Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(377, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 31);
            this.label7.TabIndex = 63;
            this.label7.Text = "Quản Lý Dịch Vụ";
            // 
            // dtgQuanLyDichVu
            // 
            this.dtgQuanLyDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuanLyDichVu.Location = new System.Drawing.Point(120, 263);
            this.dtgQuanLyDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgQuanLyDichVu.Name = "dtgQuanLyDichVu";
            this.dtgQuanLyDichVu.RowHeadersWidth = 51;
            this.dtgQuanLyDichVu.Size = new System.Drawing.Size(728, 251);
            this.dtgQuanLyDichVu.TabIndex = 64;
            this.dtgQuanLyDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQuanLyDichVu_CellContentClick);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(341, 192);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(151, 22);
            this.txtDonGia.TabIndex = 65;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(704, 106);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(100, 28);
            this.btReset.TabIndex = 66;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 554);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.dtgQuanLyDichVu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyDichVu";
            this.Text = "QuanLyDichVu";
            this.Load += new System.EventHandler(this.QuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuanLyDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgQuanLyDichVu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btReset;
    }
}