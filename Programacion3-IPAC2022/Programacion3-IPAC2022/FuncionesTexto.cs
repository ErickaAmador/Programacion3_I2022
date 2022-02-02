using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3_IPAC2022
{
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void FuncionesTexto_Load(object sender, EventArgs e)
        {

        }

        private void LonguitudButton_Click(object sender, EventArgs e)
        {
            string cadena = cadenaTextBox.Text;

            LonguitudTextBox.Text = cadena.Length.ToString();

            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);

            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length -1, 1);

            RangoTextBox.Text = cadena.Substring(5, 10);

            MayusculaTextBox1.Text = cadena.ToUpper();

            MinusculaTextBox.Text = cadena.ToLower();

            RemplazarTextBox.Text = cadena.Replace("a", "b");
        }
    }
}
