namespace ECSystem
{
    partial class fDangNhap
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
            this.textboxUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new MaterialSkin.Controls.MaterialButton();
            this.buttonLogin = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textboxUsername);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 168);
            this.panel1.TabIndex = 0;
            // 
            // textboxUsername
            // 
            this.textboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxUsername.Depth = 0;
            this.textboxUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.textboxUsername.Hint = "Tên đăng nhập";
            this.textboxUsername.Location = new System.Drawing.Point(3, 3);
            this.textboxUsername.MaxLength = 50;
            this.textboxUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxUsername.Multiline = false;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(370, 50);
            this.textboxUsername.TabIndex = 0;
            this.textboxUsername.Text = "";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPassword.Hint = "Mật khẩu";
            this.textBoxPassword.Location = new System.Drawing.Point(3, 59);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Password = true;
            this.textBoxPassword.Size = new System.Drawing.Size(370, 50);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.54054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.45946F));
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLogin, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.Depth = 0;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.DrawShadows = true;
            this.buttonExit.HighEmphasis = true;
            this.buttonExit.Icon = null;
            this.buttonExit.Location = new System.Drawing.Point(298, 6);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(68, 36);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonExit.UseAccentColor = false;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.DrawShadows = true;
            this.buttonLogin.HighEmphasis = true;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(185, 6);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(105, 36);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonLogin.UseAccentColor = false;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDangNhap";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton buttonExit;
        private MaterialSkin.Controls.MaterialButton buttonLogin;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox textboxUsername;
    }
}