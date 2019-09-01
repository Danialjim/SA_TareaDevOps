using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2
{
    public partial class RealizacionDeOperaciones : Form
    {
        int id = 0;
        public RealizacionDeOperaciones(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESB.SolicitarServicio(id);
            label1.Text = ESB.mensajeClinte;
        }
    }
}
