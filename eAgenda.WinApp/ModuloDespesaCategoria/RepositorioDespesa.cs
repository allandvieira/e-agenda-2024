using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        private List<Despesa> todasDespesas;

        public List<Despesa> FiltrarPorCategoria(List<Categoria> categorias)
        {
            List<Despesa> despesasFiltradas = new List<Despesa>();

            foreach (var despesa in todasDespesas)
            {
                if (categorias.Contains(despesa.Categoria))
                {
                    despesasFiltradas.Add(despesa);
                }
            }

            return despesasFiltradas;
        }
    }
}
