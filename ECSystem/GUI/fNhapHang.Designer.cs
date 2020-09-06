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
            this.comboBoxNCC = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonThemNCC = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChonDon = new MaterialSkin.Controls.MaterialButton();
            this.btXoa = new MaterialSkin.Controls.MaterialButton();
            this.btThem = new MaterialSkin.Controls.MaterialButton();
            this.btSua = new MaterialSkin.Controls.MaterialButton();
            this.tbTongTien = new MaterialSkin.Controls.MaterialTextBox();
            this.mltbLyDo = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbMaDonDH = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDonChuaDuyet = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonChuaDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.comboBoxNCC);
            this.panel1.Controls.Add(this.buttonThemNCC);
            this.panel1.Controls.Add(this.dateTimePickerNgayNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonChonDon);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.tbTongTien);
            this.panel1.Controls.Add(this.mltbLyDo);
            this.panel1.Controls.Add(this.tbMaDonDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewDonChuaDuyet);
            this.panel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 375);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxNCC
            // 
            this.comboBoxNCC.AutoResize = false;
            this.comboBoxNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.comboBoxNCC.Depth = 0;
            this.comboBoxNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxNCC.DropDownHeight = 174;
            this.comboBoxNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNCC.DropDownWidth = 121;
            this.comboBoxNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxNCC.FormattingEnabled = true;
            this.comboBoxNCC.IntegralHeight = false;
            this.comboBoxNCC.ItemHeight = 43;
            this.comboBoxNCC.Location = new System.Drawing.Point(734, 268);
            this.comboBoxNCC.MaxDropDownItems = 4;
            this.comboBoxNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxNCC.Name = "comboBoxNCC";
            this.comboBoxNCC.Size = new System.Drawing.Size(125, 49);
            this.comboBoxNCC.TabIndex = 19;
            // 
            // buttonThemNCC
            // 
            this.buttonThemNCC.AutoSize = false;
            this.buttonThemNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonThemNCC.Depth = 0;
            this.buttonThemNCC.DrawShadows = true;
            this.buttonThemNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThemNCC.HighEmphasis = true;
            this.buttonThemNCC.Icon = null;
            this.buttonThemNCC.Location = new System.Drawing.Point(734, 322);
            this.buttonThemNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonThemNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonThemNCC.Name = "buttonThemNCC";
            this.buttonThemNCC.Size = new System.Drawing.Size(125, 47);
            this.buttonThemNCC.TabIndex = 18;
            this.buttonThemNCC.Text = "Xem DS NCC";
            this.buttonThemNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonThemNCC.UseAccentColor = false;
            this.buttonThemNCC.UseVisualStyleBackColor = false;
            this.buttonThemNCC.Click += new System.EventHandler(this.buttonThemNCC_Click);
            // 
            // dateTimePickerNgayNhap
            // 
            this.dateTimePickerNgayNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dateTimePickerNgayNhap.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimePickerNgayNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePickerNgayNhap.Location = new System.Drawing.Point(734, 73);
            this.dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            this.dateTimePickerNgayNhap.Size = new System.Drawing.Size(283, 24);
            this.dateTimePickerNgayNhap.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(734, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lý do nhập:";
            // 
            // buttonChonDon
            // 
            this.buttonChonDon.AutoSize = false;
            this.buttonChonDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChonDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonChonDon.Depth = 0;
            this.buttonChonDon.DrawShadows = true;
            this.buttonChonDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonChonDon.HighEmphasis = true;
            this.buttonChonDon.Icon = null;
            this.buttonChonDon.Location = new System.Drawing.Point(865, 322);
            this.buttonChonDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonChonDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonChonDon.Name = "buttonChonDon";
            this.buttonChonDon.Size = new System.Drawing.Size(157, 47);
            this.buttonChonDon.TabIndex = 12;
            this.buttonChonDon.Text = "Chọn đơn này";
            this.buttonChonDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonChonDon.UseAccentColor = false;
            this.buttonChonDon.UseVisualStyleBackColor = false;
            this.buttonChonDon.Click += new System.EventHandler(this.buttonChonDon_Click);
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
            this.btXoa.Location = new System.Drawing.Point(975, 6);
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
            this.btThem.Location = new System.Drawing.Point(865, 6);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(47, 47);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThem.UseAccentColor = false;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
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
            this.btSua.Location = new System.Drawing.Point(920, 6);
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
            // tbTongTien
            // 
            this.tbTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Depth = 0;
            this.tbTongTien.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTongTien.Hint = "Tổng tiền";
            this.tbTongTien.Location = new System.Drawing.Point(865, 267);
            this.tbTongTien.MaxLength = 50;
            this.tbTongTien.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTongTien.Multiline = false;
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(157, 50);
            this.tbTongTien.TabIndex = 5;
            this.tbTongTien.Text = "";
            // 
            // mltbLyDo
            // 
            this.mltbLyDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbLyDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltbLyDo.Depth = 0;
            this.mltbLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbLyDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbLyDo.Hint = "Lý do nhập hàng";
            this.mltbLyDo.Location = new System.Drawing.Point(734, 135);
            this.mltbLyDo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbLyDo.Name = "mltbLyDo";
            this.mltbLyDo.Size = new System.Drawing.Size(289, 126);
            this.mltbLyDo.TabIndex = 4;
            this.mltbLyDo.Text = "";
            // 
            // tbMaDonDH
            // 
            this.tbMaDonDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbMaDonDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaDonDH.Depth = 0;
            this.tbMaDonDH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaDonDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbMaDonDH.Hint = "Mã đơn";
            this.tbMaDonDH.Location = new System.Drawing.Point(734, 6);
            this.tbMaDonDH.MaxLength = 50;
            this.tbMaDonDH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaDonDH.Multiline = false;
            this.tbMaDonDH.Name = "tbMaDonDH";
            this.tbMaDonDH.Size = new System.Drawing.Size(124, 50);
            this.tbMaDonDH.TabIndex = 2;
            this.tbMaDonDH.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Những đơn chưa được duyệt:";
            // 
            // dataGridViewDonChuaDuyet
            // 
            this.dataGridViewDonChuaDuyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDonChuaDuyet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDonChuaDuyet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDonChuaDuyet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewDonChuaDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonChuaDuyet.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewDonChuaDuyet.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewDonChuaDuyet.Name = "dataGridViewDonChuaDuyet";
            this.dataGridViewDonChuaDuyet.ReadOnly = true;
            this.dataGridViewDonChuaDuyet.Size = new System.Drawing.Size(725, 346);
            this.dataGridViewDonChuaDuyet.TabIndex = 1;
            this.dataGridViewDonChuaDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonChuaDuyet_CellClick);
            this.dataGridViewDonChuaDuyet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonChuaDuyet_CellContentClick);
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 442);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fNhapHang";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonChuaDuyet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDonChuaDuyet;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox tbTongTien;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbLyDo;
        private MaterialSkin.Controls.MaterialTextBox tbMaDonDH;
        private MaterialSkin.Controls.MaterialButton btXoa;
        private MaterialSkin.Controls.MaterialButton btThem;
        private MaterialSkin.Controls.MaterialButton btSua;
        private MaterialSkin.Controls.MaterialButton buttonChonDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhap;
        private MaterialSkin.Controls.MaterialButton buttonThemNCC;
        private MaterialSkin.Controls.MaterialComboBox comboBoxNCC;
    }
}