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
    public partial class FCadStatus : Form
    {
        public FCadStatus()
        {
            InitializeComponent();
        }

        private void FCadStatus_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.tarefasDataSet1.Status);
           
        }

        private void LBCadRespons_Click(object sender, EventArgs e)
        {

        }

        private void descricaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BTExibir_Click(object sender, EventArgs e)
        {
            try
            {
                this.statusBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTNovo_Click(object sender, EventArgs e)
        {
            this.statusTableAdapter.Fill(this.tarefasDataSet1.Status);
            this.statusBindingSource.AddNew();

        }
    }
}
