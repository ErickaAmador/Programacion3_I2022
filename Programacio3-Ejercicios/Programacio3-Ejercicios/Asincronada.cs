using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacio3_Ejercicios
{
    public partial class Asincronada : Form
    {
        public Asincronada()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //HornearPizza();
            await HornearPizzaAsync();
            label1.Text = "La pizza esta lista";
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void OtrasTareasButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizando otras tareas","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private async void button1_Click_1(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(textBox1.Text);
            decimal valor2 = Convert.ToDecimal(textBox2.Text);

            MessageBox.Show("La suma es: " + await SumarAsync(valor1, valor2));
        }

        private decimal Sumar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        private async Task<decimal> SumarAsync(decimal valor1, decimal valor2)
        {
            var resultado = await Task.Run(() =>
                 {
                     return valor1 + valor2;
                 });
            return resultado;
        }
    }
}
