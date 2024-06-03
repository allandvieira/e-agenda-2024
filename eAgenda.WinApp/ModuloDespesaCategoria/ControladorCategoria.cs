using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private RepositorioCategoria repositorioCategoria;
        private TabelaCategoriaControl tabelaCategoria;

        public ControladorCategoria(RepositorioCategoria repositorio)
        {
            repositorioCategoria = repositorio;
        }

        public override string TipoCadastro { get { return "Categorias"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova categoria"; } }

        public override string ToolTipEditar { get { return "Editar uma categoria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma categoria existente"; } }

        public override void Adicionar()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Categoria novaCategoria = telaCategoria.Categoria;

            repositorioCategoria.Cadastrar(novaCategoria);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaCategoria.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            int idSelecionado = tabelaCategoria.ObterRegistroSelecionado();

            Categoria categoriaSelecionada =
                repositorioCategoria.SelecionarPorId(idSelecionado);

            if (categoriaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            telaCategoria.Categoria = categoriaSelecionada;

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Categoria categoriaAtualizada = telaCategoria.Categoria;

            repositorioCategoria.Editar(idSelecionado, categoriaAtualizada);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{categoriaAtualizada.Titulo}\" foi atualizado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCategoria.ObterRegistroSelecionado();

            Categoria categoriaSelecionada =
                repositorioCategoria.SelecionarPorId(idSelecionado);

            if (categoriaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Tem certeza que deseja excluir a categoria \"{categoriaSelecionada.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta == DialogResult.No)
                return;

            repositorioCategoria.Excluir(categoriaSelecionada.Id);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{categoriaSelecionada.Titulo}\" foi removido com sucesso!");
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categorias);
        }

        public override UserControl ObterListagem()
        {
            if  (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();
            
            CarregarCategorias();
            return tabelaCategoria;
        }
    }
}
