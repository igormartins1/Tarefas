using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Tarefas_1
{
    public partial class FMenuAbertura : Form
    {
        public FMenuAbertura()
        {
            InitializeComponent();
        }

        private void FMenuAbertura_Load(object sender, EventArgs e)
        {

        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {

        }

        private void LBBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void LBtexto2_Click(object sender, EventArgs e)
        {

        }

        private void historiaDoAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSobre fSobre = new FSobre();
            fSobre.ShowDialog();
        }
    }
}
