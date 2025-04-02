using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sumar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) +
Int64.Parse(numero_2.Text) + "";
        }
        private void CALCULADORA_TextChanged(object sender, EventArgs e)
        {
              
        }



        private void RESTA_TextChanged(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) -
Int64.Parse(numero_2.Text) + "";
    }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DIVISION_TextChanged(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) /
Int64.Parse(numero_2.Text) + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_respuesta_Click(object sender, EventArgs
e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumar_Click_1(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) +
Int64.Parse(numero_2.Text) + "";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) -
Int64.Parse(numero_2.Text) + "";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) *
Int64.Parse(numero_2.Text) + "";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            label_respuesta.Text = Int64.Parse(numero_1.Text) /
Int64.Parse(numero_2.Text) + "";
        }

        private void numero_2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
