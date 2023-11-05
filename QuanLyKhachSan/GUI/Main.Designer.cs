using Org.BouncyCastle.Tls;

namespace QuanLyKhachSan.GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            chucNang1SubMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            chucNang1Button = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            chucNang1SubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(273, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 934);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 181, 236);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 934);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(chucNang1SubMenu);
            panel4.Controls.Add(chucNang1Button);
            panel4.Location = new Point(0, 290);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 605);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 334);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 187);
            panel5.TabIndex = 3;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.Location = new Point(0, 34);
            button8.Name = "button8";
            button8.Size = new Size(275, 34);
            button8.TabIndex = 1;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(275, 34);
            button7.TabIndex = 0;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 286);
            button6.Name = "button6";
            button6.Size = new Size(275, 48);
            button6.TabIndex = 2;
            button6.Text = "Chức năng 1 ▼";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // chucNang1SubMenu
            // 
            chucNang1SubMenu.Controls.Add(button5);
            chucNang1SubMenu.Controls.Add(button4);
            chucNang1SubMenu.Controls.Add(button3);
            chucNang1SubMenu.Controls.Add(button2);
            chucNang1SubMenu.Controls.Add(button1);
            chucNang1SubMenu.Dock = DockStyle.Top;
            chucNang1SubMenu.Location = new Point(0, 48);
            chucNang1SubMenu.Name = "chucNang1SubMenu";
            chucNang1SubMenu.Size = new Size(275, 238);
            chucNang1SubMenu.TabIndex = 1;
            chucNang1SubMenu.Visible = false;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 136);
            button5.Name = "button5";
            button5.Size = new Size(275, 34);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 102);
            button4.Name = "button4";
            button4.Size = new Size(275, 34);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 68);
            button3.Name = "button3";
            button3.Size = new Size(275, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 34);
            button2.Name = "button2";
            button2.Size = new Size(275, 34);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(275, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // chucNang1Button
            // 
            chucNang1Button.Dock = DockStyle.Top;
            chucNang1Button.FlatAppearance.BorderColor = Color.White;
            chucNang1Button.FlatStyle = FlatStyle.Flat;
            chucNang1Button.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            chucNang1Button.ForeColor = Color.White;
            chucNang1Button.Location = new Point(0, 0);
            chucNang1Button.Name = "chucNang1Button";
            chucNang1Button.Size = new Size(275, 48);
            chucNang1Button.TabIndex = 0;
            chucNang1Button.Text = "Chức năng 1 ▼";
            chucNang1Button.TextAlign = ContentAlignment.MiddleLeft;
            chucNang1Button.UseVisualStyleBackColor = true;
            chucNang1Button.Click += chucNang1Button_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(38, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 190);
            panel3.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 934);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            chucNang1SubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button chucNang1Button;
        private Panel chucNang1SubMenu;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel5;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}