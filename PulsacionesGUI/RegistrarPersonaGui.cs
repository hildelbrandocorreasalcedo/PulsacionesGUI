using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;



namespace PulsacionesGUI
{
    public partial class RegistrarPersonaGui : Form
    {
        PersonaService personaservice = new PersonaService();
        public RegistrarPersonaGui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            string mensaje = personaservice.Guardar(persona);
            MessageBox.Show(mensaje);
        }

        private Persona MapearPersona()
        {
            Persona persona = new Persona();
            persona.Identificacion = IdentificacionTxt.Text;
            persona.Nombre = NombreTxt.Text;
            persona.Edad = int.Parse(EdadTxt.Text);
            persona.Sexo = SexoCmb.Text;
            persona.Calcularpulsaciones();
            PulsacionTxt.Text = persona.Pulsacion.ToString();
            return persona;
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            IdentificacionTxt.Text = "";
            NombreTxt.Text = "";
            EdadTxt.Text = "";
            SexoCmb.Text = "";
            PulsacionTxt.Text = "";
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {

            string identificacion = IdentificacionTxt.Text;
            if (identificacion != "")
            {
                RespuestaBusqueda respuesta = personaservice.Buscar(identificacion);

                if (respuesta.Persona != null)
                {
                    Persona persona = respuesta.Persona;
                    NombreTxt.Text = persona.Nombre;
                    EdadTxt.Text = persona.Edad.ToString();
                    PulsacionTxt.Text = persona.Pulsacion.ToString();
                    SexoCmb.Text = persona.Sexo;
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }

            }
            else
            {
                MessageBox.Show("digite una identificacion a buscar");
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string identificacion = IdentificacionTxt.Text;
            if (identificacion != "")
            {
                RespuestaBusqueda respuesta = personaservice.Buscar(identificacion);
                if (respuesta.Persona != null)
                {
                    identificacion = IdentificacionTxt.Text;
                    var mensaje = personaservice.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {identificacion} no se encuentra registrada");
                }
            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (IdentificacionTxt.Text != "" && NombreTxt.Text != "" && EdadTxt.Text != "" && SexoCmb.Text != "")
            {
                Persona persona = MapearPersona();
                persona.Calcularpulsaciones();
                string mensaje = personaservice.Modificar(persona);
                MessageBox.Show(mensaje);
            }
            else {
                MessageBox.Show("rectifique los campos");
            }
        }
    }
}
