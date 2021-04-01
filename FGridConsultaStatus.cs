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
    public partial class FGridConsultaStatus : Form
    {
        public FGridConsultaStatus()
        {
            InitializeComponent();
        }


        private void FGridConsultaStatus_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.tarefasDataSet1.Status);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.statusBindingSource.RemoveCurrent();
           
        }

        private void statusBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }
    }
}
