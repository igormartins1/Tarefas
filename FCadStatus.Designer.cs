namespace Gerenciador_de_Tarefas_1
{
    partial class FCadStatus
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
            System.Windows.Forms.Label LBDescricao;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadStatus));
            this.LTituloStatus = new System.Windows.Forms.Label();
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.StatusTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.BTNovo = new System.Windows.Forms.Button();
            LBDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LBDescricao
            // 
            LBDescricao.AutoSize = true;
            LBDescricao.BackColor = System.Drawing.Color.Transparent;
            LBDescricao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LBDescricao.ForeColor = System.Drawing.Color.Black;
            LBDescricao.Location = new System.Drawing.Point(22, 157);
            LBDescricao.Name = "LBDescricao";
            LBDescricao.Size = new System.Drawing.Size(141, 24);
            LBDescricao.TabIndex = 1;
            LBDescricao.Text = "DESCRIÇÃO:";
            LBDescricao.Click += new System.EventHandler(this.descricaoLabel_Click);
            // 
            // LTituloStatus
            // 
            this.LTituloStatus.AllowDrop = true;
            this.LTituloStatus.AutoSize = true;
            this.LTituloStatus.BackColor = System.Drawing.Color.Transparent;
            this.LTituloStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.LTituloStatus.Location = new System.Drawing.Point(140, 82);
            this.LTituloStatus.Name = "LTituloStatus";
            this.LTituloStatus.Size = new System.Drawing.Size(302, 33);
            this.LTituloStatus.TabIndex = 7;
            this.LTituloStatus.Text = "INFORME O STATUS";
            this.LTituloStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTituloStatus.Click += new System.EventHandler(this.LBCadRespons_Click);
            // 
            // tarefasDataSet1
            // 
            this.tarefasDataSet1.DataSetName = "tarefasDataSet1";
            this.tarefasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.responsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(160, 155);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(262, 26);
            this.descricaoTextBox.TabIndex = 9;
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AllowUserToAddRows = false;
            this.statusDataGridView.AllowUserToDeleteRows = false;
            this.statusDataGridView.AllowUserToOrderColumns = true;
            this.statusDataGridView.AutoGenerateColumns = false;
            this.statusDataGridView.BackgroundColor = System.Drawing.Color.LightGreen;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.statusDataGridView.DataSource = this.statusBindingSource;
            this.statusDataGridView.Location = new System.Drawing.Point(572, 1);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.ReadOnly = true;
            this.statusDataGridView.Size = new System.Drawing.Size(244, 301);
            this.statusDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStatus";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BTAdicionar.Image")));
            this.BTAdicionar.Location = new System.Drawing.Point(511, 1);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(43, 50);
            this.BTAdicionar.TabIndex = 11;
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTExibir_Click);
            // 
            // BTNovo
            // 
            this.BTNovo.Image = ((System.Drawing.Image)(resources.GetObject("BTNovo.Image")));
            this.BTNovo.Location = new System.Drawing.Point(467, 1);
            this.BTNovo.Name = "BTNovo";
            this.BTNovo.Size = new System.Drawing.Size(48, 50);
            this.BTNovo.TabIndex = 12;
            this.BTNovo.UseVisualStyleBackColor = true;
            this.BTNovo.Click += new System.EventHandler(this.BTNovo_Click);
            // 
            // FCadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 301);
            this.Controls.Add(this.BTNovo);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.statusDataGridView);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.LTituloStatus);
            this.Controls.Add(LBDescricao);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCadStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastrar Status";
            this.Load += new System.EventHandler(this.FCadStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTituloStatus;
        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private tarefasDataSet1TableAdapters.StatusTableAdapter statusTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.Button BTNovo;
    }
}