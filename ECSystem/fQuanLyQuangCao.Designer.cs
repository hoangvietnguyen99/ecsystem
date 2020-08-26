namespace ECSystem
{
    partial class fQuanLyQuangCao
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
            this.dtgvDSTin = new System.Windows.Forms.DataGridView();
            this.buttonThemMoi = new MaterialSkin.Controls.MaterialButton();
            this.textBoxMaTin = new MaterialSkin.Controls.MaterialTextBox();
            this.mlTextBoxNoiDung = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.buttonXemDoiTac = new MaterialSkin.Controls.MaterialButton();
            this.buttonThemKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.buttonChinhSua = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSTin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonChinhSua);
            this.panel1.Controls.Add(this.buttonThemKhachHang);
            this.panel1.Controls.Add(this.buttonXemDoiTac);
            this.panel1.Controls.Add(this.mlTextBoxNoiDung);
            this.panel1.Controls.Add(this.textBoxMaTin);
            this.panel1.Controls.Add(this.buttonThemMoi);
            this.panel1.Controls.Add(this.dtgvDSTin);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 366);
            this.panel1.TabIndex = 0;
            // 
            // dtgvDSTin
            // 
            this.dtgvDSTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvDSTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSTin.Location = new System.Drawing.Point(3, 6);
            this.dtgvDSTin.Name = "dtgvDSTin";
            this.dtgvDSTin.ReadOnly = true;
            this.dtgvDSTin.Size = new System.Drawing.Size(474, 357);
            this.dtgvDSTin.TabIndex = 0;
            this.dtgvDSTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSTin_CellClick);
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.AutoSize = false;
            this.buttonThemMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonThemMoi.Depth = 0;
            this.buttonThemMoi.DrawShadows = true;
            this.buttonThemMoi.HighEmphasis = true;
            this.buttonThemMoi.Icon = null;
            this.buttonThemMoi.Location = new System.Drawing.Point(682, 6);
            this.buttonThemMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonThemMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(90, 47);
            this.buttonThemMoi.TabIndex = 0;
            this.buttonThemMoi.Text = "Thêm";
            this.buttonThemMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonThemMoi.UseAccentColor = false;
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            this.buttonThemMoi.Click += new System.EventHandler(this.btnThemQuangCao_Click);
            // 
            // textBoxMaTin
            // 
            this.textBoxMaTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaTin.Depth = 0;
            this.textBoxMaTin.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxMaTin.Hint = "Mã tin";
            this.textBoxMaTin.Location = new System.Drawing.Point(484, 6);
            this.textBoxMaTin.MaxLength = 50;
            this.textBoxMaTin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMaTin.Multiline = false;
            this.textBoxMaTin.Name = "textBoxMaTin";
            this.textBoxMaTin.Size = new System.Drawing.Size(93, 50);
            this.textBoxMaTin.TabIndex = 1;
            this.textBoxMaTin.Text = "";
            this.textBoxMaTin.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // mlTextBoxNoiDung
            // 
            this.mlTextBoxNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlTextBoxNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlTextBoxNoiDung.Depth = 0;
            this.mlTextBoxNoiDung.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlTextBoxNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlTextBoxNoiDung.Hint = "Nội dung tin";
            this.mlTextBoxNoiDung.Location = new System.Drawing.Point(484, 62);
            this.mlTextBoxNoiDung.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTextBoxNoiDung.Name = "mlTextBoxNoiDung";
            this.mlTextBoxNoiDung.Size = new System.Drawing.Size(288, 253);
            this.mlTextBoxNoiDung.TabIndex = 2;
            this.mlTextBoxNoiDung.Text = "";
            // 
            // buttonXemDoiTac
            // 
            this.buttonXemDoiTac.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonXemDoiTac.Depth = 0;
            this.buttonXemDoiTac.DrawShadows = true;
            this.buttonXemDoiTac.HighEmphasis = true;
            this.buttonXemDoiTac.Icon = null;
            this.buttonXemDoiTac.Location = new System.Drawing.Point(484, 324);
            this.buttonXemDoiTac.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonXemDoiTac.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonXemDoiTac.Name = "buttonXemDoiTac";
            this.buttonXemDoiTac.Size = new System.Drawing.Size(122, 36);
            this.buttonXemDoiTac.TabIndex = 3;
            this.buttonXemDoiTac.Text = "Xem đối tác";
            this.buttonXemDoiTac.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonXemDoiTac.UseAccentColor = false;
            this.buttonXemDoiTac.UseVisualStyleBackColor = true;
            this.buttonXemDoiTac.Click += new System.EventHandler(this.buttonThemDoiTac_Click);
            // 
            // buttonThemKhachHang
            // 
            this.buttonThemKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonThemKhachHang.Depth = 0;
            this.buttonThemKhachHang.DrawShadows = true;
            this.buttonThemKhachHang.HighEmphasis = true;
            this.buttonThemKhachHang.Icon = null;
            this.buttonThemKhachHang.Location = new System.Drawing.Point(612, 324);
            this.buttonThemKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonThemKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonThemKhachHang.Name = "buttonThemKhachHang";
            this.buttonThemKhachHang.Size = new System.Drawing.Size(160, 36);
            this.buttonThemKhachHang.TabIndex = 4;
            this.buttonThemKhachHang.Text = "Thêm khách hàng";
            this.buttonThemKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonThemKhachHang.UseAccentColor = false;
            this.buttonThemKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonChinhSua
            // 
            this.buttonChinhSua.AutoSize = false;
            this.buttonChinhSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChinhSua.Depth = 0;
            this.buttonChinhSua.DrawShadows = true;
            this.buttonChinhSua.HighEmphasis = true;
            this.buttonChinhSua.Icon = null;
            this.buttonChinhSua.Location = new System.Drawing.Point(584, 6);
            this.buttonChinhSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonChinhSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.Size = new System.Drawing.Size(90, 47);
            this.buttonChinhSua.TabIndex = 5;
            this.buttonChinhSua.Text = "Sửa";
            this.buttonChinhSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonChinhSua.UseAccentColor = false;
            this.buttonChinhSua.UseVisualStyleBackColor = true;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // fQuanLyQuangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyQuangCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý quảng cáo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton buttonThemMoi;
        private System.Windows.Forms.DataGridView dtgvDSTin;
        private MaterialSkin.Controls.MaterialButton buttonThemKhachHang;
        private MaterialSkin.Controls.MaterialButton buttonXemDoiTac;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mlTextBoxNoiDung;
        private MaterialSkin.Controls.MaterialTextBox textBoxMaTin;
        private MaterialSkin.Controls.MaterialButton buttonChinhSua;
    }
}