
namespace QuanLyKhachSan
{
    partial class QuanLyPhong
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbxSonguoi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(287, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quản Lý Phòng";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(129, 131);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(114, 20);
            this.txtSoPhong.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Số Phòng";
            // 
            // txtMaLP
            // 
            this.txtMaLP.Location = new System.Drawing.Point(129, 95);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(114, 20);
            this.txtMaLP.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã Loại Phòng";
            // 
            // dtgPhong
            // 
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.Location = new System.Drawing.Point(45, 222);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.Size = new System.Drawing.Size(666, 187);
            this.dtgPhong.TabIndex = 40;
            this.dtgPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhong_CellContentClick);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(268, 167);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 52;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(268, 130);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(75, 23);
            this.BtSua.TabIndex = 51;
            this.BtSua.Text = "Sửa";
            this.BtSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(268, 93);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 50;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "Trống",
            "Đang Dùng"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(129, 166);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(114, 21);
            this.cbxTinhTrang.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tên Loại Phòng";
            // 
            // cbxGia
            // 
            this.cbxGia.FormattingEnabled = true;
            this.cbxGia.Location = new System.Drawing.Point(495, 128);
            this.cbxGia.Name = "cbxGia";
            this.cbxGia.Size = new System.Drawing.Size(114, 21);
            this.cbxGia.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 64;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Số Người";
            // 
            // cbxTenLoaiPhong
            // 
            this.cbxTenLoaiPhong.FormattingEnabled = true;
            this.cbxTenLoaiPhong.Location = new System.Drawing.Point(495, 91);
            this.cbxTenLoaiPhong.Name = "cbxTenLoaiPhong";
            this.cbxTenLoaiPhong.Size = new System.Drawing.Size(114, 21);
            this.cbxTenLoaiPhong.TabIndex = 67;
            // 
            // cbxSonguoi
            // 
            this.cbxSonguoi.FormattingEnabled = true;
            this.cbxSonguoi.Location = new System.Drawing.Point(495, 173);
            this.cbxSonguoi.Name = "cbxSonguoi";
            this.cbxSonguoi.Size = new System.Drawing.Size(114, 21);
            this.cbxSonguoi.TabIndex = 68;
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.cbxSonguoi);
            this.Controls.Add(this.cbxTenLoaiPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTinhTrang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgPhong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Name = "QuanLyPhong";
            this.Text = "QuanLyPhong";
            this.Load += new System.EventHandler(this.QuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTenLoaiPhong;
        private System.Windows.Forms.ComboBox cbxSonguoi;
    }
}