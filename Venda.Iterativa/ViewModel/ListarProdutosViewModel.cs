using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Model;

namespace Venda.Iterativa.ViewModel
{
    internal sealed class ListarProdutosViewModel : AbstractViewModel
    {
        #region variaveis privadas

        private ObservableCollection<ProdutoModel> _produtos 
            =  new ObservableCollection<ProdutoModel>();

        #endregion variaveis privadas

        #region propriedades

        public ObservableCollection<ProdutoModel> Produtos 
        { 
            get => _produtos; 
            set => SetField(ref _produtos, value);
        }

        #endregion propriedades

        #region construtores

        public ListarProdutosViewModel() : base("Lista de Produtos") 
        {
            CarregarProdutos();
        }

        #endregion construtores

        #region metodos

        private void CarregarProdutos()
        {
            Produtos.Clear();

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\batata.png", UriKind.Relative)),
                Referencia = "Batata",
                Descricao = "",
                Estoque = 100.00m,
                Preco = 8.90m,
            });
            
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\batata.png", UriKind.Relative)),
                Referencia = "Combo",
                Descricao = "",
                Estoque = 100.00m,
                Preco = 38.90m,
            });
            
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\batata.png", UriKind.Relative)),
                Referencia = "Lanche",
                Descricao = "",
                Estoque = 100.00m,
                Preco = 19.90m,
            });
            
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\batata.png", UriKind.Relative)),
                Referencia = "Refrigerante",
                Descricao = "",
                Estoque = 100.00m,
                Preco = 4.50m,
            });
        }

        #endregion metodos
    }
}