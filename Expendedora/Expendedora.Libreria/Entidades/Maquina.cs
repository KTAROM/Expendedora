using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Libreria.Entidades
{
    public class Maquina
    {
        //Atributos de clase
        public List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        // Propiedades
        public List<Lata> Latas
        {
            get
            {
                return _latas;
            }
        }

        //Constructor Clase Maquina
        public Maquina(string proveedor, int capacidad)
        {
            _proveedor = proveedor;
            _capacidad= capacidad;
            double dinero = 0;
            bool encendida;
            _latas = new List<Lata>();
        }
            
        // Propiedades
        public double dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }
        public void AgregarLata(Lata lata)
        {     
           _latas.Add(lata);
            
        }
        /*
        public Lata ExtraerLata (string cod, double precio)
        {
           // buscar la lata y sacar una unidad
        }

        public string GetBalance()
        {

        }

        public int GetCapacidadRestante()
        {

        }

        public void EncenderMaquina()
        {

        }

        public bool EstaVacia()
        {

        }*/
    }
}
