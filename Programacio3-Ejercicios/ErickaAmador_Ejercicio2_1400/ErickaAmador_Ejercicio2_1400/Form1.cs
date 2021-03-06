using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickaAmador_Ejercicio2_1400
{
    public partial class Form1 : Form
    {
        //GLOBALES
        //ARREGLOS 
        static String[] arregloNombre = new string[45];
        static int[] arregloEdad = new int[45];
        //VAriable Global para llevar el control de los datos ingresados
        static int ContarIngresos = 1;

        public Form1()
        {
            InitializeComponent();
            //Mensaje para mostrar al usuario de como usar el programa
            MessageBox.Show("                                                           AVISO "+
                            "                                                 "+"Cuando agregue a cada estudiante debe de dar clic en los botones  " +
                            "Agregar y Mostrar. Para luego ver la lista de alumnos ingresados");
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            //Almacenar los datos
            arregloNombre[ContarIngresos] = NombreTextBox.Text; 
            arregloEdad[ContarIngresos] = Convert.ToInt32(EdadTextBox.Text);
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            //Mostrar los datos en ComBox
            comboBox1.Items.Add(" " + arregloNombre[ContarIngresos] + " " + arregloEdad[ContarIngresos] + " ");
        }
        
    }
}
