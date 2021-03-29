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
    public partial class FSobre : Form
    {
        public FSobre()
        {
            InitializeComponent();
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            FMenuAbertura fmenuAbertura = new FMenuAbertura();
            fmenuAbertura.ShowDialog();
        }
    }
}
