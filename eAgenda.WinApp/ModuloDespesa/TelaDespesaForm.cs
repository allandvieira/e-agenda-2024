using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {    
        private Despesa despesa;

        public Despesa Despesa
        {
            set
            {
                txtNome.Text = value.Nome;
                txtValor.Text = value.Valor;
                txtData.Value = value.Data;
                cmbPagamentos = value.Pagamento;
                chkdListCategoria.SelectedItem = value.Categoria;
            }
            get
            {
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
    }
}