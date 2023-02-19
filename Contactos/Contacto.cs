using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactos
{
    internal class Contacto : Persona
    {
		private string numero;

		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}
        public Contacto() : base()
        {
            numero = string.Empty;
        }
        public Contacto(String nombre, DateTime? fecha, string telefono) : base(nombre, fecha)
        {
            this.numero = telefono;
        }
        public override string ToString()
        {
            return base.ToString() + " " + numero;
        }
    }
}
