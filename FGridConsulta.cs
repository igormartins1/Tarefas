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
    public partial class FGridConsulta : Form
    {
        public FGridConsulta()
        {
            InitializeComponent();
        }

        private void tarefasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FCadRespons fCad = new FCadRespons();
            fCad.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCadStatus fCadStatus = new FCadStatus();
            fCadStatus.ShowDialog();
        }

        private void responsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCadTarefa fCadTarefa = new FCadTarefa();
            fCadTarefa.ShowDialog();
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FGridConsultaStatus consultaStatus = new FGridConsultaStatus();
            consultaStatus.ShowDialog();
        }

        private void responsávelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FGridConsultaResp consultaResp = new FGridConsultaResp();
            consultaResp.ShowDialog();
        }


        private void FGridConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.SelectQueryDados'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryDadosTableAdapter.Fill(this.tarefasDataSet1.SelectQueryDados);
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
           

        }

        private void tarefaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCadTarefa fCadTarefa = new FCadTarefa();
            fCadTarefa.ShowDialog();
            // carrega a grid 
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FCadRespons fCadRespons = new FCadRespons();
            fCadRespons.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefasDataSet1.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCadStatus fCad = new FCadStatus();
            fCad.ShowDialog();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FGridConsultaStatus fGridConsulta = new FGridConsultaStatus();
            fGridConsulta.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FGridConsultaStatus fGrid = new FGridConsultaStatus();
            fGrid.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FGridConsultaResp fGrid1 = new FGridConsultaResp();
            fGrid1.ShowDialog();
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            this.tarefaBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

        }

        private void historiaDoAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSobre sobre = new FSobre();
            sobre.ShowDialog();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BTDelete_Click_1(object sender, EventArgs e)
        {
            this.tarefaBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tarefaBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDeletarCadastro fDeletar = new FDeletarCadastro();
            fDeletar.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);
            this.tarefaBindingSource.AddNew();

        }

        private void atualizarToolStripMenuItem_Click_1(object sender, EventArgs e)

        {

            this.Validate();

            this.selectQueryDadosBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.tarefasDataSet1);

            this.tarefaTableAdapter.Fill(this.tarefasDataSet1.Tarefa);

            this.selectQueryDadosTableAdapter.Fill(this.tarefasDataSet1.SelectQueryDados);

            

           
        }

        private void selectQueryDadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void responsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
