using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        public override string TipoCadastro { get { return "Despesas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova despesa"; } }

        public override string ToolTipEditar { get { return "Editar uma despesas existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma despesa existente"; } }

        public override void Adicionar()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
