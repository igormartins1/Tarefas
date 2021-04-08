namespace Gerenciador_de_Tarefas_1
{
    partial class FGridConsultaStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGridConsultaStatus));
            this.button1 = new System.Windows.Forms.Button();
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.StatusTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.statusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDataGridView.Location = new System.Drawing.Point(0, 0);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.ReadOnly = true;
            this.statusDataGridView.Size = new System.Drawing.Size(244, 254);
            this.statusDataGridView.TabIndex = 4;
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
            // FGridConsultaStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(244, 254);
            this.Controls.Add(this.statusDataGridView);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FGridConsultaStatus";
            this.Text = "..:::Consulta Status::...";
            this.Load += new System.EventHandler(this.FGridConsultaStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private tarefasDataSet1TableAdapters.StatusTableAdapter statusTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}