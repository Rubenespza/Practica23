using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica23
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

        private void button1_Click(object sender, EventArgs e)
        {
            Determinar x = new Determinar();
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            int n4 = int.Parse(textBox4.Text);
            int n5 = int.Parse(textBox5.Text);
            string cadena = x.numayor(n1, n2, n3, n4, n5);
            MessageBox.Show(cadena, "Numero Mayor", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
    }
}