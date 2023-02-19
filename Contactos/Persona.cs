using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactos
{
    internal class Persona
    {
		protected String nombre;

		public String Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		protected DateTime? fecha;

		public DateTime? Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		public int Edad
		{
			get 
			{
				int edad = (DateTime.Now.Year - fecha.Value.Year);
				return edad;
			}
		}
        public Persona()
        {
            nombre = String.Empty;
            fecha = null;
        }
        public Persona(String nombre, DateTime? fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public override string ToString()
        {
            return nombre.ToUpper() + " " + Edad;
        }
    }
}
