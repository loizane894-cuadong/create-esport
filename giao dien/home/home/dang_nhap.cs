using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class dang_nhap : Form
    {
        public dang_nhap()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Very simple demo logic: validate non-empty fields
            if (string.IsNullOrWhiteSpace(txtLoginUser.Text) || string.IsNullOrWhiteSpace(txtLoginPass.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: replace with real authentication
            MessageBox.Show($"Đăng nhập thành công (demo): {txtLoginUser.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // show register panel
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // show login panel
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtRegName.Text) || string.IsNullOrWhiteSpace(txtRegEmail.Text) || string.IsNullOrWhiteSpace(txtRegPass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRegPass.Text != txtRegConfirm.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: replace with real registration logic (save to database)
            MessageBox.Show($"Đăng ký thành công (demo): {txtRegName.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Return to login
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
