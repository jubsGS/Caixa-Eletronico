namespace Caixa_Eletronico
{
    partial class FrmInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAdm = new Button();
            btCaixa = new Button();
            SuspendLayout();
            // 
            // btAdm
            // 
            btAdm.Location = new Point(45, 60);
            btAdm.Margin = new Padding(3, 4, 3, 4);
            btAdm.Name = "btAdm";
            btAdm.Size = new Size(253, 31);
            btAdm.TabIndex = 0;
            btAdm.Text = "Acesso Administrativo";
            btAdm.UseVisualStyleBackColor = true;
            btAdm.Click += btAdm_Click;
            // 
            // btCaixa
            // 
            btCaixa.Location = new Point(45, 119);
            btCaixa.Margin = new Padding(3, 4, 3, 4);
            btCaixa.Name = "btCaixa";
            btCaixa.Size = new Size(253, 31);
            btCaixa.TabIndex = 1;
            btCaixa.Text = "Caixa Eletrônico";
            btCaixa.UseVisualStyleBackColor = true;
            btCaixa.Click += btCaixa_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 212);
            Controls.Add(btCaixa);
            Controls.Add(btAdm);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CTiBank";
            FormClosed += FrmInicial_FormClosed;
            Load += FrmInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btAdm;
        private Button btCaixa;
    }
}
