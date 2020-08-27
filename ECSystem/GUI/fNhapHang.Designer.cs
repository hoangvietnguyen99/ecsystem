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
            this.tbMaDNH = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNgayNhap = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNgayNhap);
            this.panel1.Controls.Add(this.tbMaDNH);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 375);
            this.panel1.TabIndex = 0;
            // 
            // tbMaDNH
            // 
            this.tbMaDNH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaDNH.Depth = 0;
            this.tbMaDNH.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbMaDNH.Hint = "Mã đơn";
            this.tbMaDNH.Location = new System.Drawing.Point(3, 3);
            this.tbMaDNH.MaxLength = 50;
            this.tbMaDNH.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaDNH.Multiline = false;
            this.tbMaDNH.Name = "tbMaDNH";
            this.tbMaDNH.Size = new System.Drawing.Size(100, 50);
            this.tbMaDNH.TabIndex = 0;
            this.tbMaDNH.Text = "";
            // 
            // tbNgayNhap
            // 
            this.tbNgayNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNgayNhap.Depth = 0;
            this.tbNgayNhap.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbNgayNhap.Hint = "Ngày nhập";
            this.tbNgayNhap.Location = new System.Drawing.Point(109, 3);
            this.tbNgayNhap.MaxLength = 50;
            this.tbNgayNhap.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNgayNhap.Multiline = false;
            this.tbNgayNhap.Name = "tbNgayNhap";
            this.tbNgayNhap.ReadOnly = true;
            this.tbNgayNhap.Size = new System.Drawing.Size(100, 50);
            this.tbNgayNhap.TabIndex = 1;
            this.tbNgayNhap.Text = "";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox tbNgayNhap;
        private MaterialSkin.Controls.MaterialTextBox tbMaDNH;
    }
}