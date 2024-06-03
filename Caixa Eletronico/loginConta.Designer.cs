namespace Caixa_Eletronico
{
    partial class loginConta
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
            lblConta = new Label();
            tbConta = new TextBox();
            btAcessar = new Button();
            SuspendLayout();
            // 
            // lblConta
            // 
            lblConta.AutoSize = true;
            lblConta.Location = new Point(81, 57);
            lblConta.Name = "lblConta";
            lblConta.Size = new Size(51, 20);
            lblConta.TabIndex = 0;
            lblConta.Text = "Conta:";
            // 
            // tbConta
            // 
            tbConta.Location = new Point(160, 50);
            tbConta.Name = "tbConta";
            tbConta.Size = new Size(174, 27);
            tbConta.TabIndex = 2;
            // 
            // btAcessar
            // 
            btAcessar.Location = new Point(160, 116);
            btAcessar.Name = "btAcessar";
            btAcessar.Size = new Size(94, 29);
            btAcessar.TabIndex = 3;
            btAcessar.Text = "Acessar";
            btAcessar.UseVisualStyleBackColor = true;
            btAcessar.Click += btAcessar_Click;
            // 
            // loginConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 207);
            Controls.Add(btAcessar);
            Controls.Add(tbConta);
            Controls.Add(lblConta);
            Name = "loginConta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConta;
        private TextBox tbConta;
        private Button btAcessar;
    }
}