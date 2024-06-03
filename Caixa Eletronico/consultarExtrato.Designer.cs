namespace Caixa_Eletronico
{
    partial class consultarExtrato
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
            lblCExt = new Label();
            dgvExtrato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // lblCExt
            // 
            lblCExt.AutoSize = true;
            lblCExt.Location = new Point(351, 35);
            lblCExt.Name = "lblCExt";
            lblCExt.Size = new Size(122, 20);
            lblCExt.TabIndex = 0;
            lblCExt.Text = "Consultar Extrato";
            // 
            // dgvExtrato
            // 
            dgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtrato.Location = new Point(12, 86);
            dgvExtrato.Name = "dgvExtrato";
            dgvExtrato.RowHeadersWidth = 51;
            dgvExtrato.Size = new Size(776, 352);
            dgvExtrato.TabIndex = 1;
            // 
            // consultarExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvExtrato);
            Controls.Add(lblCExt);
            Name = "consultarExtrato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "consultarExtrato";
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCExt;
        private DataGridView dgvExtrato;
    }
}