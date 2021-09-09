using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Libreria.Entidades;


namespace Expendedora.Consola
{
    
    class Program
    {
        static bool encendido;
        static Maquina _maquina;
        static Program()
        {
            encendido = true;
            _maquina = new Maquina("Universal", 80);
        }


        static void Main(string[] args)

        {
            bool condicion = true;

            do
            {
                Console.WriteLine("Ingrese la opción deseada: " + "\n" +
                    "0) Encender la máquina"+"\n"+
                    "1) Listar bebidas disponibles" + "\n" +
                    "2) Ingresar una lata a la lista" + "\n" +
                    "3) Extraer una bebida" + "\n" +
                    "4) Conocer el balance" + "\n" +
                    "5) Mostrar stock de bebidas" + "\n" +
                    "6) Apagar la expendedora"+"\n"+
                    "S: SALIR");

                string opcion;
                opcion = Console.ReadLine();
                //no me anda
               

                switch (opcion.ToUpper())
                {
                    case "0":
                        if(!encendido)
                        { encendido = true; }
                        break;
                    case "1":
                        // muestra listado de bebidas
                        break;
                    case "2":
                        IngresarLata(_maquina);                        
                        break;
                    case "3":
                        //usuario elije lata
                        break;
                    case "4":
                        //string con dinero y latas de la maquina
                        break;
                    case "5":
                        // conocer stock
                        break;
                    case "6":
                        Console.WriteLine("Espere mientras apagamos su equipo");
                        encendido = false;
                        break;
                    case "S":
                        condicion = false;
                        break;
                    default:
                        Console.WriteLine("La opción que Ud. ingreso es incorrecta, oprima un botón para volver a intentar");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            } while (condicion);
            
        }
        static void IngresarLata(Maquina _maquina)
        { Console.WriteLine("Ingrese los datos correspondientes a su bebida" + "\n" +
                "Código de Bebida:");
            string cod = Console.ReadLine();
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Valor: ");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Volumen:");
            double volumen = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad:");
            int cantidad = int.Parse(Console.ReadLine());
            Lata lata = new Lata(cod, nombre, precio, volumen, cantidad);
            _maquina.AgregarLata(lata);
            

        }
    }
}
