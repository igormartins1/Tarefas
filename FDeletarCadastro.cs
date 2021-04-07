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
    public partial class FDeletarCadastro : Form
    {
        public FDeletarCadastro()
        {
            InitializeComponent();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }

        private void FDeletarCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);

        }

        private void BTDeletar_Click(object sender, EventArgs e)
        {
            this.tarefaBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }
    }
}
