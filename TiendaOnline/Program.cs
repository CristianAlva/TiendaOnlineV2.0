using System;
using Carrito;

namespace TiendaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Cesto c = new Cesto();

            CLista mi_lista = new CLista();

            Producto producto = new Producto();

            int op, res;

            res = mi_lista.cargar(mi_lista);

            do
            {
                op = menu();
                switch (op)
                {
                    case 1:

                        for (int i = 0; i < mi_lista.numero; i++)
                        {
                            Console.WriteLine("ref: " + mi_lista.p[i].codigo);
                            Console.WriteLine("nombre: " + mi_lista.p[i].nombre);
                            Console.WriteLine("categoria: " + mi_lista.p[i].categoria);
                            Console.WriteLine("cantidad: " + mi_lista.p[i].cantidad);
                            Console.WriteLine("precio: " + mi_lista.p[i].precio + "\n");
                        }
                        break;
                    case 2:
                        Console.Write("codigo: ");
                        producto.codigo = Console.ReadLine();

                        Console.Write("nombre: ");
                        producto.nombre = Console.ReadLine();

                        Console.Write("categoria: ");
                        producto.categoria = Console.ReadLine();

                        Console.Write("cantidad: ");
                        producto.cantidad = Convert.ToInt32(Console.ReadLine());

                        Console.Write("precio: ");
                        producto.precio = double.Parse(Console.ReadLine());

                        c.añadirProducto(producto);
                        
                        break;

                    case 3:
                        c.listarProducto();
                        break;

                    case 4:
                        Console.Write("codigo: ");
                        string codigo = Console.ReadLine();

                        c.eliminarProducto(codigo);
                        break;

                    case 5:                        
                        c.guardar_lista(producto);
                        Console.WriteLine("Prodcutos guardados");
                        break;

                    case 6:
                        Console.Write("codigo: ");
                        string codigo_venta = Console.ReadLine();

                        Console.Write("ingresar dinero: ");
                        c.Pago = Convert.ToDouble(Console.ReadLine());

                        Producto pcomprado = c.vender(codigo_venta);

                        if (pcomprado == null)
                        {
                            Console.WriteLine("No se pudo efectuar la compra");
                        }
                        else
                        {
                            Console.WriteLine("Su producto es {0} y el cambio es {1}", pcomprado.codigo, pcomprado.cambio);
                        }
                        break;
                }

                }while (op !=0) ;
            } 

            public static int menu()
            {
                Console.WriteLine("BIENVENIDOS A LA CESTA DE LA COMPRA");
                Console.WriteLine("1. listar productos");
                Console.WriteLine("2. Añadir producto");
                Console.WriteLine("3. Mostar carrito");    
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Guardar productos");
                Console.WriteLine("6. Comprar producto");
                Console.WriteLine("0. salir");

                int op = Convert.ToInt32(Console.ReadLine());
                return op;
            }
        }
    }
