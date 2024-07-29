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
                new Item { MateriaPrima = "Exemplo 1", Fornecedor = "Fornecedor 1", Quantidade = "10" },
                new Item { MateriaPrima = "Exemplo 2", Fornecedor = "Fornecedor 2", Quantidade = "20" }
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
        public string MateriaPrima { get; set; }
        public string Fornecedor { get; set; }
        public string Quantidade { get; set; }
    }
}
