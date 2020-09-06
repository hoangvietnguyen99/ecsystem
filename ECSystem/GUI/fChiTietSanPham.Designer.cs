namespace ECSystem.GUI
{
    partial class fChiTietSanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.muaHang = new System.Windows.Forms.Button();
            this.quayLai = new System.Windows.Forms.Button();
            this.ten_mh = new System.Windows.Forms.Label();
            this.giaTien = new System.Windows.Forms.Label();
            this.sl_ton = new System.Windows.Forms.Label();
            this.HinhAnh = new System.Windows.Forms.PictureBox();
            this.soLuongMua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "có sẵn";
            // 
            // muaHang
            // 
            this.muaHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaHang.Location = new System.Drawing.Point(585, 262);
            this.muaHang.Name = "muaHang";
            this.muaHang.Size = new System.Drawing.Size(168, 46);
            this.muaHang.TabIndex = 5;
            this.muaHang.Text = "Mua Ngay";
            this.muaHang.UseVisualStyleBackColor = false;
            this.muaHang.Click += new System.EventHandler(this.muaHang_Click);
            // 
            // quayLai
            // 
            this.quayLai.BackColor = System.Drawing.Color.Azure;
            this.quayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLai.Location = new System.Drawing.Point(388, 262);
            this.quayLai.Name = "quayLai";
            this.quayLai.Size = new System.Drawing.Size(178, 46);
            this.quayLai.TabIndex = 6;
            this.quayLai.Text = "Quay Lại";
            this.quayLai.UseVisualStyleBackColor = false;
            this.quayLai.Click += new System.EventHandler(this.quayLai_Click);
            // 
            // ten_mh
            // 
            this.ten_mh.AutoSize = true;
            this.ten_mh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_mh.Location = new System.Drawing.Point(387, 34);
            this.ten_mh.Name = "ten_mh";
            this.ten_mh.Size = new System.Drawing.Size(94, 31);
            this.ten_mh.TabIndex = 8;
            this.ten_mh.Text = "tenmh";
            // 
            // giaTien
            // 
            this.giaTien.AutoSize = true;
            this.giaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaTien.Location = new System.Drawing.Point(386, 124);
            this.giaTien.Name = "giaTien";
            this.giaTien.Size = new System.Drawing.Size(102, 29);
            this.giaTien.TabIndex = 9;
            this.giaTien.Text = "giaTien";
            // 
            // sl_ton
            // 
            this.sl_ton.AutoSize = true;
            this.sl_ton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_ton.Location = new System.Drawing.Point(562, 197);
            this.sl_ton.Name = "sl_ton";
            this.sl_ton.Size = new System.Drawing.Size(67, 24);
            this.sl_ton.TabIndex = 10;
            this.sl_ton.Text = "mamh";
            this.sl_ton.Click += new System.EventHandler(this.sl_ton_Click);
            // 
            // HinhAnh
            // 
            this.HinhAnh.Location = new System.Drawing.Point(13, 23);
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Size = new System.Drawing.Size(348, 285);
            this.HinhAnh.TabIndex = 11;
            this.HinhAnh.TabStop = false;
            // 
            // soLuongMua
            // 
            this.soLuongMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongMua.Location = new System.Drawing.Point(499, 191);
            this.soLuongMua.Name = "soLuongMua";
            this.soLuongMua.Size = new System.Drawing.Size(47, 32);
            this.soLuongMua.TabIndex = 12;
            // 
            // formChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 565);
            this.Controls.Add(this.soLuongMua);
            this.Controls.Add(this.HinhAnh);
            this.Controls.Add(this.sl_ton);
            this.Controls.Add(this.giaTien);
            this.Controls.Add(this.ten_mh);
            this.Controls.Add(this.quayLai);
            this.Controls.Add(this.muaHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "formChiTietSanPham";
            this.Text = "formChiTietSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button muaHang;
        private System.Windows.Forms.Button quayLai;
        private System.Windows.Forms.Label ten_mh;
        private System.Windows.Forms.Label giaTien;
        private System.Windows.Forms.Label sl_ton;
        private System.Windows.Forms.PictureBox HinhAnh;
        private System.Windows.Forms.TextBox soLuongMua;
    }
}