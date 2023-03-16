using System;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.UserControls;

namespace Venda.Iterativa.Commands
{
    internal sealed class ReceberPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            try
            {
                ucReceber.Exibir(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}