using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal class FinalizarPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ReceberViewModel;
            if (vm.Pedido.CartaoDeCredito.ToString().Length != 16)
            {
                MessageBox.Show("O numero do cartão está incorreto");
                return;
            } 
            if (vm.Pedido.DataValidade < DateTime.Today)
            {
                MessageBox.Show("Cartão está vencido");
                return;
            } 
            if (vm.Pedido.CCV.ToString().Length != 3) {
                MessageBox.Show("CCV está incorreto!");
                return;
            } 
                MessageBox.Show("Pedido finalizado");         
        }
    }
}
