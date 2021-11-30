using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMADesk.BD;

namespace NMADesk
{
    public partial class ticket : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public ticket()
        {
            InitializeComponent();
        }

        

        private void ticket_Load(object sender, EventArgs e)
        {
            
                using (NMADeskEntities db = new NMADeskEntities())
                {
                    var lst = from  d in db.TICKET 
                              orderby d.ID_TICKET descending

                              select new {
                                  d.ID_TICKET,
                                  d.FECHA_CREACION_TICKET,
                                  d.FECHA_CIERRE_TICKET,
                                  d.ID_ESTADO,
                                  d.ID_USUARIO,
                                  d.DESCRIPCION,
                                  d.ID_PROFESIONAL,
                                  d.SOLUCION
                              } ;

                    dataGridView1.DataSource = lst.ToList();

                }
            
        }

        private void btnMenuMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente frm = new FrmCliente();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
