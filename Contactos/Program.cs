using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Contacto> lista = new List<Contacto>();
                bool salir = false; Console.WriteLine("¿Cuántos contactos désea guardar?");
                int i = int.Parse(Console.ReadLine()), a = 0;
                while (!salir)
                {
                    a++;
                    Contacto x = new Contacto();
                    Console.Clear();
                    Console.WriteLine("favor de ingresar nombre");
                    x.Nombre = Console.ReadLine();
                    Console.WriteLine("favor de ingresar fecha de nacimiento con el siguiente formato \nAA/MM/DD");
                    x.Fecha = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("favor de ingresar número de telefono");
                    x.Numero = Console.ReadLine();
                    lista.Add(x);
                    if (i == a)
                    {
                        salir = true;
                    }
                }
                Console.Clear();
                Console.WriteLine("NOMBRE--EDAD--NUMERO DE TELEFONO");
                foreach (Contacto x in lista)
                {
                    Console.WriteLine(x.ToString());
                }
            }catch(FormatException e) { Console.WriteLine(e.Message); }
            Console.ReadKey();
        }
    }
}
