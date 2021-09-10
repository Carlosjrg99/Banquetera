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
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fechaEventos.DataSource = new Evento().ListaEventos();
                fechaEventos.DataBind();
                List<Evento> lista = new Evento().ListaEventos();
                if (lista.Count > 0)
                {
                    if (!(fechaEventos.SelectedValue.Length > 0))
                        return;
                    Evento ev = new Evento().Buscar(DateTime.Parse(fechaEventos.SelectedValue));
                    nombreMensaje.Text = ev.Nombre;
                    direccionMensaje.Text = ev.Direccion;
                    emailMensaje.Text = ev.Email;
                    telefonoMensaje.Text = ev.Telefono;
                    personasMensaje.Text = ev.Personas.ToString();
                    nombreMensaje.ForeColor = System.Drawing.Color.Black;
                    direccionMensaje.ForeColor = System.Drawing.Color.Black;
                    emailMensaje.ForeColor = System.Drawing.Color.Black;
                    telefonoMensaje.ForeColor = System.Drawing.Color.Black;
                    personasMensaje.ForeColor = System.Drawing.Color.Black;
                }
            }
            else
            {
                if (!(fechaEventos.SelectedValue.Length > 0))
                {
                    fechaMensaje.Text = "Error: No hay fecha seleccionada";
                    fechaMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                Evento ev = new Evento().Buscar(DateTime.Parse(fechaEventos.SelectedValue));
                nombreMensaje.Text = ev.Nombre;
                direccionMensaje.Text = ev.Direccion;
                emailMensaje.Text = ev.Email;
                telefonoMensaje.Text = ev.Telefono;
                personasMensaje.Text = ev.Personas.ToString();
                nombreMensaje.ForeColor = System.Drawing.Color.Black;
                direccionMensaje.ForeColor = System.Drawing.Color.Black;
                emailMensaje.ForeColor = System.Drawing.Color.Black;
                telefonoMensaje.ForeColor = System.Drawing.Color.Black;
                personasMensaje.ForeColor = System.Drawing.Color.Black;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            var regexMail = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            int valPersonas = int.Parse(personas.Text);
            bool validacion = true;

            if (!Regex.Match(email.Text, regexMail, RegexOptions.IgnoreCase).Success)
            {
                emailMensaje.Text = "Error: Debe ingresar un correo válido";
                emailMensaje.ForeColor = System.Drawing.Color.Red;
                validacion = false;
            }

            if (valPersonas < 1)
            {
                personasMensaje.Text = "Error: Deben asistir personas";
                personasMensaje.ForeColor = System.Drawing.Color.Red;
                validacion = false;
            }

            if (!validacion)
            {
                return;
            }



            if (!(fechaEventos.SelectedValue.Length > 0))
                return;
            Evento ev = new Evento().Buscar(DateTime.Parse(fechaEventos.SelectedValue));
            ev.Nombre = nombre.Text;
            ev.Direccion = direccion.Text;
            ev.Email = email.Text;
            ev.Telefono = telefono.Text;
            ev.Fecha = DateTime.Parse(fechaEventos.SelectedValue);
            ev.Personas = int.Parse(personas.Text);

            if (ev.Modificar())
            {
                Response.Redirect("ListarEventos.aspx");
            }
        }
    }
}