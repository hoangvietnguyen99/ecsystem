namespace ECSystem.GUI
{
    partial class fNCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxTenNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxSDTNCC = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonThem = new MaterialSkin.Controls.MaterialButton();
            this.multiLineTextBoxDiaChiNCC = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhà cung cấp:";
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNCC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewNCC.Location = new System.Drawing.Point(4, 86);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.ReadOnly = true;
            this.dataGridViewNCC.Size = new System.Drawing.Size(402, 314);
            this.dataGridViewNCC.TabIndex = 3;
            this.dataGridViewNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNCC_CellClick);
            this.dataGridViewNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNCC_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(412, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi tiết nhà cung cấp";
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaNCC.Depth = 0;
            this.textBoxMaNCC.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxMaNCC.Hint = "Mã NCC";
            this.textBoxMaNCC.Location = new System.Drawing.Point(412, 86);
            this.textBoxMaNCC.MaxLength = 50;
            this.textBoxMaNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMaNCC.Multiline = false;
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(202, 50);
            this.textBoxMaNCC.TabIndex = 5;
            this.textBoxMaNCC.Text = "";
            // 
            // textBoxTenNCC
            // 
            this.textBoxTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenNCC.Depth = 0;
            this.textBoxTenNCC.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxTenNCC.Hint = "Tên NCC";
            this.textBoxTenNCC.Location = new System.Drawing.Point(412, 142);
            this.textBoxTenNCC.MaxLength = 50;
            this.textBoxTenNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTenNCC.Multiline = false;
            this.textBoxTenNCC.Name = "textBoxTenNCC";
            this.textBoxTenNCC.Size = new System.Drawing.Size(202, 50);
            this.textBoxTenNCC.TabIndex = 6;
            this.textBoxTenNCC.Text = "";
            // 
            // textBoxSDTNCC
            // 
            this.textBoxSDTNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSDTNCC.Depth = 0;
            this.textBoxSDTNCC.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBoxSDTNCC.Hint = "Số điện thoại";
            this.textBoxSDTNCC.Location = new System.Drawing.Point(412, 305);
            this.textBoxSDTNCC.MaxLength = 50;
            this.textBoxSDTNCC.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSDTNCC.Multiline = false;
            this.textBoxSDTNCC.Name = "textBoxSDTNCC";
            this.textBoxSDTNCC.Size = new System.Drawing.Size(202, 50);
            this.textBoxSDTNCC.TabIndex = 7;
            this.textBoxSDTNCC.Text = "";
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonThem.Depth = 0;
            this.buttonThem.DrawShadows = true;
            this.buttonThem.HighEmphasis = true;
            this.buttonThem.Icon = null;
            this.buttonThem.Location = new System.Drawing.Point(412, 364);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(62, 36);
            this.buttonThem.TabIndex = 8;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonThem.UseAccentColor = false;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // multiLineTextBoxDiaChiNCC
            // 
            this.multiLineTextBoxDiaChiNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.multiLineTextBoxDiaChiNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.multiLineTextBoxDiaChiNCC.Depth = 0;
            this.multiLineTextBoxDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiLineTextBoxDiaChiNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.multiLineTextBoxDiaChiNCC.Hint = "Địa chỉ NCC";
            this.multiLineTextBoxDiaChiNCC.Location = new System.Drawing.Point(412, 198);
            this.multiLineTextBoxDiaChiNCC.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiLineTextBoxDiaChiNCC.Name = "multiLineTextBoxDiaChiNCC";
            this.multiLineTextBoxDiaChiNCC.Size = new System.Drawing.Size(202, 96);
            this.multiLineTextBoxDiaChiNCC.TabIndex = 9;
            this.multiLineTextBoxDiaChiNCC.Text = "";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(494, 364);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(50, 36);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Sửa";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(564, 364);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(50, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Xóa";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // fNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 406);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.multiLineTextBoxDiaChiNCC);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxSDTNCC);
            this.Controls.Add(this.textBoxTenNCC);
            this.Controls.Add(this.textBoxMaNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNCC);
            this.Name = "fNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox textBoxMaNCC;
        private MaterialSkin.Controls.MaterialTextBox textBoxTenNCC;
        private MaterialSkin.Controls.MaterialTextBox textBoxSDTNCC;
        private MaterialSkin.Controls.MaterialButton buttonThem;
        private MaterialSkin.Controls.MaterialMultiLineTextBox multiLineTextBoxDiaChiNCC;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}