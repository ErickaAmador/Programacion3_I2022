using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_ErickaAmador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            //Variables
            int numero;

            numero = Convert.ToInt32(IngreseNumeroTextBox.Text); //Convertir lo ingresado en una caja de texto a un entero

            //Llamado de las funciones
            Par(numero).ToString();
           Impar(numero).ToString();
           Primo(numero).ToString();
        }

        //Funcion para determinar si el numero es par
        private int Par(int numero)
        {
            int resp;
            resp = numero;

            if(resp % 2 ==0)
            {
                MessageBox.Show("Este es un número PAR");
            }
            return resp;
        }

        //Funcion para determinar si el numero es Impar
        private int Impar(int numero)
        {
            int resp;
            resp = numero;

            if (resp % 2 == 0)
            {
              //MessageBox.Show("Este es un número PAR");
            }
            else
            {
                MessageBox.Show("Este es un número IMPAR");
            }
            return resp;
        }
        //Funcion para determinar si el numero es Primo
        private int Primo(int numero)
        {
            int respuesta=0;
            for (int i =1; i<= numero; i++)
            {
                if(numero % i == 0)
                {
                    respuesta = respuesta + 1;
                }
            }
            if (respuesta > 2)
            {
                MessageBox.Show("NO es un número Primo");
            }
            else
            {
                MessageBox.Show("SI es un número Primo");
            }
            return respuesta;
        }
    }
}
