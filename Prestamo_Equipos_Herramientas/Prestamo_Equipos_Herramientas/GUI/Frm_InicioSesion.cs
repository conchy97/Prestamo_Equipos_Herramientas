using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamo_Equipos_Herramientas.GUI
{
    public partial class Frm_InicioSesion : Form
    {
        public Frm_InicioSesion()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Frm_Menu v1 = new Frm_Menu();
            v1.Show();
            this.Hide();
        }
    }
}
