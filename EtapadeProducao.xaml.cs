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
                new Item { IdProducao = "1", EtapaProducao = "Etapa 1", DataEntrada = "01/01/2024", DataSaida = "02/01/2024" },
                new Item { IdProducao = "2", EtapaProducao = "Etapa 2", DataEntrada = "03/01/2024", DataSaida = "04/01/2024" }
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
        public string IdProducao { get; set; }
        public string EtapaProducao { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
    }
}
