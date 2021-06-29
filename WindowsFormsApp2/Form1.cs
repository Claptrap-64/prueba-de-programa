using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("el campo Empresa esta blanco");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("el campo Dinero esta blanco");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("el campo Factura esta blanco");
                return;
            }
            MessageBox.Show("se guardo la factura");
        }
    }
}
