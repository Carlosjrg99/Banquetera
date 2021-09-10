using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace PracticaHotel
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarEvento(object sender, EventArgs e)
        {
            var regexMail = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            DateTime valFecha = DateTime.Parse(fecha.Text);
            int valPersonas = int.Parse(personas.Text);
            bool validacion = true;
            List<Evento> lista = new Evento().ListaEventos();
            
            if(!Regex.Match(email.Text, regexMail, RegexOptions.IgnoreCase).Success)
            {
                emailMensaje.Text = "Error: Debe ingresar un correo válido";
                validacion = false;
            }
            else
            {
                emailMensaje.Text = "";
            }

            if (valFecha < DateTime.Today)
            {
                fechaMensaje.Text = "Error: No se pueden registrar eventos para fechas anteriores al día en curso";
                validacion = false;
            }
            else if (lista.Any(revFecha => revFecha.Fecha == valFecha))
            {
                fechaMensaje.Text = "Error: No se pueden realizar eventos 2 veces el mismo día";
                validacion = false;
            }
            else
            {
                fechaMensaje.Text = "";
            }

            if (valPersonas < 1)
            {
                personasMensaje.Text = "Error: Deben asistir personas";
                validacion = false;
            }
            else
            {
                personasMensaje.Text = "";
            }

            if (!validacion)
            {
                return;
            }

            Evento ev = new Evento()
            {
                Nombre = nombre.Text,
                Direccion = direccion.Text,
                Email = email.Text,
                Telefono = telefono.Text,
                Fecha = valFecha,
                Personas = valPersonas
            };

            if (ev.insertar())
                Response.Redirect("ListarEventos.aspx");
            else
                botonMensaje.Text = "No se ingresó el evento";
        }
    }
}