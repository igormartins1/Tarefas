namespace Gerenciador_de_Tarefas_1
{
    partial class FGridConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGridConsulta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsavelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaDoAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.tarefaTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.selectQueryDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectQueryDadosTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.SelectQueryDadosTableAdapter();
            this.selectQueryDadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefaToolStripMenuItem,
            this.responsavelToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(726, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "MEnuGridConsuta";
            // 
            // tarefaToolStripMenuItem
            // 
            this.tarefaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tarefaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.tarefaToolStripMenuItem.Name = "tarefaToolStripMenuItem";
            this.tarefaToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.tarefaToolStripMenuItem.Text = "Tarefa";
            this.tarefaToolStripMenuItem.Click += new System.EventHandler(this.tarefaToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // responsavelToolStripMenuItem
            // 
            this.responsavelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.responsavelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.listarToolStripMenuItem1});
            this.responsavelToolStripMenuItem.Name = "responsavelToolStripMenuItem";
            this.responsavelToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.responsavelToolStripMenuItem.Text = "Responsavel";
            this.responsavelToolStripMenuItem.Click += new System.EventHandler(this.responsavelToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.listarToolStripMenuItem2});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click_1);
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar ";
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaDoAplicativoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(52, 27);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // historiaDoAplicativoToolStripMenuItem
            // 
            this.historiaDoAplicativoToolStripMenuItem.Name = "historiaDoAplicativoToolStripMenuItem";
            this.historiaDoAplicativoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.historiaDoAplicativoToolStripMenuItem.Text = "Historia do Aplicativo";
            this.historiaDoAplicativoToolStripMenuItem.Click += new System.EventHandler(this.historiaDoAplicativoToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen;
            this.atualizarToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click_1);
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // tarefasDataSet1
            // 
            this.tarefasDataSet1.DataSetName = "tarefasDataSet1";
            this.tarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // selectQueryDadosBindingSource
            // 
            this.selectQueryDadosBindingSource.DataMember = "SelectQueryDados";
            this.selectQueryDadosBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // selectQueryDadosTableAdapter
            // 
            this.selectQueryDadosTableAdapter.ClearBeforeFill = true;
            // 
            // selectQueryDadosDataGridView
            // 
            this.selectQueryDadosDataGridView.AllowUserToAddRows = false;
            this.selectQueryDadosDataGridView.AllowUserToDeleteRows = false;
            this.selectQueryDadosDataGridView.AutoGenerateColumns = false;
            this.selectQueryDadosDataGridView.BackgroundColor = System.Drawing.Color.LightGreen;
            this.selectQueryDadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectQueryDadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.selectQueryDadosDataGridView.DataSource = this.selectQueryDadosBindingSource;
            this.selectQueryDadosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectQueryDadosDataGridView.Location = new System.Drawing.Point(0, 31);
            this.selectQueryDadosDataGridView.Name = "selectQueryDadosDataGridView";
            this.selectQueryDadosDataGridView.ReadOnly = true;
            this.selectQueryDadosDataGridView.Size = new System.Drawing.Size(726, 539);
            this.selectQueryDadosDataGridView.TabIndex = 2;
            this.selectQueryDadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectQueryDadosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descrição";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Responsavel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Responsavel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FGridConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(726, 570);
            this.Controls.Add(this.selectQueryDadosDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FGridConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...::::Consultar Tarefas:::..";
            this.Load += new System.EventHandler(this.FGridConsulta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsavelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaDoAplicativoToolStripMenuItem;
        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private tarefasDataSet1TableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource selectQueryDadosBindingSource;
        private tarefasDataSet1TableAdapters.SelectQueryDadosTableAdapter selectQueryDadosTableAdapter;
        private System.Windows.Forms.DataGridView selectQueryDadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
    }
}