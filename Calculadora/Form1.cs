using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Calculadora
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(dato1.Text);
            int d2 = Convert.ToInt32(dato2.Text);

            int resultado = matematicas.suma(d1,d2);
            lbl_resultado.Text = resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(dato1.Text);
            int d2 = Convert.ToInt32(dato2.Text);

            int resultado = matematicas.division(d1, d2);
            lbl_resultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(dato1.Text);
            int d2 = Convert.ToInt32(dato2.Text);

            int resultado = matematicas.suma(d1, d2);
            lbl_resultado.Text = resultado.ToString();
        }
    }
}
