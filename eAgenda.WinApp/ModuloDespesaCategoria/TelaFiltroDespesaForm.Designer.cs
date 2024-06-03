namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    partial class TelaFiltroDespesaForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            chkdListCategoria = new CheckedListBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(218, 219);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(324, 219);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 20);
            label1.TabIndex = 14;
            label1.Text = "Selecione uma ou mais Categoria(s):";
            // 
            // chkdListCategoria
            // 
            chkdListCategoria.FormattingEnabled = true;
            chkdListCategoria.Location = new Point(12, 32);
            chkdListCategoria.Name = "chkdListCategoria";
            chkdListCategoria.Size = new Size(412, 184);
            chkdListCategoria.TabIndex = 15;
            // 
            // TelaFiltroDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 265);
            Controls.Add(chkdListCategoria);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroDespesaForm";
            ShowIcon = false;
            Text = "TelaFiltroDespesaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private CheckedListBox chkdListCategoria;
    }
}