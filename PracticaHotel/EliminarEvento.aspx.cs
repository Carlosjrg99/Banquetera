using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace PracticaHotel
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Evento> lista = new Evento().ListaEventos();
            if (IsPostBack)
            {
                Evento ev = lista.First(eve => eve.Fecha.ToString() == eliminarEventos.SelectedValue.ToString());
                infoEvento.Text = string.Format("Nombre: {0}<br>Dirección: {1}",ev.Nombre, ev.Direccion);
            }
            else
            {
                eliminarEventos.DataSource = lista;
                eliminarEventos.DataBind();
                if (lista.Count > 0)
                {
                    Evento ev = lista.First(eve => eve.Fecha.ToString() == eliminarEventos.SelectedValue.ToString());
                    infoEvento.Text = string.Format("Nombre: {0}<br>Dirección: {1}", ev.Nombre, ev.Direccion);
                }
                else
                {
                    Response.Redirect("IngresarEvento.aspx");
                }
            }
        }

        protected void elimiarSeleccion_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(eliminarEventos.SelectedValue);
            Evento ev = new Evento()
            {
                Fecha = fecha
            };

            if (ev.eliminar())
            {
                Response.Redirect("ListarEventos.aspx");
            }
        }
    }
}