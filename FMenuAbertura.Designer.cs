namespace Gerenciador_de_Tarefas_1
{
    partial class FMenuAbertura
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBBemVindo = new System.Windows.Forms.Label();
            this.LBtexto2 = new System.Windows.Forms.Label();
            this.BTEntrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaDoAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBBemVindo
            // 
            this.LBBemVindo.AutoSize = true;
            this.LBBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBemVindo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBBemVindo.Location = new System.Drawing.Point(299, 87);
            this.LBBemVindo.Name = "LBBemVindo";
            this.LBBemVindo.Size = new System.Drawing.Size(209, 44);
            this.LBBemVindo.TabIndex = 0;
            this.LBBemVindo.Text = "Bem-Vindo";
            this.LBBemVindo.Click += new System.EventHandler(this.LBBemVindo_Click);
            // 
            // LBtexto2
            // 
            this.LBtexto2.AutoSize = true;
            this.LBtexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtexto2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBtexto2.Location = new System.Drawing.Point(137, 146);
            this.LBtexto2.Name = "LBtexto2";
            this.LBtexto2.Size = new System.Drawing.Size(533, 44);
            this.LBtexto2.TabIndex = 1;
            this.LBtexto2.Text = "ao seu gerenciador de tarefas ";
            this.LBtexto2.Click += new System.EventHandler(this.LBtexto2_Click);
            // 
            // BTEntrar
            // 
            this.BTEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEntrar.Location = new System.Drawing.Point(331, 239);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(145, 39);
            this.BTEntrar.TabIndex = 2;
            this.BTEntrar.Text = "ENTRAR";
            this.BTEntrar.UseVisualStyleBackColor = true;
            this.BTEntrar.Click += new System.EventHandler(this.BTEntrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaDoAplicativoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // historiaDoAplicativoToolStripMenuItem
            // 
            this.historiaDoAplicativoToolStripMenuItem.Name = "historiaDoAplicativoToolStripMenuItem";
            this.historiaDoAplicativoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.historiaDoAplicativoToolStripMenuItem.Text = "Historia do Aplicativo";
            this.historiaDoAplicativoToolStripMenuItem.Click += new System.EventHandler(this.historiaDoAplicativoToolStripMenuItem_Click);
            // 
            // FMenuAbertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTEntrar);
            this.Controls.Add(this.LBtexto2);
            this.Controls.Add(this.LBBemVindo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMenuAbertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura";
            this.Load += new System.EventHandler(this.FMenuAbertura_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBBemVindo;
        private System.Windows.Forms.Label LBtexto2;
        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaDoAplicativoToolStripMenuItem;
    }
}

