using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NMADesk.BD;

namespace NMADesk
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {

            
            InitializeComponent();
        }

     
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string sPass = txtpasswd.Text.Trim();
            using (NMADeskEntities db = new NMADeskEntities())
            {
                var lst = from d in db.USUARIO
                          where d.MAIL_USER == txtmail_user.Text
                          && d.PASSWD == sPass && d.ROL_ID_ROL== 1
                          select d;
                var lstclient = from d in db.USUARIO
                          where d.MAIL_USER == txtmail_user.Text
                          && d.PASSWD == sPass && d.ROL_ID_ROL==3
                          select d;
                if (lstclient.Count() > 0)
                {
                    MessageBox.Show("Bienvenido Cliente");
                    this.Hide();
                    FrmCliente frm = new FrmCliente();
                    frm.FormClosed += (s, args) => this.Close();
                    frm.Show();

                }
                if (lst.Count() > 0)
                {
                    MessageBox.Show("Bienvenido administrador");
                    this.Hide();
                    FrmMain frm = new FrmMain();
                    frm.FormClosed += (s, args) => this.Close();
                    frm.Show();

                }
               
            }
        }
    }
}
