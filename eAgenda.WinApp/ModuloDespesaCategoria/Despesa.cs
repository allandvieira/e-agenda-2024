using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public class Despesa : EntidadeBase
    {
        public string Nome { get; set; }
        public int Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
        public string Pagamento { get; set; }

        public Despesa(
            string nome,
            string valor,
            DateTime data,
            Categoria categoria,
            string pagamento
        )
        {
            Nome = nome;
            Valor = int.TryParse(valor, out int valorInt) ? valorInt : 0;
            Data = data;
            Categoria = categoria;
            Pagamento = pagamento;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (Valor == 0)
                erros.Add("O campo \"valor\" é obrigatório e deve ser um número inteiro");

            if (string.IsNullOrEmpty(Pagamento))
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
            Pagamento = atualizado.Pagamento;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}