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
    public partial class FrmPrincipal : Form
    {

        private List<Tempera> temperas= new List<Tempera>();
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text = "gestion de temperas";
            this.WindowState = FormWindowState.Maximized;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
            FrmTempera varTemp = new FrmTempera();
            varTemp.StartPosition = FormStartPosition.CenterScreen;
            if(DialogResult.OK == varTemp.ShowDialog())
                this.temperas.Add(varTemp.Tempera);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar varMost = new FrmMostrar(this.temperas);
            varMost.StartPosition = FormStartPosition.CenterScreen;
            varMost.Show();
        }

    }
}
