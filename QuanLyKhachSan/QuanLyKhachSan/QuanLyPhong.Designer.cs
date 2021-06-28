
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMaLP = new System.Windows.Forms.ComboBox();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
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
            this.dtgPhong.RowHeadersWidth = 51;
            this.dtgPhong.Size = new System.Drawing.Size(666, 187);
            this.dtgPhong.TabIndex = 40;
            this.dtgPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhong_CellContentClick);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(528, 162);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 52;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(528, 125);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(75, 23);
            this.BtSua.TabIndex = 51;
            this.BtSua.Text = "Sửa";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(528, 88);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 50;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
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
            this.label6.Location = new System.Drawing.Point(299, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tên Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Số Người";
            // 
            // cbxMaLP
            // 
            this.cbxMaLP.FormattingEnabled = true;
            this.cbxMaLP.Items.AddRange(new object[] {
            "mlp002",
            "mlp003",
            "mlp004",
            "mlp005",
            "mlp006",
            "mlp007",
            "mlp008",
            "mlp009",
            "mlp010"});
            this.cbxMaLP.Location = new System.Drawing.Point(129, 95);
            this.cbxMaLP.Name = "cbxMaLP";
            this.cbxMaLP.Size = new System.Drawing.Size(114, 21);
            this.cbxMaLP.TabIndex = 69;
            this.cbxMaLP.SelectedIndexChanged += new System.EventHandler(this.cbxMaLP_SelectedIndexChanged);
            // 
            // txtTenLP
            // 
            this.txtTenLP.Location = new System.Drawing.Point(399, 91);
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.Size = new System.Drawing.Size(100, 20);
            this.txtTenLP.TabIndex = 70;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(399, 127);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 71;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(399, 171);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(100, 20);
            this.txtSoNguoi.TabIndex = 72;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(636, 83);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 73;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtSoNguoi);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenLP);
            this.Controls.Add(this.cbxMaLP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTinhTrang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgPhong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMaLP;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Button btReset;
    }
}