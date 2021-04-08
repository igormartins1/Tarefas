namespace Gerenciador_de_Tarefas_1
{
    partial class FGridConsultaResp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGridConsultaResp));
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.responsavelTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.responsavelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefasDataSet1
            // 
            this.tarefasDataSet1.DataSetName = "tarefasDataSet1";
            this.tarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "responsavel";
            this.responsavelBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.responsavelTableAdapter = this.responsavelTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // responsavelDataGridView
            // 
            this.responsavelDataGridView.AllowUserToAddRows = false;
            this.responsavelDataGridView.AllowUserToDeleteRows = false;
            this.responsavelDataGridView.AllowUserToOrderColumns = true;
            this.responsavelDataGridView.AutoGenerateColumns = false;
            this.responsavelDataGridView.BackgroundColor = System.Drawing.Color.LightGreen;
            this.responsavelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.responsavelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.responsavelDataGridView.DataSource = this.responsavelBindingSource;
            this.responsavelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responsavelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.responsavelDataGridView.Name = "responsavelDataGridView";
            this.responsavelDataGridView.ReadOnly = true;
            this.responsavelDataGridView.Size = new System.Drawing.Size(185, 450);
            this.responsavelDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdResponsavel";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdResponsavel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FGridConsultaResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(185, 450);
            this.Controls.Add(this.responsavelDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FGridConsultaResp";
            this.Text = "...::Consultar Responsável..:::";
            this.Load += new System.EventHandler(this.FGridConsultaResp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private tarefasDataSet1TableAdapters.responsavelTableAdapter responsavelTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView responsavelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}