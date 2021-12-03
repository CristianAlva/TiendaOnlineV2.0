using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito
{
    public class Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double cambio { get; set; }

        public void sumarCantidad(int cantidad)
        {
            this.cantidad += cantidad;
        }

        public bool validarCantidad()
        {
            if (this.cantidad > 0)
            {
                return true;
            }
            return false;
        }

        public bool validarValor(double valor)
        {
            if (this.precio <= valor)
            {
                this.cambio = valor - this.precio;
                return true;
            }
            return false;
        }

        public void restarProducto()
        {
            this.cantidad--;
        }

        public string mostrar()
        {
            return  codigo + "\n" + nombre + "\n" + categoria + "\n" + cantidad + "\n" + precio + "$";
        }
    }
}
