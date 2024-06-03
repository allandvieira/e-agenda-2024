namespace eAgenda.WinApp.ModuloCategoria
{
    public partial class ListagemCategoriaControl : UserControl
    {
        public ListagemCategoriaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            listCategorias.Items.Clear();

            foreach (Categoria categoria in categorias)
                listCategorias.Items.Add(categoria);
        }

        public Categoria ObterRegistroSelecionado()
        {
            if (listCategorias.SelectedItem == null)
                return null;

            return (Categoria)listCategorias.SelectedItem;
        }
    }
}
