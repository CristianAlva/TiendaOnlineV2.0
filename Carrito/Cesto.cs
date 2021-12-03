using System;
using System.Collections.Generic;
using System.IO;

namespace Carrito
{
    public class Cesto
    {
        public List<Producto> Productos { get; set; }
        public double Pago { get; set; }

        public Cesto()
        {
            this.Productos = new List<Producto>();
        }

        public int validaProducto(string codigo)
        {
            int encontrado = -1;

            for (int i = 0; i < this.Productos.Count; i++)
            {
                if (this.Productos[i].codigo == codigo)
                {
                    encontrado = i;
                }
            }
            return encontrado;
        }

        public void añadirProducto(Producto producto)
        {
            //int enc = this.validaProducto(producto.codigo);

            //if (enc >= 0)
            //{
            //    this.Productos[enc].sumarCantidad(producto.cantidad);
            //}
            //else
            //{
            //    this.Productos.Add(producto);
            //}
            //return true;

            Productos.Add(producto);
        }

        public void guardar_lista(Producto producto)
        {
            StreamWriter w = new StreamWriter("lista.txt");
            int i = 0;         
            foreach (Producto item in this.Productos)
            {
                w.WriteLine("{0}:{1}:{2}:{3}:{4}", producto.codigo, producto.nombre, producto.categoria, producto.cantidad, producto.precio);
                i = i + 1;
            }
            w.Close();
        }

        public bool eliminarProducto(string codigo)
        {
            int enc = this.validaProducto(codigo);

            if (enc >= 0)


            {
                this.Productos.RemoveAt(enc);
                return true;
            }
            return false;
        }

        public double validarDinero(double monedas)
        {
            double total = 0;

            try
            {
                total = monedas;
            }
            catch (Exception ex)
            {

            }
            return total;
        }

        public Producto vender(string codigo)
        {
            int enc = this.validaProducto(codigo);

            if (enc >= 0)
            {
                if (this.Productos[enc].validarCantidad())
                {
                    double monedas = this.Pago;
                    double total = this.validarDinero(monedas);

                    if (this.Productos[enc].validarValor(total))
                    {
                        this.Productos[enc].restarProducto();

                        return this.Productos[enc];
                    }
                }
            }
            return null;
        }

        public void listarProducto()
        {
            foreach (Producto a in Productos)
            {
                Console.WriteLine(a.mostrar());
            }
        }
    }
}
