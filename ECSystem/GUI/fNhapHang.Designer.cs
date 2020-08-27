namespace ECSystem.GUI
{
    partial class fNhapHang
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
            this.dtgvDSDonDHChuaDuyet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaDonDH = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNgayNhap = new MaterialSkin.Controls.MaterialTextBox();
            this.mltbLyDo = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbTongTien = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tbMaNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.btThayDoiNCC = new MaterialSkin.Controls.MaterialButton();
            this.btSua = new MaterialSkin.Controls.MaterialButton();
            this.btThem = new MaterialSkin.Controls.MaterialButton();
            this.btXoa = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonDHChuaDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThayDoiNCC);
            this.panel1.Controls.Add(this.tbMaNCC);
            this.panel1.Controls.Add(this.materialComboBox1);
            this.panel1.Controls.Add(this.tbTongTien);
            this.panel1.Controls.Add(this.mltbLyDo);
            this.panel1.Controls.Add(this.tbNgayNhap);
            this.panel1.Controls.Add(this.tbMaDonDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgvDSDonDHChuaDuyet);
            this.panel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 375);
            this.panel1.TabIndex = 0;
            // 
            // dtgvDSDonDHChuaDuyet
            // 
            this.dtgvDSDonDHChuaDuyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSDonDHChuaDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSDonDHChuaDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvDSDonDHChuaDuyet.Location = new System.Drawing.Point(3, 30);
            this.dtgvDSDonDHChuaDuyet.Name = "dtgvDSDonDHChuaDuyet";
            this.dtgvDSDonDHChuaDuyet.ReadOnly = true;
            this.dtgvDSDonDHChuaDuyet.Size = new System.Drawing.Size(475, 342);
            this.dtgvDSDonDHChuaDuyet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Những đơn chưa được duyệt";
            // 
            // tbMaDonDH
            // 
            this.tbMaDonDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaDonDH.Depth = 0;
            this.tbMaDonDH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaDonDH.Hint = "Mã đơn";
            this.tbMaDonDH.Location = new System.Drawing.Point(484, 30);
            this.tbMaDonDH.MaxLength = 50;
            this.tbMaDonDH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaDonDH.Multiline = false;
            this.tbMaDonDH.Name = "tbMaDonDH";
            this.tbMaDonDH.Size = new System.Drawing.Size(122, 50);
            this.tbMaDonDH.TabIndex = 2;
            this.tbMaDonDH.Text = "";
            // 
            // tbNgayNhap
            // 
            this.tbNgayNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNgayNhap.Depth = 0;
            this.tbNgayNhap.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbNgayNhap.Hint = "Ngày nhập đơn";
            this.tbNgayNhap.Location = new System.Drawing.Point(484, 86);
            this.tbNgayNhap.MaxLength = 50;
            this.tbNgayNhap.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNgayNhap.Multiline = false;
            this.tbNgayNhap.Name = "tbNgayNhap";
            this.tbNgayNhap.ReadOnly = true;
            this.tbNgayNhap.Size = new System.Drawing.Size(289, 50);
            this.tbNgayNhap.TabIndex = 3;
            this.tbNgayNhap.Text = "";
            // 
            // mltbLyDo
            // 
            this.mltbLyDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbLyDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltbLyDo.Depth = 0;
            this.mltbLyDo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbLyDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbLyDo.Hint = "Lý do nhập hàng";
            this.mltbLyDo.Location = new System.Drawing.Point(484, 142);
            this.mltbLyDo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbLyDo.Name = "mltbLyDo";
            this.mltbLyDo.Size = new System.Drawing.Size(289, 119);
            this.mltbLyDo.TabIndex = 4;
            this.mltbLyDo.Text = "";
            // 
            // tbTongTien
            // 
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Depth = 0;
            this.tbTongTien.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbTongTien.Hint = "Tổng tiền";
            this.tbTongTien.Location = new System.Drawing.Point(612, 267);
            this.tbTongTien.MaxLength = 50;
            this.tbTongTien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTien.Multiline = false;
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(160, 50);
            this.tbTongTien.TabIndex = 5;
            this.tbTongTien.Text = "";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Mã NCC";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(485, 323);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.TabIndex = 6;
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaNCC.Depth = 0;
            this.tbMaNCC.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaNCC.Hint = "Mã NCC";
            this.tbMaNCC.Location = new System.Drawing.Point(485, 267);
            this.tbMaNCC.MaxLength = 50;
            this.tbMaNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaNCC.Multiline = false;
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.ReadOnly = true;
            this.tbMaNCC.Size = new System.Drawing.Size(121, 50);
            this.tbMaNCC.TabIndex = 7;
            this.tbMaNCC.Text = "";
            // 
            // btThayDoiNCC
            // 
            this.btThayDoiNCC.AutoSize = false;
            this.btThayDoiNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThayDoiNCC.Depth = 0;
            this.btThayDoiNCC.DrawShadows = true;
            this.btThayDoiNCC.HighEmphasis = true;
            this.btThayDoiNCC.Icon = null;
            this.btThayDoiNCC.Location = new System.Drawing.Point(613, 323);
            this.btThayDoiNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btThayDoiNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThayDoiNCC.Name = "btThayDoiNCC";
            this.btThayDoiNCC.Size = new System.Drawing.Size(160, 49);
            this.btThayDoiNCC.TabIndex = 8;
            this.btThayDoiNCC.Text = "Thay đổi NCC";
            this.btThayDoiNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThayDoiNCC.UseAccentColor = false;
            this.btThayDoiNCC.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.AutoSize = false;
            this.btSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btSua.Depth = 0;
            this.btSua.DrawShadows = true;
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSua.HighEmphasis = true;
            this.btSua.Icon = null;
            this.btSua.Location = new System.Drawing.Point(615, 30);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(47, 47);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSua.UseAccentColor = false;
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.AutoSize = false;
            this.btThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btThem.Depth = 0;
            this.btThem.DrawShadows = true;
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.HighEmphasis = true;
            this.btThem.Icon = null;
            this.btThem.Location = new System.Drawing.Point(670, 30);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(47, 47);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThem.UseAccentColor = false;
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = false;
            this.btXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btXoa.Depth = 0;
            this.btXoa.DrawShadows = true;
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.HighEmphasis = true;
            this.btXoa.Icon = null;
            this.btXoa.Location = new System.Drawing.Point(725, 30);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(47, 47);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btXoa.UseAccentColor = false;
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fNhapHang";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonDHChuaDuyet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDSDonDHChuaDuyet;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox tbMaNCC;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox tbTongTien;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbLyDo;
        private MaterialSkin.Controls.MaterialTextBox tbNgayNhap;
        private MaterialSkin.Controls.MaterialTextBox tbMaDonDH;
        private MaterialSkin.Controls.MaterialButton btThayDoiNCC;
        private MaterialSkin.Controls.MaterialButton btXoa;
        private MaterialSkin.Controls.MaterialButton btThem;
        private MaterialSkin.Controls.MaterialButton btSua;
    }
}