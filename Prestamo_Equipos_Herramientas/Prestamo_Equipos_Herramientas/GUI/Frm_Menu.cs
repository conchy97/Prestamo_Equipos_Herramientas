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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            frm_Admin1.BringToFront();
        }

        private void btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            frm_Admin1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_software_Click(object sender, EventArgs e)
        {
            frm_Alumno1.BringToFront();
        }

        private void btn_laboratorios_Click(object sender, EventArgs e)
        {
            frm_Equipo_Herramienta1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_InicioSesion v1 = new Frm_InicioSesion();
            v1.Show();
            this.Hide();
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            frm_Maestro1.BringToFront();
        }

        private void btn_administradores_Click(object sender, EventArgs e)
        {
            frm_prestamo1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSlidelPanel_Click(object sender, EventArgs e)
        {

            if (panelMenu.Width == 30)
            {
                panelMenu.Visible = true;
                panelMenu.Width = 198;
                Animacion1.ShowSync(Logo);

            }
            else
            {
                Animacion2.HideSync(Logo);
                panelMenu.Visible = true;
                panelMenu.Width = 30;
                Animacion1.ShowSync(panelMenu);
            }
        }
    }
}
