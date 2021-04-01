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
    public partial class FCadTarefa : Form
    {
        public FCadTarefa()
        {
            InitializeComponent();
        }

        private void FCadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.tarefasDataSet1.responsavel);
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.tarefasDataSet1.Status);
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
            // add registro
            this.tarefaBindingSource.AddNew();

        }

        private void tarefaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tarefaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTNovo_Click(object sender, EventArgs e)
        {
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
            this.tarefaBindingSource.AddNew();

        }
    }
}
