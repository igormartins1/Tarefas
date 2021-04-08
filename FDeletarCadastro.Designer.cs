namespace Gerenciador_de_Tarefas_1
{
    partial class FDeletarCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDeletarCadastro));
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefasDataSet1
            // 
            this.tarefasDataSet1.DataSetName = "tarefasDataSet1";
            this.tarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.responsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            this.tarefaDataGridView.AllowUserToDeleteRows = false;
            this.tarefaDataGridView.AllowUserToOrderColumns = true;
            this.tarefaDataGridView.AutoGenerateColumns = false;
            this.tarefaDataGridView.BackgroundColor = System.Drawing.Color.LightGreen;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarefaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tarefaDataGridView.DataSource = this.tarefaBindingSource;
            this.tarefaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarefaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.Size = new System.Drawing.Size(307, 357);
            this.tarefaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTarefa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód Tarefa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FKStatus";
            this.dataGridViewTextBoxColumn3.HeaderText = "FKStatus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FKResponsavel";
            this.dataGridViewTextBoxColumn4.HeaderText = "FKResponsavel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // BTDeletar
            // 
            this.BTDeletar.Image = ((System.Drawing.Image)(resources.GetObject("BTDeletar.Image")));
            this.BTDeletar.Location = new System.Drawing.Point(254, 24);
            this.BTDeletar.Name = "BTDeletar";
            this.BTDeletar.Size = new System.Drawing.Size(41, 39);
            this.BTDeletar.TabIndex = 2;
            this.BTDeletar.UseVisualStyleBackColor = true;
            this.BTDeletar.Click += new System.EventHandler(this.BTDeletar_Click);
            // 
            // FDeletarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(307, 357);
            this.Controls.Add(this.BTDeletar);
            this.Controls.Add(this.tarefaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDeletarCadastro";
            this.Text = "....::::Deletar Cadastro..:::";
            this.Load += new System.EventHandler(this.FDeletarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private tarefasDataSet1TableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.Button BTDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}