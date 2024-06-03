using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public class Categoria : EntidadeBase
    {
        public string Titulo { get; set; }

        public Categoria(string titulo)
        {
            Titulo = titulo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"titulo\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Categoria atualizado = (Categoria)novoRegistro;

            Titulo = atualizado.Titulo;
        }

        public override string ToString()
        {
            return Titulo.ToTitleCase();
        }
    }
}
