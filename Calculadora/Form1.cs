using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_uno.Text) + Int64.Parse(numero_dos.Text) + "";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_uno.Text) - Int64.Parse(numero_dos.Text) + "";
        }

        private void division_Click(object sender, EventArgs e)
        
        {
            if (numero_dos.Text.Equals("0"))
            {
                label_respuesta.Text = "Error div x 0";
            }
            else
            {
                label_respuesta.Text = Int64.Parse(numero_uno.Text) / Int64.Parse(numero_dos.Text) + "";
            }
           
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_uno.Text) * Int64.Parse(numero_dos.Text) + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
