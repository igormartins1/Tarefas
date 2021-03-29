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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tarefasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaDoAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.tarefasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tarefasToolStripMenuItem1,
            this.statusToolStripMenuItem,
            this.responsávelToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // tarefasToolStripMenuItem
            // 
            this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tarefasToolStripMenuItem.Text = "Tarefa";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaDoAplicativoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tarefasToolStripMenuItem1
            // 
            this.tarefasToolStripMenuItem1.Name = "tarefasToolStripMenuItem1";
            this.tarefasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tarefasToolStripMenuItem1.Text = "Tarefas";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            // 
            // historiaDoAplicativoToolStripMenuItem
            // 
            this.historiaDoAplicativoToolStripMenuItem.Name = "historiaDoAplicativoToolStripMenuItem";
            this.historiaDoAplicativoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.historiaDoAplicativoToolStripMenuItem.Text = "Historia do Aplicativo";
            // 
            // FGridConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FGridConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tarefas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaDoAplicativoToolStripMenuItem;
    }
}