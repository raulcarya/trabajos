using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appedadnombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        DialogResult dialogResult = MessageBox.Show("seguro", "confirmacion", MessageBoxButtons.YesNo); 
        if(dialogResult == DialogResult.Yes)
         {
             label1.Text = "";
             label2.Text = "";
             label3.Text = "";
        
         } 
        
        else if (dialogResult == DialogResult.No) 
        
        {
        }

        }
    }
}
