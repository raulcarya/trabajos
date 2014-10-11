using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciar objetos numero
            Numero numero1 = new Numero(int.Parse(textBox1.Text),int.Parse(textBox2.Text));

            List<int> rangoNumeros=new List<int>();
            rangoNumeros=numero1.MostrarRango();
            
            //llenar vector
            foreach(int contador2 in rangoNumeros) 
            
            {
                richTextBox1.Text = richTextBox1.Text + "  " + contador2.ToString();
            }

        }
    }
}
