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
    public partial class FCadRespons : Form
    {
        public FCadRespons()
        {
            InitializeComponent();
        }

       

        private void FCadRespons_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.tarefasDataSet1.responsavel);
           

        }

        private void responsavelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
          

        }

        private void BTNovo_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.responsavelTableAdapter.Fill(this.tarefasDataSet1.responsavel);
            this.responsavelBindingSource.AddNew();
        }

        private void BTAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.responsavelBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void descricaoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
