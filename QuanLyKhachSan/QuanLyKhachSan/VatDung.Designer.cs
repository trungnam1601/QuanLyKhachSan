
namespace QuanLyKhachSan
{
    partial class VatDung
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
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.BtSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dtgVattu = new System.Windows.Forms.DataGridView();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.cbxMaLP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVattu)).BeginInit();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(642, 99);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 92;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(405, 143);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 90;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(405, 107);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 20);
            this.txtSoluong.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Mã Loại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Số Lượng";
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "Tốt",
            "Xấu"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(135, 182);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(114, 21);
            this.cbxTinhTrang.TabIndex = 83;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(534, 178);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 82;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // BtSua
            // 
            this.BtSua.Location = new System.Drawing.Point(534, 141);
            this.BtSua.Name = "BtSua";
            this.BtSua.Size = new System.Drawing.Size(75, 23);
            this.BtSua.TabIndex = 81;
            this.BtSua.Text = "Sửa";
            this.BtSua.UseVisualStyleBackColor = true;
            this.BtSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(534, 104);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 80;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtgVattu
            // 
            this.dtgVattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVattu.Location = new System.Drawing.Point(51, 238);
            this.dtgVattu.Name = "dtgVattu";
            this.dtgVattu.RowHeadersWidth = 51;
            this.dtgVattu.Size = new System.Drawing.Size(666, 187);
            this.dtgVattu.TabIndex = 79;
            this.dtgVattu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVattu_CellContentClick);
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(135, 147);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(114, 20);
            this.txtTenVT.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tên Vật Tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mã Vật Tư";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(293, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Quản Lý Vật Tư";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(135, 107);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(114, 20);
            this.txtMaVT.TabIndex = 93;
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
            this.cbxMaLP.Location = new System.Drawing.Point(405, 183);
            this.cbxMaLP.Name = "cbxMaLP";
            this.cbxMaLP.Size = new System.Drawing.Size(100, 21);
            this.cbxMaLP.TabIndex = 94;
            // 
            // VatDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.cbxMaLP);
            this.Controls.Add(this.txtMaVT);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTinhTrang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.BtSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgVattu);
            this.Controls.Add(this.txtTenVT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Name = "VatDung";
            this.Text = "VatDung";
            this.Load += new System.EventHandler(this.VatDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVattu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button BtSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dtgVattu;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.ComboBox cbxMaLP;
    }
}