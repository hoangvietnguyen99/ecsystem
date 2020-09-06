namespace ECSystem.GUI
{
    partial class fThemLoaiHang
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
            this.btThem = new MaterialSkin.Controls.MaterialButton();
            this.btHuy = new MaterialSkin.Controls.MaterialButton();
            this.tbTenLH = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMaLH = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
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
            this.btThem.Location = new System.Drawing.Point(85, 185);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(86, 47);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThem.UseAccentColor = false;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btHuy
            // 
            this.btHuy.AutoSize = false;
            this.btHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btHuy.Depth = 0;
            this.btHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btHuy.DrawShadows = true;
            this.btHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btHuy.HighEmphasis = true;
            this.btHuy.Icon = null;
            this.btHuy.Location = new System.Drawing.Point(179, 185);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(58, 47);
            this.btHuy.TabIndex = 3;
            this.btHuy.Text = "Hủy";
            this.btHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btHuy.UseAccentColor = false;
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // tbTenLH
            // 
            this.tbTenLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbTenLH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenLH.Depth = 0;
            this.tbTenLH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbTenLH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTenLH.Hint = "Tên loại hàng";
            this.tbTenLH.Location = new System.Drawing.Point(12, 126);
            this.tbTenLH.MaxLength = 50;
            this.tbTenLH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenLH.Multiline = false;
            this.tbTenLH.Name = "tbTenLH";
            this.tbTenLH.Size = new System.Drawing.Size(225, 50);
            this.tbTenLH.TabIndex = 1;
            this.tbTenLH.Text = "";
            // 
            // tbMaLH
            // 
            this.tbMaLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbMaLH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaLH.Depth = 0;
            this.tbMaLH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaLH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbMaLH.Hint = "Mã loại hàng";
            this.tbMaLH.Location = new System.Drawing.Point(12, 70);
            this.tbMaLH.MaxLength = 50;
            this.tbMaLH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaLH.Multiline = false;
            this.tbMaLH.Name = "tbMaLH";
            this.tbMaLH.Size = new System.Drawing.Size(225, 50);
            this.tbMaLH.TabIndex = 0;
            this.tbMaLH.Text = "";
            // 
            // fThemLoaiHang
            // 
            this.AcceptButton = this.btThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btHuy;
            this.ClientSize = new System.Drawing.Size(249, 242);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTenLH);
            this.Controls.Add(this.tbMaLH);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fThemLoaiHang";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm loại hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbMaLH;
        private MaterialSkin.Controls.MaterialTextBox tbTenLH;
        private MaterialSkin.Controls.MaterialButton btThem;
        private MaterialSkin.Controls.MaterialButton btHuy;
    }
}