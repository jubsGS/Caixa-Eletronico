namespace Caixa_Eletronico
{
    partial class Operacao
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
            lblTipo = new Label();
            NUDValor = new NumericUpDown();
            lblValor = new Label();
            btRealizar = new Button();
            tbContaDest = new TextBox();
            lblContaDest = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDValor).BeginInit();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(187, 55);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(129, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo da Operação";
            // 
            // NUDValor
            // 
            NUDValor.DecimalPlaces = 2;
            NUDValor.Location = new Point(173, 113);
            NUDValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUDValor.Name = "NUDValor";
            NUDValor.Size = new Size(288, 27);
            NUDValor.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(94, 120);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor:";
            // 
            // btRealizar
            // 
            btRealizar.Location = new Point(118, 223);
            btRealizar.Name = "btRealizar";
            btRealizar.Size = new Size(273, 29);
            btRealizar.TabIndex = 3;
            btRealizar.Text = "Realizar";
            btRealizar.UseVisualStyleBackColor = true;
            btRealizar.Click += btRealizar_Click;
            // 
            // tbContaDest
            // 
            tbContaDest.Location = new Point(173, 160);
            tbContaDest.Name = "tbContaDest";
            tbContaDest.Size = new Size(288, 27);
            tbContaDest.TabIndex = 5;
            // 
            // lblContaDest
            // 
            lblContaDest.AutoSize = true;
            lblContaDest.Location = new Point(36, 167);
            lblContaDest.Name = "lblContaDest";
            lblContaDest.Size = new Size(104, 20);
            lblContaDest.TabIndex = 4;
            lblContaDest.Text = "Conta destino:";
            // 
            // Operacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 276);
            Controls.Add(tbContaDest);
            Controls.Add(lblContaDest);
            Controls.Add(btRealizar);
            Controls.Add(lblValor);
            Controls.Add(NUDValor);
            Controls.Add(lblTipo);
            Name = "Operacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operacao";
            ((System.ComponentModel.ISupportInitialize)NUDValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private NumericUpDown NUDValor;
        private Label lblValor;
        private Button btRealizar;
        private TextBox tbContaDest;
        private Label lblContaDest;
    }
}