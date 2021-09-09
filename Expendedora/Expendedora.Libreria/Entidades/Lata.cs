using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Libreria.Entidades
{
   public class Lata
    {
        //declaracion de atributos
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        // Constructor de Clase

        public Lata()
        { }
        public Lata (string codigo, string nombre, double precio, double volumen, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cantidad;
           
        }

        // Propiedades de Clase
        public string Nombre
        {
            get
            {
               return _nombre;
            }
            set
            {
                _nombre=value;
                 
            }
        }
        public string codigo
        { set { _codigo = value; } }
        public int cantidad
        { set { _cantidad = value; } }
        public double precio
        { set { _precio = value; } }
        public double volumen
        { set { _volumen = value; } }
        /*
        public double PrecioPorLitro()
        {

        }*/
    }
}
