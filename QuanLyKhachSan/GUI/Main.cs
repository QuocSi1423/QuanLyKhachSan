using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class Main : Form
    {
        Form activeForm = null;
        Boolean subMenu1Open = false;
        public Main()
        {
            DangNhap dn = new DangNhap();
            QuanLyPhong qlp = new QuanLyPhong();
            InitializeComponent();
            OpenForm(qlp);
        }
        public void button_mouse_enter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;
            (sender as Button).ForeColor = Color.Black;
        }
        public void button_mouse_leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(44, 181, 236);
            (sender as Button).ForeColor = Color.White;
        }
        public void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = form;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chucNang1Button_Click(object sender, EventArgs e)
        {
            subMenu1Open = !subMenu1Open;
            chucNang1SubMenu.Visible = subMenu1Open;
            if (subMenu1Open)
            {
                chucNang1Button.Text = "Chức năng 1 ▲";
            }
            else
            {
                chucNang1Button.Text = "Chức năng 1 ▼";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
