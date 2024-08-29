using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class EstoqueMateriaPrima : ContentPage
    {
        public ObservableCollection<Pedidos> Items { get; set; }

        public EstoqueMateriaPrima()
        {
           
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

    public class Pedidos
    {
        public string MateriaPrima { get; set; }
        public string Fornecedor { get; set; }
        public string Quantidade { get; set; }
    }
}
