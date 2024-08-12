using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using AppEquipe1.Modelos;

namespace AppEquipe1
{
    public partial class EtapadeProducao : ContentPage
    {
        public ObservableCollection<Encomenda> Items { get; set; }

        public void Etapadeproducao()
        {
            InitializeComponent();
            Items = new ObservableCollection<Encomenda>
            {
                new Encomenda { IdProducao = "1", 
                             EtapaProducao = "Etapa 1", 
                             DataEntrada = "01/01/2024", 
                             DataSaida = "02/01/2024" },
                new Encomenda { IdProducao = "2", 
                             EtapaProducao = "Etapa 2", 
                             DataEntrada = "03/01/2024", 
                             DataSaida = "04/01/2024" }
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

    public class Encomenda
    {
        public string IdProducao { get; set; }
        public string EtapaProducao { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
    }
}
