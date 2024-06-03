using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Categoria> categoria)
        {
            grid.Rows.Clear();

            foreach (Categoria c in categoria)
                grid.Rows.Add(c.Id, c.Titulo.ToTitleCase());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
                        };
        }
    }
}