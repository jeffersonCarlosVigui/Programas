
namespace Tarefa_Teste.View
{
    partial class frmMenu
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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amortizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.encerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratoToolStripMenuItem,
            this.amortizaçãoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contratoToolStripMenuItem.Text = "Contrato";
            this.contratoToolStripMenuItem.Click += new System.EventHandler(this.contratoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratoToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // contratoToolStripMenuItem1
            // 
            this.contratoToolStripMenuItem1.Name = "contratoToolStripMenuItem1";
            this.contratoToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.contratoToolStripMenuItem1.Text = "Contrato";
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // amortizaçãoToolStripMenuItem
            // 
            this.amortizaçãoToolStripMenuItem.Name = "amortizaçãoToolStripMenuItem";
            this.amortizaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.amortizaçãoToolStripMenuItem.Text = "Amortização";
            this.amortizaçãoToolStripMenuItem.Click += new System.EventHandler(this.amortizaçãoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem amortizaçãoToolStripMenuItem;
    }
}