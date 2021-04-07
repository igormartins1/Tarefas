namespace Gerenciador_de_Tarefas_1
{
    partial class FCadRespons
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
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadRespons));
            this.LBCadRespons = new System.Windows.Forms.Label();
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.responsavelTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.responsavelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNovoResp = new System.Windows.Forms.Button();
            this.BTAdicionar = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            descricaoLabel.Location = new System.Drawing.Point(57, 196);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(70, 24);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "Nome:";
            descricaoLabel.Click += new System.EventHandler(this.descricaoLabel_Click);
            // 
            // LBCadRespons
            // 
            this.LBCadRespons.AllowDrop = true;
            this.LBCadRespons.AutoSize = true;
            this.LBCadRespons.BackColor = System.Drawing.Color.Transparent;
            this.LBCadRespons.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCadRespons.ForeColor = System.Drawing.Color.ForestGreen;
            this.LBCadRespons.Location = new System.Drawing.Point(142, 120);
            this.LBCadRespons.Name = "LBCadRespons";
            this.LBCadRespons.Size = new System.Drawing.Size(402, 33);
            this.LBCadRespons.TabIndex = 6;
            this.LBCadRespons.Text = "INFORME O RESPONSÁVEL";
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
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsavelBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(173, 202);
            this.nomeTextBox.Multiline = true;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(408, 22);
            this.nomeTextBox.TabIndex = 8;
            // 
            // responsavelDataGridView
            // 
            this.responsavelDataGridView.AllowUserToAddRows = false;
            this.responsavelDataGridView.AllowUserToDeleteRows = false;
            this.responsavelDataGridView.AutoGenerateColumns = false;
            this.responsavelDataGridView.BackgroundColor = System.Drawing.Color.LightGreen;
            this.responsavelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.responsavelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.responsavelDataGridView.DataSource = this.responsavelBindingSource;
            this.responsavelDataGridView.Location = new System.Drawing.Point(716, -1);
            this.responsavelDataGridView.Name = "responsavelDataGridView";
            this.responsavelDataGridView.ReadOnly = true;
            this.responsavelDataGridView.Size = new System.Drawing.Size(217, 524);
            this.responsavelDataGridView.TabIndex = 9;
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
            // BTNovoResp
            // 
            this.BTNovoResp.Image = ((System.Drawing.Image)(resources.GetObject("BTNovoResp.Image")));
            this.BTNovoResp.Location = new System.Drawing.Point(596, -1);
            this.BTNovoResp.Name = "BTNovoResp";
            this.BTNovoResp.Size = new System.Drawing.Size(56, 58);
            this.BTNovoResp.TabIndex = 13;
            this.BTNovoResp.UseVisualStyleBackColor = true;
            this.BTNovoResp.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BTAdicionar.Image")));
            this.BTAdicionar.Location = new System.Drawing.Point(659, -1);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(50, 58);
            this.BTAdicionar.TabIndex = 14;
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTAdicionar_Click);
            // 
            // FCadRespons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 407);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.BTNovoResp);
            this.Controls.Add(this.responsavelDataGridView);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.LBCadRespons);
            this.Controls.Add(descricaoLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCadRespons";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastrar Responsável";
            this.Load += new System.EventHandler(this.FCadRespons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBCadRespons;
        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private tarefasDataSet1TableAdapters.responsavelTableAdapter responsavelTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridView responsavelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button BTNovoResp;
        private System.Windows.Forms.Button BTAdicionar;
    }
}