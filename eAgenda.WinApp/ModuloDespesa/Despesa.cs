using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class Despesa : EntidadeBase
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
        public ComboBox Pagamento { get; internal set; }

        public Despesa(
            string nome,
            string valor,
            DateTime data,
            Categoria categoria
        )
        {
            Nome = nome;
            Valor = valor;
            Data = data;
            Categoria = categoria;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Valor.Trim()))
                erros.Add("O campo \"valor\" é obrigatório");

            if (Pagamento == null)
                erros.Add("O campo \"pagamento\" é obrigatório");

            if (Categoria == null)
                erros.Add("O campo \"categoria\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Despesa atualizado = (Despesa)novoRegistro;

            Nome = atualizado.Nome;
            Valor = atualizado.Valor;
            Data = atualizado.Data;
            Categoria = atualizado.Categoria;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}

