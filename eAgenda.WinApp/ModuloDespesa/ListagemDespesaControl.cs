namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class ListagemDespesaControl : UserControl
    {
        public ListagemDespesaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            listDespesas.Items.Clear();

            foreach (Despesa despesa in despesas)
                listDespesas.Items.Add(despesa);
        }

        public Despesa ObterRegistroSelecionado()
        {
            if (listDespesas.SelectedItem == null)
                return null;

            return (Despesa)listDespesas.SelectedItem;
        }
    }
}
