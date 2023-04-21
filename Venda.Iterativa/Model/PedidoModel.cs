using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;

namespace Venda.Iterativa.Model
{
    internal sealed class PedidoModel : AbstractModel
    {
        private ObservableCollection<ProdutoModel> _produtos
            = new ObservableCollection<ProdutoModel>();
        private decimal _total = 0.00m;
        private long _CartaoDeCredito;
        private DateTime _DataValidade;
        private int _CCV;

        public ObservableCollection<ProdutoModel> Produtos 
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public decimal Total
        {
            get => _total;
            set=> SetField(ref _total, value);
        }
        public long CartaoDeCredito
        {
            get => _CartaoDeCredito;
            set => SetField(ref _CartaoDeCredito, value);
        }        
        public DateTime DataValidade
        {
            get => _DataValidade;
            set => SetField(ref _DataValidade, value);
        }       
        public int CCV
        {
            get => _CCV;
            set => SetField(ref _CCV, value);
        }
    }
}