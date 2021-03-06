using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            

            DateTime fecha = NacimientoDateTimePicker1.Value;
            DateTime fecha2 = IngresoDateTimePicker.Value;

            //Llamado a la función
            EdadTextBox.Text = DevolverEdad(fecha).ToString();
            IngresoTextBox.Text = DevolverIngreso(fecha2).ToString();
           

            //Variables
            int SueldoBase = 10000;
            int venta = Convert.ToInt32(VentasTextBox.Text);
            int edadCondicion = DevolverEdad(fecha);
            int ingresoCondicion = DevolverIngreso(fecha2);
            float aumento = 0.05f;
            float aumento2 = 0f;
            float SueldoTotal = 0f;


          
            if(venta > 10000)
            {
                if (edadCondicion >= 30)
                {
                    if (ingresoCondicion >= 10)
                    {
                        aumento2 = SueldoBase * aumento;
                        SueldoTotal = SueldoBase + aumento2;
                        SueldoTotalTextBox.Text = SueldoTotal.ToString();
                    }
                    else
                    {
                        SueldoTotal = SueldoBase;
                        SueldoTotalTextBox.Text = SueldoTotal.ToString();
                        MessageBox.Show("Debes de tener 10 años o más laborando para el aumento");
                        
                    }
                }
                else 
                {
                    SueldoTotal = SueldoBase;
                    SueldoTotalTextBox.Text = SueldoTotal.ToString();
                    MessageBox.Show("Debes tener una edad mayor o igual a 30 años, para lograr el aumento");
                    
                }
            }
            else
            {

                MessageBox.Show("Las ventas deben de ser mayor a 10,000 para obtener un aumento");
                SueldoTotal = SueldoBase;
                SueldoTotalTextBox.Text = SueldoTotal.ToString();
            }

            

        }
        //Calcular la edad
        private int DevolverEdad(DateTime FechaN)
        {
            DateTime FechaNacimiento = FechaN;
            DateTime FechaActual = DateTime.Now;//Devolver la fecha actual

            int edad1 = 0;

            if (FechaNacimiento >= FechaActual)
            {
                MessageBox.Show("Fecha Incorrecta");
                return 0;
            }
            {
                edad1 = FechaActual.Year - FechaNacimiento.Year;
                if(FechaNacimiento.Month > FechaActual.Month)
                {
                    --edad1;
                }
            }

            return edad1;
        }

        //Funcion para calcular la cantidad de años en la empresa
        private int DevolverIngreso(DateTime FechaN)
        {
            DateTime FechaIngreso = FechaN;
            DateTime FechaActual = DateTime.Now;//Devolver la fecha actual

            int edad2 = 0;

            if (FechaIngreso >= FechaActual)
            {
                MessageBox.Show("Fecha Incorrecta");
                return 0;
            }
            {
                edad2 = FechaActual.Year - FechaIngreso.Year;
                if (FechaIngreso.Month > FechaActual.Month)
                {
                    --edad2;
                }
            }

            return edad2;
        }
    }
}
