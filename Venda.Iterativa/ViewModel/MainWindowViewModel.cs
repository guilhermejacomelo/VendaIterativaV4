using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Commands;

namespace Venda.Iterativa.ViewModel
{
    internal class MainWindowViewModel : AbstractViewModel
    {
        #region variaveis privadas

        #endregion variaveis privadas

        #region propriedades

        #endregion propriedades

        #region comandos

        public ListarProdutosCommand ListarProdutos { get; private set; }
            = new ListarProdutosCommand();

        #endregion comandos

        public MainWindowViewModel() : base("UMFG | Home") { }
    }
}