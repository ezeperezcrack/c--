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
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;
        public Tempera Tempera
        {
            get {return this._tempera ;}
        }

        public FrmTempera()
        {
            InitializeComponent();
            foreach(ConsoleColor a in Enum.GetValues(typeof(ConsoleColor)))
                this.comboBox1.Items.Add(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b;
            int.TryParse(this.textBox2.Text,out b);
            this._tempera = new Tempera((ConsoleColor)this.comboBox1.SelectedItem , this.textBox1.Text, b );
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }        
}

