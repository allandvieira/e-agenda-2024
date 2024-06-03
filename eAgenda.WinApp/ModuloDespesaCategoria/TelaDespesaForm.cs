namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;

        public Despesa Despesa
        {
            set
            {
                txtNome.Text = value.Nome;
                txtValor.Text = value.Valor.ToString();
                txtData.Value = value.Data;
                cmbPagamentos.SelectedItem = value.Pagamento;
                chkdListCategoria.SelectedItem = value.Categoria;
            }
            get
            {
                if (!Validar())
                {
                    return null;
                }

                string nome = txtNome.Text;
                int valor;
                if (!int.TryParse(txtValor.Text, out valor))
                {
                    MessageBox.Show("O campo \"valor\" deve ser um número inteiro.");
                    return null;
                }
                DateTime data = txtData.Value;
                Categoria categoria = (Categoria)chkdListCategoria.SelectedItem;
                string pagamento = cmbPagamentos.SelectedItem.ToString();

                despesa = new Despesa(nome, valor.ToString(), data, categoria, pagamento);

                return despesa;
            }
        }

        public TelaDespesaForm()
        {
            InitializeComponent();
        }

        public void CarregarCategorias(List<Categoria> categorias)
        {
            chkdListCategoria.Items.Clear();

            foreach (Categoria c in categorias)
                chkdListCategoria.Items.Add(c);
        }

        public bool Validar()
        {
            if (chkdListCategoria.CheckedItems.Count == 0)
            {
                MessageBox.Show("Você deve selecionar pelo menos uma categoria.");
                return false;
            }

            return true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int valor;
            if (!int.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("O campo \"valor\" deve ser um número inteiro.");
                return;
            }

            DateTime data = txtData.Value;
            Categoria categoria = (Categoria)chkdListCategoria.SelectedItem;
            string pagamento = cmbPagamentos.SelectedItem.ToString();

            despesa = new Despesa(nome, valor.ToString(), data, categoria, pagamento);

            List<string> erros = despesa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}
