using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito
{
    public class CLista
    {
        const int MAX = 20;
        public int numero;
        public Producto[] p = new Producto[MAX];

    public int cargar(CLista l)
        {
            int i = 0;
            StreamReader F = new StreamReader("productos.txt");
            string linea = F.ReadLine();
            string[] palabra = new string[4];
            while (linea != null)
            {
                Producto e = new Producto();
                palabra = linea.Split(' ');
                e.codigo = palabra[0];
                e.nombre = palabra[1];
                e.categoria = palabra[2];
                e.cantidad = Convert.ToInt32(palabra[3]);
                e.precio = Convert.ToDouble(palabra[4]);
                l.p[i] = e;
                i++;
                linea = F.ReadLine();
            }
            l.numero = i;
            F.Close();

            return (0);
        }
    }
}
