using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Despesa> despesa)
        {
            grid.Rows.Clear();

            foreach (Despesa c in despesa)
                grid.Rows.Add(
                    c.Id,
                    c.Nome,
                    c.Valor,
                    c.Data.ToShortDateString(),
                    c.Pagamento,
                    c.Categoria);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Pagamento", HeaderText = "Pagamento" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria" },
                        };
        }
    }
}