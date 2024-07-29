using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<Item>
            {
                new Item { NumeroPedido = "1", Pedido = "Pedido 1", IdCliente = "123", Data = "01/01/2024" },
                new Item { NumeroPedido = "2", Pedido = "Pedido 2", IdCliente = "456", Data = "02/01/2024" }
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

    public class Item
    {
        public string NumeroPedido { get; set; }
        public string Pedido { get; set; }
        public string IdCliente { get; set; }
        public string Data { get; set; }
    }
}
