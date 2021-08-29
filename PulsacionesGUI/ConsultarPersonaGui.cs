using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;


namespace PulsacionesGUI
{
    public partial class ConsultarPersonaGui : Form
    {
        PersonaService personaservice = new PersonaService();
        RespuestaConsulta respuestaConsulta; 
       
        public ConsultarPersonaGui()
        {
            InitializeComponent();
        }


        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            respuestaConsulta = personaservice.Consultar();
            dataGridView1.Rows.Clear();
            VaciarTextBox();



            if (respuestaConsulta.Error)
            {
                MessageBox.Show(respuestaConsulta.Mensaje);
            }
            else
            {

                if (TipoConsultaCmb.Text == "Todos")
                {
                    LlenarDataGridView(respuestaConsulta.Personas);

                    Totalinscritostxt.Text = personaservice.TotalizarPersonas().ToString();

                }
                else if (TipoConsultaCmb.Text == "Masculino")
                {
                    
                    LlenarDataGridView(personaservice.ListaHombres());
                    TotalHombrestxt.Text = personaservice.TotalizarHombres().ToString();
                }
                else
                {

                    LlenarDataGridView(personaservice.ListaMujeres());
                    TotalMujerestxt.Text = personaservice.TotalizarMujeres().ToString();

                }

            }
            
        }

        public void LlenarDataGridView(IList<Persona> personas)
        {
            foreach (var item in personas)
            {
                dataGridView1.Rows.Add(item.Identificacion, item.Nombre, item.Edad, item.Sexo, item.Pulsacion);
            }
        }

      private void VaciarTextBox()
        {
            Totalinscritostxt.Text = "";
            TotalHombrestxt.Text = "";
            TotalMujerestxt.Text = "";
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TipoConsultaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
