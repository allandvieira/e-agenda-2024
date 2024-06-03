using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaCategoria
{
    public class ControladorDespesa : ControladorBase, IControladorFiltravel
    {
        private TabelaDespesaControl tabelaDespesa;

        private RepositorioDespesa repositorioDespesa;
        private RepositorioCategoria repositorioCategoria;

        public override string TipoCadastro { get { return "Despesas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova despesa"; } }

        public override string ToolTipEditar { get { return "Editar uma despesas existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma despesa existente"; } }

        public string ToolTipFiltrar { get { return "Filtrar Despesas"; } }

        public ControladorDespesa(RepositorioDespesa repositorioDespesa, RepositorioCategoria repositorioCategoria)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;
        }

        public override void Adicionar()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            List<Categoria> categoriasCadastradas = repositorioCategoria.SelecionarTodos();

            telaDespesa.CarregarCategorias(categoriasCadastradas);

            DialogResult resultado = telaDespesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Despesa novaDespesa = telaDespesa.Despesa;

            repositorioDespesa.Cadastrar(novaDespesa);

            CarregarDespesas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaDespesa.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            List<Categoria> categoriasCadastradas = repositorioCategoria.SelecionarTodos();

            telaDespesa.CarregarCategorias(categoriasCadastradas);

            int idSelecionado = tabelaDespesa.ObterRegistroSelecionado();

            Despesa despesaSelecionada =
                repositorioDespesa.SelecionarPorId(idSelecionado);

            if (despesaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaDespesa.Despesa = despesaSelecionada;

            DialogResult resultado = telaDespesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Despesa despesaEditada = telaDespesa.Despesa;

            repositorioDespesa.Editar(idSelecionado, despesaEditada);

            CarregarDespesas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{despesaEditada.Nome}\" foi atualizado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDespesa.ObterRegistroSelecionado();

            Despesa despesaSelecionada =
                repositorioDespesa.SelecionarPorId(idSelecionado);

            if (despesaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Tem certeza que deseja excluir a despesa: {despesaSelecionada.Nome}?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
                return;

            repositorioDespesa.Excluir(despesaSelecionada.Id);

            CarregarDespesas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{despesaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        public void Filtrar()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaFiltroDespesaForm telaFiltro = new TelaFiltroDespesaForm(categorias);

            DialogResult resultado = telaFiltro.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                List<Categoria> categoriasSelecionadas = telaFiltro.CategoriasSelecionadas;
                List<Despesa> despesasFiltradas = repositorioDespesa.FiltrarPorCategoria(categoriasSelecionadas);

                tabelaDespesa.AtualizarRegistros(despesasFiltradas);
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesas();

            return tabelaDespesa;
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesas);
        }
    }
}
