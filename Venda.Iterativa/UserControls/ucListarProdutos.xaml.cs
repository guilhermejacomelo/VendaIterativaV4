using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.UserControls
{
    public partial class ucListarProdutos : UserControl
    {
        private ucListarProdutos()
        {
            InitializeComponent();
            DataContext = new ListarProdutosViewModel(this);
        }

        internal static void Exibir()
        {
            new Window() 
            {
                Content = new ucListarProdutos(),
                Height = 2000,
                Width = 2000,
            }
            .ShowDialog();
        }
    }
}