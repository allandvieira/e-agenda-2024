using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private RepositorioCategoria repositorioCategoria;
        private TabelaCategoriaControl tabelaCategoria;

        public ControladorCategoria(RepositorioCategoria repositorio)
        {
            repositorioCategoria = repositorio;
        }

        private ListagemCategoriaControl listagemCategoria;
        public override string TipoCadastro { get { return "Categorias"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova categoria"; } }

        public override string ToolTipEditar { get { return "Editar uma categoria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma categoria existente"; } }

        public override void Adicionar()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult resultado = telaCategoria.ShowDialog();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (listagemCategoria == null)
                listagemCategoria = new ListagemCategoriaControl();

            return listagemCategoria;
        }
    }
}
