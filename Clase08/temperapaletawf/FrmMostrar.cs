using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase08;

namespace temperapaletawf
{
    public partial class FrmMostrar : Form
    {
        private List<Tempera> _tempera;

        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar (List<Tempera> lista):this()
        {
            this._tempera = lista;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
           _refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = this.listBox1.SelectedIndex;
            if (i > -1)
                this._tempera.RemoveAt(i);
            _refrescar();
        }

        private void _refrescar()
        {
            this.listBox1.Items.Clear();
            foreach (Tempera a in this._tempera)
                this.listBox1.Items.Add(Tempera.Mostrar(a));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
