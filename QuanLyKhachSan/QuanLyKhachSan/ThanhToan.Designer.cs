
namespace QuanLyKhachSan
{
    partial class ThanhToan
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
            this.btReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgThanhToan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.cbxMaPDP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(621, 87);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 58;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Mã PDP";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(180, 167);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(114, 20);
            this.txtTongtien.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(330, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Thanh Toán";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(531, 174);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 50;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(531, 129);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(75, 23);
            this.BtSua.TabIndex = 49;
            this.BtSua.Text = "Sửa";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(531, 87);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 48;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLap.Location = new System.Drawing.Point(180, 133);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(114, 20);
            this.dateNgayLap.TabIndex = 47;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(180, 94);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(114, 20);
            this.txtMaHD.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // dtgThanhToan
            // 
            this.dtgThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThanhToan.Location = new System.Drawing.Point(96, 251);
            this.dtgThanhToan.Name = "dtgThanhToan";
            this.dtgThanhToan.RowHeadersWidth = 51;
            this.dtgThanhToan.Size = new System.Drawing.Size(616, 182);
            this.dtgThanhToan.TabIndex = 39;
            this.dtgThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgThanhToan_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(389, 169);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(114, 20);
            this.txtTimKiem.TabIndex = 60;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(389, 94);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(114, 21);
            this.cbxMaNV.TabIndex = 61;
            // 
            // cbxMaPDP
            // 
            this.cbxMaPDP.FormattingEnabled = true;
            this.cbxMaPDP.Location = new System.Drawing.Point(389, 131);
            this.cbxMaPDP.Name = "cbxMaPDP";
            this.cbxMaPDP.Size = new System.Drawing.Size(114, 21);
            this.cbxMaPDP.TabIndex = 62;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxMaPDP);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgThanhToan);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgThanhToan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.ComboBox cbxMaPDP;
    }
}