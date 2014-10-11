using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadioButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            int numero1, numero2, suma, resta;
            numero1 = int.Parse(numero1.Text);
            numero2 = int.Parse(numero2.Text);

            if (rdsuma.AutoCheked == true)

            {
                suma = numero1 + numero2;
                resultado.Text = suma.ToString();
            }

            else if (rdresta.AutoChecked == true)

            {

                resta = numero1 - numero2;
                resultado.Text = resta.ToString();

            }


        }
    }
}
