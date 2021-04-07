namespace Gerenciador_de_Tarefas_1
{
    partial class FCadTarefa
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
            System.Windows.Forms.Label LBNomeTarefa;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadTarefa));
            this.tarefasDataSet1 = new Gerenciador_de_Tarefas_1.tarefasDataSet1();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.TableAdapterManager();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.fKStatusListBox = new System.Windows.Forms.ListBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKResponsavelListBox = new System.Windows.Forms.ListBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.StatusTableAdapter();
            this.responsavelTableAdapter = new Gerenciador_de_Tarefas_1.tarefasDataSet1TableAdapters.responsavelTableAdapter();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.BTNovoResp = new System.Windows.Forms.Button();
            LBNomeTarefa = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBNomeTarefa
            // 
            LBNomeTarefa.AutoSize = true;
            LBNomeTarefa.BackColor = System.Drawing.Color.Transparent;
            LBNomeTarefa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LBNomeTarefa.ForeColor = System.Drawing.SystemColors.Desktop;
            LBNomeTarefa.Location = new System.Drawing.Point(160, 100);
            LBNomeTarefa.Name = "LBNomeTarefa";
            LBNomeTarefa.Size = new System.Drawing.Size(73, 23);
            LBNomeTarefa.TabIndex = 9;
            LBNomeTarefa.Text = "Tarefa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Desktop;
            label1.Location = new System.Drawing.Point(71, 199);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 23);
            label1.TabIndex = 10;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Desktop;
            label2.Location = new System.Drawing.Point(428, 199);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 23);
            label2.TabIndex = 11;
            label2.Text = "Responsável";
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
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(253, 100);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(352, 30);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // fKStatusListBox
            // 
            this.fKStatusListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKStatus", true));
            this.fKStatusListBox.DataSource = this.statusBindingSource;
            this.fKStatusListBox.DisplayMember = "Descricao";
            this.fKStatusListBox.FormattingEnabled = true;
            this.fKStatusListBox.Location = new System.Drawing.Point(155, 166);
            this.fKStatusListBox.Name = "fKStatusListBox";
            this.fKStatusListBox.Size = new System.Drawing.Size(160, 108);
            this.fKStatusListBox.TabIndex = 3;
            this.fKStatusListBox.ValueMember = "IdStatus";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // fKResponsavelListBox
            // 
            this.fKResponsavelListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKResponsavel", true));
            this.fKResponsavelListBox.DataSource = this.responsavelBindingSource;
            this.fKResponsavelListBox.DisplayMember = "Nome";
            this.fKResponsavelListBox.FormattingEnabled = true;
            this.fKResponsavelListBox.Location = new System.Drawing.Point(554, 166);
            this.fKResponsavelListBox.Name = "fKResponsavelListBox";
            this.fKResponsavelListBox.Size = new System.Drawing.Size(167, 108);
            this.fKResponsavelListBox.TabIndex = 4;
            this.fKResponsavelListBox.ValueMember = "IdResponsavel";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "responsavel";
            this.responsavelBindingSource.DataSource = this.tarefasDataSet1;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BTAdicionar.Image")));
            this.BTAdicionar.Location = new System.Drawing.Point(745, 12);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(43, 50);
            this.BTAdicionar.TabIndex = 5;
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTAdicionar_Click);
            // 
            // BTNovoResp
            // 
            this.BTNovoResp.Image = ((System.Drawing.Image)(resources.GetObject("BTNovoResp.Image")));
            this.BTNovoResp.Location = new System.Drawing.Point(691, 12);
            this.BTNovoResp.Name = "BTNovoResp";
            this.BTNovoResp.Size = new System.Drawing.Size(48, 50);
            this.BTNovoResp.TabIndex = 1;
            this.BTNovoResp.UseVisualStyleBackColor = true;
            this.BTNovoResp.Click += new System.EventHandler(this.BTNovoResp_Click);
            // 
            // FCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.BTNovoResp);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.fKStatusListBox);
            this.Controls.Add(this.fKResponsavelListBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(LBNomeTarefa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCadTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tarefa";
            this.Load += new System.EventHandler(this.FCadTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tarefasDataSet1 tarefasDataSet1;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private tarefasDataSet1TableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private tarefasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ListBox fKStatusListBox;
        private System.Windows.Forms.ListBox fKResponsavelListBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private tarefasDataSet1TableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private tarefasDataSet1TableAdapters.responsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.Button BTNovoResp;
    }
}