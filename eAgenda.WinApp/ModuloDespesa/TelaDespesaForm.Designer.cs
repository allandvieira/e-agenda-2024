namespace eAgenda.WinApp.ModuloDespesa
{
    partial class TelaDespesaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtValor = new TextBox();
            txtData = new DateTimePicker();
            label4 = new Label();
            cmbPagamentos = new ComboBox();
            label5 = new Label();
            chkdListCategoria = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(15, 101);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F);
            txtNome.Location = new Point(74, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 27);
            txtNome.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11.25F);
            txtValor.Location = new Point(74, 63);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(129, 27);
            txtValor.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 11.25F);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(74, 96);
            txtData.Name = "txtData";
            txtData.Size = new Size(129, 27);
            txtData.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 137);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 6;
            label4.Text = "Tipo de pagamento:";
            // 
            // cmbPagamentos
            // 
            cmbPagamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamentos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPagamentos.FormattingEnabled = true;
            cmbPagamentos.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito" });
            cmbPagamentos.Location = new Point(17, 160);
            cmbPagamentos.Name = "cmbPagamentos";
            cmbPagamentos.Size = new Size(220, 28);
            cmbPagamentos.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 207);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 6;
            label5.Text = "Categoria(s):";
            // 
            // chkdListCategoria
            // 
            chkdListCategoria.FormattingEnabled = true;
            chkdListCategoria.Location = new Point(17, 230);
            chkdListCategoria.Name = "chkdListCategoria";
            chkdListCategoria.Size = new Size(398, 202);
            chkdListCategoria.TabIndex = 4;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(209, 438);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(315, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 481);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(chkdListCategoria);
            Controls.Add(label5);
            Controls.Add(cmbPagamentos);
            Controls.Add(label4);
            Controls.Add(txtData);
            Controls.Add(txtValor);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDespesaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadadastro de Despesa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtValor;
        private DateTimePicker txtData;
        private Label label4;
        private ComboBox cmbPagamentos;
        private Label label5;
        private CheckedListBox chkdListCategoria;
        private Button btnGravar;
        private Button btnCancelar;
    }
}