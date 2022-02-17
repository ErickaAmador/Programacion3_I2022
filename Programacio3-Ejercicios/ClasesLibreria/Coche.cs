using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesLibreria
{
    public class Coche
    {
        //Atributos: Caracteristicas que nuestro codigo va a tener y seran privados
        private int id;
        //private String marca;
        //private String modelo;
        //private String precio;
        //private String km;

        //Propiedades
        public int Id { get => id; set => id = value; } 

       // public String Marca { get; set; }

        public String Marca { get; set; } //Escribir Pro y TAB dos veces
        public String Modelo { get; set; }
        public Decimal Precio { get; set; }
        public decimal Km { get; set; }

        //CONSTRUCTORES: Siempre sera publico y se llamara igual que la clase
        public Coche() 
        { 
        }

        public Coche(int id, String marca)
        {
            //Propiedad sera igual atributo
            Id = id; 
            Marca = marca;
        }

        //METODOS: Acciones o funciones que va a tener la clase
        public String DevolverDatosCoche()
        {
            return "Id: " + Id + " Marca: " + Marca + " Modelo: " + Modelo;
        }


    }
}
