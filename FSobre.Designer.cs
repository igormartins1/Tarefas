namespace Gerenciador_de_Tarefas_1
{
    partial class FSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSobre));
            this.LBsobre1 = new System.Windows.Forms.Label();
            this.LBsobre2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBsobre3 = new System.Windows.Forms.Label();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBsobre1
            // 
            this.LBsobre1.AutoSize = true;
            this.LBsobre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsobre1.Location = new System.Drawing.Point(13, 67);
            this.LBsobre1.Name = "LBsobre1";
            this.LBsobre1.Size = new System.Drawing.Size(402, 25);
            this.LBsobre1.TabIndex = 0;
            this.LBsobre1.Text = "Me Chamo Igor  sou aluno do IF Cataguases";
            // 
            // LBsobre2
            // 
            this.LBsobre2.AutoSize = true;
            this.LBsobre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsobre2.Location = new System.Drawing.Point(13, 103);
            this.LBsobre2.Name = "LBsobre2";
            this.LBsobre2.Size = new System.Drawing.Size(533, 25);
            this.LBsobre2.TabIndex = 1;
            this.LBsobre2.Text = "este projeto foi desenvolvido para  aula de  desenvolvimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "este projeto foi desenvolvido para  aula de  desenvolvimento";
            // 
            // LBsobre3
            // 
            this.LBsobre3.AutoSize = true;
            this.LBsobre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsobre3.Location = new System.Drawing.Point(13, 138);
            this.LBsobre3.Name = "LBsobre3";
            this.LBsobre3.Size = new System.Drawing.Size(310, 25);
            this.LBsobre3.TabIndex = 3;
            this.LBsobre3.Text = "para desktop com professor Bruno";
            // 
            // BTVoltar
            // 
            this.BTVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoltar.Location = new System.Drawing.Point(381, 200);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(100, 33);
            this.BTVoltar.TabIndex = 4;
            this.BTVoltar.Text = "Voltar";
            this.BTVoltar.UseVisualStyleBackColor = true;
            this.BTVoltar.Click += new System.EventHandler(this.BTVoltar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(452, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 80);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(558, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTVoltar);
            this.Controls.Add(this.LBsobre3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBsobre2);
            this.Controls.Add(this.LBsobre1);
            this.Name = "FSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia do Aplicativo ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBsobre1;
        private System.Windows.Forms.Label LBsobre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBsobre3;
        private System.Windows.Forms.Button BTVoltar;
        private System.Windows.Forms.Button button1;
    }
}