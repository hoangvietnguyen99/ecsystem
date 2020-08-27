namespace ECSystem.GUI
{
    partial class fThemKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHuy = new MaterialSkin.Controls.MaterialButton();
            this.buttonThem = new MaterialSkin.Controls.MaterialButton();
            this.mlTextBoxNoiDung = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cbbMaKH = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxMaTin = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvDSKHDaThem = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTTKH = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMaKH = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxTenKH = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxSDT = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxDiaChi = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKHDaThem)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.mlTextBoxNoiDung);
            this.panel1.Controls.Add(this.cbbMaKH);
            this.panel1.Controls.Add(this.textBoxMaTin);
            this.panel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 387);
            this.panel1.TabIndex = 0;
            // 
            // buttonHuy
            // 
            this.buttonHuy.AutoSize = false;
            this.buttonHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonHuy.Depth = 0;
            this.buttonHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHuy.DrawShadows = true;
            this.buttonHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonHuy.HighEmphasis = true;
            this.buttonHuy.Icon = null;
            this.buttonHuy.Location = new System.Drawing.Point(227, 334);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 47);
            this.buttonHuy.TabIndex = 4;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonHuy.UseAccentColor = false;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = false;
            this.buttonThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonThem.Depth = 0;
            this.buttonThem.DrawShadows = true;
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThem.HighEmphasis = true;
            this.buttonThem.Icon = null;
            this.buttonThem.Location = new System.Drawing.Point(144, 334);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 47);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonThem.UseAccentColor = false;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // mlTextBoxNoiDung
            // 
            this.mlTextBoxNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlTextBoxNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlTextBoxNoiDung.Depth = 0;
            this.mlTextBoxNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlTextBoxNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlTextBoxNoiDung.Hint = "Nội dung tin";
            this.mlTextBoxNoiDung.Location = new System.Drawing.Point(3, 59);
            this.mlTextBoxNoiDung.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTextBoxNoiDung.Name = "mlTextBoxNoiDung";
            this.mlTextBoxNoiDung.ReadOnly = true;
            this.mlTextBoxNoiDung.Size = new System.Drawing.Size(300, 211);
            this.mlTextBoxNoiDung.TabIndex = 1;
            this.mlTextBoxNoiDung.Text = "";
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.AutoResize = false;
            this.cbbMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbbMaKH.Depth = 0;
            this.cbbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbMaKH.DropDownHeight = 174;
            this.cbbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKH.DropDownWidth = 121;
            this.cbbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Hint = "Mã khách hàng";
            this.cbbMaKH.IntegralHeight = false;
            this.cbbMaKH.ItemHeight = 43;
            this.cbbMaKH.Location = new System.Drawing.Point(3, 276);
            this.cbbMaKH.MaxDropDownItems = 4;
            this.cbbMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(299, 49);
            this.cbbMaKH.TabIndex = 2;
            // 
            // textBoxMaTin
            // 
            this.textBoxMaTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxMaTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaTin.Depth = 0;
            this.textBoxMaTin.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxMaTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMaTin.Hint = "Mã tin";
            this.textBoxMaTin.Location = new System.Drawing.Point(3, 3);
            this.textBoxMaTin.MaxLength = 50;
            this.textBoxMaTin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMaTin.Multiline = false;
            this.textBoxMaTin.Name = "textBoxMaTin";
            this.textBoxMaTin.ReadOnly = true;
            this.textBoxMaTin.Size = new System.Drawing.Size(300, 50);
            this.textBoxMaTin.TabIndex = 0;
            this.textBoxMaTin.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtgvDSKHDaThem);
            this.panel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(324, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 387);
            this.panel2.TabIndex = 1;
            // 
            // dtgvDSKHDaThem
            // 
            this.dtgvDSKHDaThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSKHDaThem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgvDSKHDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDSKHDaThem.DefaultCellStyle = dataGridViewCellStyle26;
            this.dtgvDSKHDaThem.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvDSKHDaThem.Location = new System.Drawing.Point(4, 28);
            this.dtgvDSKHDaThem.Name = "dtgvDSKHDaThem";
            this.dtgvDSKHDaThem.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSKHDaThem.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtgvDSKHDaThem.Size = new System.Drawing.Size(356, 353);
            this.dtgvDSKHDaThem.TabIndex = 3;
            this.dtgvDSKHDaThem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSKHDaThem_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.textBoxDiaChi);
            this.panel3.Controls.Add(this.textBoxSDT);
            this.panel3.Controls.Add(this.textBoxEmail);
            this.panel3.Controls.Add(this.textBoxTenKH);
            this.panel3.Controls.Add(this.textBoxMaKH);
            this.panel3.Controls.Add(this.labelTTKH);
            this.panel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(693, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 387);
            this.panel3.TabIndex = 2;
            // 
            // labelTTKH
            // 
            this.labelTTKH.AutoSize = true;
            this.labelTTKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelTTKH.Depth = 0;
            this.labelTTKH.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTTKH.Location = new System.Drawing.Point(3, 5);
            this.labelTTKH.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTTKH.Name = "labelTTKH";
            this.labelTTKH.Size = new System.Drawing.Size(156, 19);
            this.labelTTKH.TabIndex = 0;
            this.labelTTKH.Text = "Thông tin khách hàng";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaKH.Depth = 0;
            this.textBoxMaKH.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxMaKH.Hint = "Mã khách hàng";
            this.textBoxMaKH.Location = new System.Drawing.Point(3, 28);
            this.textBoxMaKH.MaxLength = 50;
            this.textBoxMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMaKH.Multiline = false;
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.ReadOnly = true;
            this.textBoxMaKH.Size = new System.Drawing.Size(136, 50);
            this.textBoxMaKH.TabIndex = 1;
            this.textBoxMaKH.Text = "";
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenKH.Depth = 0;
            this.textBoxTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxTenKH.Hint = "Tên khách hàng";
            this.textBoxTenKH.Location = new System.Drawing.Point(3, 82);
            this.textBoxTenKH.MaxLength = 50;
            this.textBoxTenKH.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTenKH.Multiline = false;
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.ReadOnly = true;
            this.textBoxTenKH.Size = new System.Drawing.Size(308, 50);
            this.textBoxTenKH.TabIndex = 2;
            this.textBoxTenKH.Text = "";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxEmail.Hint = "Email";
            this.textBoxEmail.Location = new System.Drawing.Point(3, 138);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxEmail.Multiline = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(308, 50);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSDT.Depth = 0;
            this.textBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxSDT.Hint = "Số điện thoại";
            this.textBoxSDT.Location = new System.Drawing.Point(3, 194);
            this.textBoxSDT.MaxLength = 50;
            this.textBoxSDT.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSDT.Multiline = false;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.ReadOnly = true;
            this.textBoxSDT.Size = new System.Drawing.Size(308, 50);
            this.textBoxSDT.TabIndex = 4;
            this.textBoxSDT.Text = "";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiaChi.Depth = 0;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDiaChi.Hint = "Địa chỉ";
            this.textBoxDiaChi.Location = new System.Drawing.Point(3, 250);
            this.textBoxDiaChi.MaxLength = 50;
            this.textBoxDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxDiaChi.Multiline = false;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxDiaChi.Size = new System.Drawing.Size(308, 50);
            this.textBoxDiaChi.TabIndex = 5;
            this.textBoxDiaChi.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khách hàng đã thêm";
            // 
            // fThemKhachHang
            // 
            this.AcceptButton = this.buttonThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonHuy;
            this.ClientSize = new System.Drawing.Size(1022, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fThemKhachHang";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKHDaThem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton buttonHuy;
        private MaterialSkin.Controls.MaterialButton buttonThem;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mlTextBoxNoiDung;
        private MaterialSkin.Controls.MaterialComboBox cbbMaKH;
        private MaterialSkin.Controls.MaterialTextBox textBoxMaTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvDSKHDaThem;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox textBoxDiaChi;
        private MaterialSkin.Controls.MaterialTextBox textBoxSDT;
        private MaterialSkin.Controls.MaterialTextBox textBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox textBoxTenKH;
        private MaterialSkin.Controls.MaterialTextBox textBoxMaKH;
        private MaterialSkin.Controls.MaterialLabel labelTTKH;
        private System.Windows.Forms.Label label1;
    }
}