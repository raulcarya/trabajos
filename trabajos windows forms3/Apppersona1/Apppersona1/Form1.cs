using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apppersona1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear el objeto persona
            Persona persona1 = new Persona(textBox1.Text,
                int.Parse(textBox2.Text));

            if (persona1.Edad >= 18)
            {
                MessageBox.Show("  la edad de  " + persona1.Nombre + " es: "
                    + persona1.Edad + "  mayor de 18");
            }
            
            else
            {
                MessageBox.Show(" la edad de  " + persona1.Nombre + " es: "
                       + persona1.Edad + " menor de 18");
            }









        }
    }
}
