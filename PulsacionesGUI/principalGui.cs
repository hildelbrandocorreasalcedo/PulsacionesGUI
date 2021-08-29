using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace PulsacionesGUI
{
    public partial class principalGui : Form
    {
        public principalGui()
        {
            InitializeComponent();
        }

        private void registrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonaGui registrarpersonafrm = new RegistrarPersonaGui();
            registrarpersonafrm.Show();
           

        }

        private void consultarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPersonaGui consultarpersonafrm = new ConsultarPersonaGui();
            consultarpersonafrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
