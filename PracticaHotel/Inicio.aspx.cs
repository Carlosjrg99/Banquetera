using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace PracticaHotel
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Evento> lista = new Evento().ListaEventos();
            if (lista.Count == 0)
            {
                Evento ev = new Evento()
                {
                    Nombre = "Carlos",
                    Direccion = "Casa de Carlos",
                    Email = "carlos@mail.com",
                    Telefono = "987654321",
                    Fecha = DateTime.Parse("12/12/2021"),
                    Personas = int.Parse("4")
                };
                ev.insertar();
            }
        }
    }
}