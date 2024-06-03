namespace Caixa_Eletronico
{
    partial class telaPrincipal
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
            btVoltar = new Button();
            btSacar = new Button();
            btTransferir = new Button();
            btVerExtrato = new Button();
            btDepositar = new Button();
            label1 = new Label();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(12, 50);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(94, 29);
            btVoltar.TabIndex = 0;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btSacar
            // 
            btSacar.Location = new Point(12, 150);
            btSacar.Name = "btSacar";
            btSacar.Size = new Size(391, 29);
            btSacar.TabIndex = 1;
            btSacar.Text = "Sacar";
            btSacar.UseVisualStyleBackColor = true;
            btSacar.Click += btSacar_Click;
            // 
            // btTransferir
            // 
            btTransferir.Location = new Point(12, 185);
            btTransferir.Name = "btTransferir";
            btTransferir.Size = new Size(391, 29);
            btTransferir.TabIndex = 2;
            btTransferir.Text = "Transferir";
            btTransferir.UseVisualStyleBackColor = true;
            btTransferir.Click += btTransferir_Click;
            // 
            // btVerExtrato
            // 
            btVerExtrato.Location = new Point(12, 220);
            btVerExtrato.Name = "btVerExtrato";
            btVerExtrato.Size = new Size(391, 29);
            btVerExtrato.TabIndex = 3;
            btVerExtrato.Text = "Ver Extrato";
            btVerExtrato.UseVisualStyleBackColor = true;
            btVerExtrato.Click += btVerExtrato_Click;
            // 
            // btDepositar
            // 
            btDepositar.Location = new Point(12, 115);
            btDepositar.Name = "btDepositar";
            btDepositar.Size = new Size(391, 29);
            btDepositar.TabIndex = 4;
            btDepositar.Text = "Depositar";
            btDepositar.UseVisualStyleBackColor = true;
            btDepositar.Click += btDepositar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Valor:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(324, 59);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(44, 20);
            lblSaldo.TabIndex = 6;
            lblSaldo.Text = "00,00";
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 309);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btDepositar);
            Controls.Add(btVerExtrato);
            Controls.Add(btTransferir);
            Controls.Add(btSacar);
            Controls.Add(btVoltar);
            Name = "telaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVoltar;
        private Button btSacar;
        private Button btTransferir;
        private Button btVerExtrato;
        private Button btDepositar;
        private Label label1;
        private Label lblSaldo;
    }
}