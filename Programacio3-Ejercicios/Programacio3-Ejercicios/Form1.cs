using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacio3_Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Vectores
            int[] arreglo1 = new int[5];

            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 30;
            arreglo1[3] = 60;
            arreglo1[4] = 80;

            int[] arreglo2 = new int[6] {41, 63, 45, 68, 74, 99};

            int[] arreglo3 = new int[] {2,5,1,3,7,6};

            int[] arreglo4 = {5,6,4,3,1,9,7};

            String[] arreglo5 = { "lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            //for(int i =0; i < arreglo5.Length; i++)
            //{
            //    listBox1.Items.Add(arreglo5[i]);
            //}

            foreach(var item in arreglo5)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
