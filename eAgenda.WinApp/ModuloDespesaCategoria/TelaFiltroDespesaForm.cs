namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public partial class TelaFiltroDespesaForm : Form
    {
        private List<Categoria> categorias;

        public TelaFiltroDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();
            this.categorias = categorias;
            PreencherCategorias();
        }

        private void PreencherCategorias()
        {
            foreach (var categoria in categorias)
            {
                chkdListCategoria.Items.Add(categoria.Titulo);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (chkdListCategoria.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public List<Categoria> CategoriasSelecionadas
        {
            get
            {
                return ObterCategoriasSelecionadas();
            }
        }

        private List<Categoria> ObterCategoriasSelecionadas()
        {
            List<Categoria> categoriasSelecionadas = new List<Categoria>();
            foreach (var item in chkdListCategoria.CheckedItems)
            {
                categoriasSelecionadas.Add((Categoria)item);
            }
            return categoriasSelecionadas;
        }
    }
}
