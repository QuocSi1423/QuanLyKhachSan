namespace QuanLyKhachSan.GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            taiKhoanTextBox = new TextBox();
            thoatButton = new Button();
            matKhauTextBox = new TextBox();
            matKhauText = new Label();
            dangNhapButton = new Button();
            taiKhoanText = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // taiKhoanTextBox
            // 
            taiKhoanTextBox.BackColor = SystemColors.ButtonFace;
            taiKhoanTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            taiKhoanTextBox.Location = new Point(274, 173);
            taiKhoanTextBox.Name = "taiKhoanTextBox";
            taiKhoanTextBox.Size = new Size(462, 50);
            taiKhoanTextBox.TabIndex = 1;
            // 
            // thoatButton
            // 
            thoatButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            thoatButton.FlatStyle = FlatStyle.Flat;
            thoatButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoatButton.Location = new Point(238, 352);
            thoatButton.Name = "thoatButton";
            thoatButton.Size = new Size(161, 46);
            thoatButton.TabIndex = 4;
            thoatButton.Text = "Thoát";
            thoatButton.UseVisualStyleBackColor = true;
            // 
            // matKhauTextBox
            // 
            matKhauTextBox.BackColor = SystemColors.ButtonFace;
            matKhauTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            matKhauTextBox.Location = new Point(274, 257);
            matKhauTextBox.Name = "matKhauTextBox";
            matKhauTextBox.Size = new Size(462, 50);
            matKhauTextBox.TabIndex = 2;
            // 
            // matKhauText
            // 
            matKhauText.AutoSize = true;
            matKhauText.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            matKhauText.ForeColor = Color.FromArgb(44, 181, 236);
            matKhauText.Image = (Image)resources.GetObject("matKhauText.Image");
            matKhauText.ImageAlign = ContentAlignment.MiddleLeft;
            matKhauText.Location = new Point(49, 257);
            matKhauText.Name = "matKhauText";
            matKhauText.Size = new Size(198, 45);
            matKhauText.TabIndex = 3;
            matKhauText.Text = "    Mật khẩu";
            matKhauText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dangNhapButton
            // 
            dangNhapButton.BackColor = Color.FromArgb(44, 181, 236);
            dangNhapButton.FlatStyle = FlatStyle.Flat;
            dangNhapButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dangNhapButton.ForeColor = Color.White;
            dangNhapButton.Location = new Point(456, 352);
            dangNhapButton.Name = "dangNhapButton";
            dangNhapButton.Size = new Size(161, 46);
            dangNhapButton.TabIndex = 3;
            dangNhapButton.Text = "Đăng nhập";
            dangNhapButton.UseVisualStyleBackColor = false;
            // 
            // taiKhoanText
            // 
            taiKhoanText.AutoSize = true;
            taiKhoanText.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            taiKhoanText.ForeColor = Color.FromArgb(44, 181, 236);
            taiKhoanText.Image = (Image)resources.GetObject("taiKhoanText.Image");
            taiKhoanText.ImageAlign = ContentAlignment.MiddleLeft;
            taiKhoanText.Location = new Point(49, 178);
            taiKhoanText.Name = "taiKhoanText";
            taiKhoanText.Size = new Size(200, 45);
            taiKhoanText.TabIndex = 0;
            taiKhoanText.Text = "    Tài khoản";
            taiKhoanText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 181, 236);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 98);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(294, 26);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 9;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(843, 447);
            Controls.Add(panel1);
            Controls.Add(dangNhapButton);
            Controls.Add(matKhauTextBox);
            Controls.Add(matKhauText);
            Controls.Add(thoatButton);
            Controls.Add(taiKhoanTextBox);
            Controls.Add(taiKhoanText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DangNhap";
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox taiKhoanTextBox;
        private Button thoatButton;
        private TextBox matKhauTextBox;
        private Label matKhauText;
        private Button dangNhapButton;
        private Label taiKhoanText;
        private Panel panel1;
        private Label label1;
    }
}