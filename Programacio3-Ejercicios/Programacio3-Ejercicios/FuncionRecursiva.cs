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
    public partial class FuncionRecursiva : Form
    {
        public FuncionRecursiva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }


        private void RecorrerDeUnoEnUno(int ValorInicial, int ValorFinal)
        {
            listBox1.Items.Add(ValorInicial);

            if(ValorInicial < ValorFinal)
            {
                RecorrerDeUnoEnUno(ValorInicial + 1, ValorFinal);
            }
        }
    }
}
