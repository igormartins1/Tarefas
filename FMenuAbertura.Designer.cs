﻿namespace Gerenciador_de_Tarefas_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuAbertura));
            this.LBBemVindo = new System.Windows.Forms.Label();
            this.LBtexto2 = new System.Windows.Forms.Label();
            this.BTEntrar = new System.Windows.Forms.Button();
            this.MENAbertura = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaDoAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENAbertura.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBBemVindo
            // 
            this.LBBemVindo.AutoSize = true;
            this.LBBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.LBBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBemVindo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LBBemVindo.Location = new System.Drawing.Point(321, 81);
            this.LBBemVindo.Name = "LBBemVindo";
            this.LBBemVindo.Size = new System.Drawing.Size(195, 39);
            this.LBBemVindo.TabIndex = 0;
            this.LBBemVindo.Text = "Bem-Vindo";
            this.LBBemVindo.Click += new System.EventHandler(this.LBBemVindo_Click);
            // 
            // LBtexto2
            // 
            this.LBtexto2.AutoSize = true;
            this.LBtexto2.BackColor = System.Drawing.Color.Transparent;
            this.LBtexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtexto2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LBtexto2.Location = new System.Drawing.Point(176, 146);
            this.LBtexto2.Name = "LBtexto2";
            this.LBtexto2.Size = new System.Drawing.Size(506, 39);
            this.LBtexto2.TabIndex = 1;
            this.LBtexto2.Text = "ao seu gerenciador de tarefas ";
            this.LBtexto2.Click += new System.EventHandler(this.LBtexto2_Click);
            // 
            // BTEntrar
            // 
            this.BTEntrar.BackColor = System.Drawing.Color.OliveDrab;
            this.BTEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEntrar.ForeColor = System.Drawing.Color.White;
            this.BTEntrar.Location = new System.Drawing.Point(331, 239);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(167, 39);
            this.BTEntrar.TabIndex = 2;
            this.BTEntrar.Text = "Clique Aqui";
            this.BTEntrar.UseVisualStyleBackColor = false;
            this.BTEntrar.Click += new System.EventHandler(this.BTEntrar_Click);
            // 
            // MENAbertura
            // 
            this.MENAbertura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MENAbertura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.MENAbertura.Location = new System.Drawing.Point(0, 0);
            this.MENAbertura.Name = "MENAbertura";
            this.MENAbertura.Size = new System.Drawing.Size(806, 24);
            this.MENAbertura.TabIndex = 3;
            this.MENAbertura.Text = "MenuPrincipal";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaDoAplicativoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // historiaDoAplicativoToolStripMenuItem
            // 
            this.historiaDoAplicativoToolStripMenuItem.Name = "historiaDoAplicativoToolStripMenuItem";
            this.historiaDoAplicativoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.historiaDoAplicativoToolStripMenuItem.Text = "Historia do Aplicativo";
            this.historiaDoAplicativoToolStripMenuItem.Click += new System.EventHandler(this.historiaDoAplicativoToolStripMenuItem_Click_1);
            // 
            // FMenuAbertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 295);
            this.Controls.Add(this.BTEntrar);
            this.Controls.Add(this.LBtexto2);
            this.Controls.Add(this.LBBemVindo);
            this.Controls.Add(this.MENAbertura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMenuAbertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..::::Abertura::...";
            this.Load += new System.EventHandler(this.FMenuAbertura_Load);
            this.MENAbertura.ResumeLayout(false);
            this.MENAbertura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBBemVindo;
        private System.Windows.Forms.Label LBtexto2;
        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.MenuStrip MENAbertura;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaDoAplicativoToolStripMenuItem;
    }
}

