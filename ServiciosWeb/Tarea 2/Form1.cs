using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (textBox1.Text == "Carlos"){
                id = 1;
            }else if (textBox1.Text == "Daniel"){
                id = 2;
            }else if(textBox1.Text == "Alonzo"){
                id = 3;
            }

            RealizacionDeOperaciones r = new RealizacionDeOperaciones(id);
            r.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
