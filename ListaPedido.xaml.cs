using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class ListaPedido : ContentPage
    {
        public ObservableCollection<Lote> Items { get; set; }

        public ListaPedido()
        {
            InitializeComponent();
            Items = new ObservableCollection<Lote>
            {
                new Lote { NumeroPedido = "1", Pedido = "Pedido 1", IdCliente = "123", Data = "01/01/2024" },
                new Lote { NumeroPedido = "2", Pedido = "Pedido 2", IdCliente = "456", Data = "02/01/2024" }
            };
            BindingContext = this;
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            // Lógica para editar o item
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Lógica para deletar o item
        }
    }

    public class Lote 
    {
        public string NumeroPedido { get; set; }
        public string Pedido { get; set; }
        public string IdCliente { get; set; }
        public string Data { get; set; }
    }
}
