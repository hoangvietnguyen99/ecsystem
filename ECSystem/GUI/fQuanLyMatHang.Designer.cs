namespace ECSystem.GUI
{
    partial class fQuanLyMatHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNhapThemHang = new MaterialSkin.Controls.MaterialButton();
            this.textBoxLHMH = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxSoLuongTon = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxGiaTien = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonNhapHangMoi = new MaterialSkin.Controls.MaterialButton();
            this.tbTenMH = new MaterialSkin.Controls.MaterialTextBox();
            this.cbbLoaiHang = new MaterialSkin.Controls.MaterialComboBox();
            this.tbMaMH = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgvDSMatHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.buttonNhapThemHang);
            this.panel1.Controls.Add(this.textBoxLHMH);
            this.panel1.Controls.Add(this.textBoxSoLuongTon);
            this.panel1.Controls.Add(this.textBoxGiaTien);
            this.panel1.Controls.Add(this.buttonNhapHangMoi);
            this.panel1.Controls.Add(this.tbTenMH);
            this.panel1.Controls.Add(this.cbbLoaiHang);
            this.panel1.Controls.Add(this.tbMaMH);
            this.panel1.Controls.Add(this.dtgvDSMatHang);
            this.panel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(4, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 340);
            this.panel1.TabIndex = 0;
            // 
            // buttonNhapThemHang
            // 
            this.buttonNhapThemHang.AutoSize = false;
            this.buttonNhapThemHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNhapThemHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonNhapThemHang.Depth = 0;
            this.buttonNhapThemHang.DrawShadows = true;
            this.buttonNhapThemHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNhapThemHang.HighEmphasis = true;
            this.buttonNhapThemHang.Icon = null;
            this.buttonNhapThemHang.Location = new System.Drawing.Point(632, 6);
            this.buttonNhapThemHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNhapThemHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNhapThemHang.Name = "buttonNhapThemHang";
            this.buttonNhapThemHang.Size = new System.Drawing.Size(139, 47);
            this.buttonNhapThemHang.TabIndex = 3;
            this.buttonNhapThemHang.Text = "Nhập thêm hàng";
            this.buttonNhapThemHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonNhapThemHang.UseAccentColor = false;
            this.buttonNhapThemHang.UseVisualStyleBackColor = false;
            this.buttonNhapThemHang.Click += new System.EventHandler(this.buttonNhapThemHang_Click);
            // 
            // textBoxLHMH
            // 
            this.textBoxLHMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxLHMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLHMH.Depth = 0;
            this.textBoxLHMH.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxLHMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxLHMH.Hint = "Thuộc loại hàng";
            this.textBoxLHMH.Location = new System.Drawing.Point(483, 286);
            this.textBoxLHMH.MaxLength = 50;
            this.textBoxLHMH.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLHMH.Multiline = false;
            this.textBoxLHMH.Name = "textBoxLHMH";
            this.textBoxLHMH.ReadOnly = true;
            this.textBoxLHMH.Size = new System.Drawing.Size(288, 50);
            this.textBoxLHMH.TabIndex = 9;
            this.textBoxLHMH.Text = "";
            // 
            // textBoxSoLuongTon
            // 
            this.textBoxSoLuongTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxSoLuongTon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoLuongTon.Depth = 0;
            this.textBoxSoLuongTon.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxSoLuongTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxSoLuongTon.Hint = "Số lượng tồn";
            this.textBoxSoLuongTon.Location = new System.Drawing.Point(483, 230);
            this.textBoxSoLuongTon.MaxLength = 50;
            this.textBoxSoLuongTon.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSoLuongTon.Multiline = false;
            this.textBoxSoLuongTon.Name = "textBoxSoLuongTon";
            this.textBoxSoLuongTon.ReadOnly = true;
            this.textBoxSoLuongTon.Size = new System.Drawing.Size(288, 50);
            this.textBoxSoLuongTon.TabIndex = 8;
            this.textBoxSoLuongTon.Text = "";
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGiaTien.Depth = 0;
            this.textBoxGiaTien.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxGiaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxGiaTien.Hint = "Giá tiền";
            this.textBoxGiaTien.Location = new System.Drawing.Point(483, 174);
            this.textBoxGiaTien.MaxLength = 50;
            this.textBoxGiaTien.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxGiaTien.Multiline = false;
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.ReadOnly = true;
            this.textBoxGiaTien.Size = new System.Drawing.Size(288, 50);
            this.textBoxGiaTien.TabIndex = 7;
            this.textBoxGiaTien.Text = "";
            // 
            // buttonNhapHangMoi
            // 
            this.buttonNhapHangMoi.AutoSize = false;
            this.buttonNhapHangMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNhapHangMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonNhapHangMoi.Depth = 0;
            this.buttonNhapHangMoi.DrawShadows = true;
            this.buttonNhapHangMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNhapHangMoi.HighEmphasis = true;
            this.buttonNhapHangMoi.Icon = null;
            this.buttonNhapHangMoi.Location = new System.Drawing.Point(485, 6);
            this.buttonNhapHangMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNhapHangMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNhapHangMoi.Name = "buttonNhapHangMoi";
            this.buttonNhapHangMoi.Size = new System.Drawing.Size(139, 47);
            this.buttonNhapHangMoi.TabIndex = 2;
            this.buttonNhapHangMoi.Text = "Nhập hàng mới";
            this.buttonNhapHangMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonNhapHangMoi.UseAccentColor = false;
            this.buttonNhapHangMoi.UseVisualStyleBackColor = false;
            this.buttonNhapHangMoi.Click += new System.EventHandler(this.btNhapHang_Click);
            // 
            // tbTenMH
            // 
            this.tbTenMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbTenMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenMH.Depth = 0;
            this.tbTenMH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbTenMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTenMH.Hint = "Tên mặt hàng";
            this.tbTenMH.Location = new System.Drawing.Point(483, 118);
            this.tbTenMH.MaxLength = 50;
            this.tbTenMH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenMH.Multiline = false;
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.ReadOnly = true;
            this.tbTenMH.Size = new System.Drawing.Size(288, 50);
            this.tbTenMH.TabIndex = 6;
            this.tbTenMH.Text = "";
            // 
            // cbbLoaiHang
            // 
            this.cbbLoaiHang.AutoResize = false;
            this.cbbLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbbLoaiHang.Depth = 0;
            this.cbbLoaiHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbLoaiHang.DropDownHeight = 174;
            this.cbbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHang.DropDownWidth = 121;
            this.cbbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbLoaiHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbLoaiHang.FormattingEnabled = true;
            this.cbbLoaiHang.Hint = "Chọn loại hàng";
            this.cbbLoaiHang.IntegralHeight = false;
            this.cbbLoaiHang.ItemHeight = 43;
            this.cbbLoaiHang.Location = new System.Drawing.Point(3, 7);
            this.cbbLoaiHang.MaxDropDownItems = 4;
            this.cbbLoaiHang.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbLoaiHang.Name = "cbbLoaiHang";
            this.cbbLoaiHang.Size = new System.Drawing.Size(277, 49);
            this.cbbLoaiHang.TabIndex = 0;
            this.cbbLoaiHang.SelectedValueChanged += new System.EventHandler(this.cbbLoaiHang_SelectedValueChanged);
            // 
            // tbMaMH
            // 
            this.tbMaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbMaMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaMH.Depth = 0;
            this.tbMaMH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbMaMH.Hint = "Mã mặt hàng";
            this.tbMaMH.Location = new System.Drawing.Point(483, 62);
            this.tbMaMH.MaxLength = 50;
            this.tbMaMH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaMH.Multiline = false;
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.ReadOnly = true;
            this.tbMaMH.Size = new System.Drawing.Size(288, 50);
            this.tbMaMH.TabIndex = 5;
            this.tbMaMH.Text = "";
            // 
            // dtgvDSMatHang
            // 
            this.dtgvDSMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSMatHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDSMatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDSMatHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvDSMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSMatHang.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvDSMatHang.Location = new System.Drawing.Point(3, 62);
            this.dtgvDSMatHang.Name = "dtgvDSMatHang";
            this.dtgvDSMatHang.ReadOnly = true;
            this.dtgvDSMatHang.Size = new System.Drawing.Size(474, 274);
            this.dtgvDSMatHang.TabIndex = 4;
            this.dtgvDSMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSMatHang_CellClick);
            this.dtgvDSMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSMatHang_CellContentClick);
            // 
            // fQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 408);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fQuanLyMatHang";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê mặt hàng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox tbTenMH;
        private MaterialSkin.Controls.MaterialComboBox cbbLoaiHang;
        private MaterialSkin.Controls.MaterialTextBox tbMaMH;
        private System.Windows.Forms.DataGridView dtgvDSMatHang;
        private MaterialSkin.Controls.MaterialButton buttonNhapHangMoi;
        private MaterialSkin.Controls.MaterialTextBox textBoxLHMH;
        private MaterialSkin.Controls.MaterialTextBox textBoxSoLuongTon;
        private MaterialSkin.Controls.MaterialTextBox textBoxGiaTien;
        private MaterialSkin.Controls.MaterialButton buttonNhapThemHang;
    }
}