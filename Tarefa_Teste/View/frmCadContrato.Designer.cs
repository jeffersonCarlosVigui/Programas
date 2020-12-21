
namespace Tarefa_Teste.View
{
    partial class frmCadContrato
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
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNumContrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Taxa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVlrContrato = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPeriodicidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataContrato = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataVenvMask = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(117, 35);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(121, 20);
            this.txtCpfCnpj.TabIndex = 0;
            this.txtCpfCnpj.TextChanged += new System.EventHandler(this.txtCpfCnpj_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cpf/Cnpj Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtNumContrato
            // 
            this.txtNumContrato.Location = new System.Drawing.Point(117, 85);
            this.txtNumContrato.Name = "txtNumContrato";
            this.txtNumContrato.Size = new System.Drawing.Size(121, 20);
            this.txtNumContrato.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Num Contrato";
            // 
            // Taxa
            // 
            this.Taxa.AutoSize = true;
            this.Taxa.Location = new System.Drawing.Point(501, 88);
            this.Taxa.Name = "Taxa";
            this.Taxa.Size = new System.Drawing.Size(31, 13);
            this.Taxa.TabIndex = 5;
            this.Taxa.Text = "Taxa";
            this.Taxa.Click += new System.EventHandler(this.Taxa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Periodicidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Valor Contrato";
            // 
            // txtVlrContrato
            // 
            this.txtVlrContrato.Location = new System.Drawing.Point(339, 85);
            this.txtVlrContrato.Name = "txtVlrContrato";
            this.txtVlrContrato.Size = new System.Drawing.Size(121, 20);
            this.txtVlrContrato.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 12;
            // 
            // txtPeriodicidade
            // 
            this.txtPeriodicidade.Location = new System.Drawing.Point(117, 125);
            this.txtPeriodicidade.Name = "txtPeriodicidade";
            this.txtPeriodicidade.Size = new System.Drawing.Size(95, 20);
            this.txtPeriodicidade.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Contrato";
            // 
            // txtDataContrato
            // 
            this.txtDataContrato.Location = new System.Drawing.Point(339, 121);
            this.txtDataContrato.Mask = "00/00/0000";
            this.txtDataContrato.Name = "txtDataContrato";
            this.txtDataContrato.Size = new System.Drawing.Size(75, 20);
            this.txtDataContrato.TabIndex = 15;
            this.txtDataContrato.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Venc.";
            // 
            // txtDataVenvMask
            // 
            this.txtDataVenvMask.Location = new System.Drawing.Point(584, 117);
            this.txtDataVenvMask.Mask = "00/00/0000";
            this.txtDataVenvMask.Name = "txtDataVenvMask";
            this.txtDataVenvMask.Size = new System.Drawing.Size(75, 20);
            this.txtDataVenvMask.TabIndex = 17;
            this.txtDataVenvMask.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Gravar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(584, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmCadContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 259);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDataVenvMask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataContrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeriodicidade);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtVlrContrato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Taxa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumContrato);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpfCnpj);
            this.Name = "frmCadContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato Credito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Taxa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVlrContrato;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPeriodicidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDataContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDataVenvMask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}