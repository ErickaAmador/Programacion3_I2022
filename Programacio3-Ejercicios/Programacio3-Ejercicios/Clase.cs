﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesLibreria;

namespace Programacio3_Ejercicios
{
    public partial class Clase : Form
    {
        public Clase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche(10, "Toyota"); //Se pasa lo del segundo constructor

            //llamar las PORPIEDADES
            coche.Modelo = "22R";
            coche.Precio = 100000.00M; //Agregar M al final para decimal
            coche.Km = 150000;

            MessageBox.Show(coche.DevolverDatosCoche()); //Mostrarnos los datos que esta llamadndo en el metodo
        }
    }
}
