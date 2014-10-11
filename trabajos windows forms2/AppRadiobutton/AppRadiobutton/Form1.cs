using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (rdOption1.Checked == true)
            {

                Width = 640;
                Height = 480;


            }

            else if (rdOption2.Checked == true)


            {

                Width = 800;
                Height = 600;


            }

            else if (rdOption3.Checked == true)

            {

                Width = 1024;
                Height = 768;

            }





        }
    }
}
