using System;
using ADO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Evento
    {
        private string nombre;
        private string direccion;
        private string email;
        private string telefono;
        private DateTime fecha;
        private int personas;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Personas
        {
            get { return personas; }
            set { personas = value; }
        }

        public bool insertar()
        {
            try
            {
                eventos e = new eventos();
                e.nombre_contacto = Nombre;
                e.direccion = Direccion;
                e.correo_electronico = Email;
                e.telefono = Telefono;
                e.fecha_evento = Fecha;
                e.cantidad_personas = Personas;

                Conexion.Entidades.eventos.Add(e);
                Conexion.Entidades.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminar()
        {
            try
            {
                eventos e = Conexion.Entidades.eventos.First(ev => ev.fecha_evento == fecha);
                Conexion.Entidades.eventos.Remove(e);
                Conexion.Entidades.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                eventos e = Conexion.Entidades.eventos.First(ev => ev.fecha_evento == fecha);
                e.nombre_contacto = Nombre;
                e.direccion = Direccion;
                e.correo_electronico = Email;
                e.telefono = Telefono;
                e.fecha_evento = Fecha;
                e.cantidad_personas = Personas;

                Conexion.Entidades.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public List<Evento> ListaEventos()
        {
            List<Evento> lista = new List<Evento>();

            foreach (eventos e in Conexion.Entidades.eventos)
            {
                lista.Add(new Evento() 
                { 
                    Nombre = e.nombre_contacto, 
                    Direccion = e.direccion, 
                    Email = e.correo_electronico, 
                    Telefono = e.telefono,
                    Fecha = e.fecha_evento,
                    Personas = e.cantidad_personas,
                });
            }

            return lista;
        }

        public Evento Buscar(DateTime fechita)
        {
            try
            {
                eventos e = Conexion.Entidades.eventos.First(ev => ev.fecha_evento == fechita);
                if (e == null)
                    return null;
                nombre = e.nombre_contacto;
                direccion = e.direccion;
                email = e.correo_electronico;
                telefono = e.telefono;
                fecha = e.fecha_evento;
                personas = e.cantidad_personas;
                return this;
            }
            catch
            {
                return null;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}",nombre, fecha);
        }
    }
}

/*
 
                e.nombre_contacto = Nombre;
                e.direccion = Direccion;
                e.correo_electronico = Email;
                e.telefono = Telefono;
                e.fecha_evento = Fecha;
                e.cantidad_personas = Personas;
 */