namespace ECSystem.GUI
{
    partial class fQuanLy
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
            this.tcQuanLy = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radiobtChuaDuocDuyet = new MaterialSkin.Controls.MaterialRadioButton();
            this.tbMaDon = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNgayLapDon = new MaterialSkin.Controls.MaterialTextBox();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbMaNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.tb = new MaterialSkin.Controls.MaterialTextBox();
            this.tcQuanLy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcQuanLy
            // 
            this.tcQuanLy.Controls.Add(this.tabPage1);
            this.tcQuanLy.Controls.Add(this.tpNhanVien);
            this.tcQuanLy.Depth = 0;
            this.tcQuanLy.Location = new System.Drawing.Point(2, 64);
            this.tcQuanLy.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcQuanLy.Name = "tcQuanLy";
            this.tcQuanLy.SelectedIndex = 0;
            this.tcQuanLy.Size = new System.Drawing.Size(798, 387);
            this.tcQuanLy.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb);
            this.tabPage1.Controls.Add(this.tbMaNCC);
            this.tabPage1.Controls.Add(this.materialMultiLineTextBox1);
            this.tabPage1.Controls.Add(this.tbNgayLapDon);
            this.tabPage1.Controls.Add(this.tbMaDon);
            this.tabPage1.Controls.Add(this.radiobtChuaDuocDuyet);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đơn nhập hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVien.Size = new System.Drawing.Size(790, 380);
            this.tpNhanVien.TabIndex = 1;
            this.tpNhanVien.Text = "Nhân viên";
            this.tpNhanVien.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // radiobtChuaDuocDuyet
            // 
            this.radiobtChuaDuocDuyet.AutoSize = true;
            this.radiobtChuaDuocDuyet.Depth = 0;
            this.radiobtChuaDuocDuyet.Location = new System.Drawing.Point(482, 6);
            this.radiobtChuaDuocDuyet.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtChuaDuocDuyet.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtChuaDuocDuyet.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtChuaDuocDuyet.Name = "radiobtChuaDuocDuyet";
            this.radiobtChuaDuocDuyet.Ripple = true;
            this.radiobtChuaDuocDuyet.Size = new System.Drawing.Size(157, 37);
            this.radiobtChuaDuocDuyet.TabIndex = 1;
            this.radiobtChuaDuocDuyet.TabStop = true;
            this.radiobtChuaDuocDuyet.Text = "Chưa được duyệt";
            this.radiobtChuaDuocDuyet.UseVisualStyleBackColor = true;
            // 
            // tbMaDon
            // 
            this.tbMaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaDon.Depth = 0;
            this.tbMaDon.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaDon.Hint = "Mã đơn";
            this.tbMaDon.Location = new System.Drawing.Point(482, 46);
            this.tbMaDon.MaxLength = 50;
            this.tbMaDon.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaDon.Multiline = false;
            this.tbMaDon.Name = "tbMaDon";
            this.tbMaDon.ReadOnly = true;
            this.tbMaDon.Size = new System.Drawing.Size(100, 50);
            this.tbMaDon.TabIndex = 2;
            this.tbMaDon.Text = "";
            // 
            // tbNgayLapDon
            // 
            this.tbNgayLapDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNgayLapDon.Depth = 0;
            this.tbNgayLapDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNgayLapDon.Hint = "Ngày lập đơn";
            this.tbNgayLapDon.Location = new System.Drawing.Point(588, 46);
            this.tbNgayLapDon.MaxLength = 50;
            this.tbNgayLapDon.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNgayLapDon.Multiline = false;
            this.tbNgayLapDon.Name = "tbNgayLapDon";
            this.tbNgayLapDon.ReadOnly = true;
            this.tbNgayLapDon.Size = new System.Drawing.Size(194, 50);
            this.tbNgayLapDon.TabIndex = 3;
            this.tbNgayLapDon.Text = "";
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Hint = "";
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(482, 102);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.ReadOnly = true;
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(300, 60);
            this.materialMultiLineTextBox1.TabIndex = 4;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaNCC.Depth = 0;
            this.tbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbMaNCC.Hint = "Mã NCC";
            this.tbMaNCC.Location = new System.Drawing.Point(482, 168);
            this.tbMaNCC.MaxLength = 50;
            this.tbMaNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaNCC.Multiline = false;
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.ReadOnly = true;
            this.tbMaNCC.Size = new System.Drawing.Size(100, 50);
            this.tbMaNCC.TabIndex = 5;
            this.tbMaNCC.Text = "";
            // 
            // tb
            // 
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Depth = 0;
            this.tb.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb.Hint = "Tổng tiền";
            this.tb.Location = new System.Drawing.Point(588, 169);
            this.tb.MaxLength = 50;
            this.tb.MouseState = MaterialSkin.MouseState.OUT;
            this.tb.Multiline = false;
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(194, 50);
            this.tb.TabIndex = 6;
            this.tb.Text = "";
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcQuanLy);
            this.DrawerTabControl = this.tcQuanLy;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fQuanLy";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý";
            this.tcQuanLy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcQuanLy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpNhanVien;
        private MaterialSkin.Controls.MaterialTextBox tb;
        private MaterialSkin.Controls.MaterialTextBox tbMaNCC;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialTextBox tbNgayLapDon;
        private MaterialSkin.Controls.MaterialTextBox tbMaDon;
        private MaterialSkin.Controls.MaterialRadioButton radiobtChuaDuocDuyet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}