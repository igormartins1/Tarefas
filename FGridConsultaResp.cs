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
    public partial class FGridConsultaResp : Form
    {
        public FGridConsultaResp()
        {
            InitializeComponent();
        }


        private void FGridConsultaResp_Load(object sender, EventArgs e)
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

        private void BTDelete_Click(object sender, EventArgs e)
        {
            this.responsavelBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }
    }
}
