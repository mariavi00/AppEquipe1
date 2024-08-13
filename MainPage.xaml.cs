using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ListadeCliente(object sender, EventArgs args)
        {
            Application.Current.MainPage = new ListaClientePage();
        }
        void ListadeFornecedor(object sender, EventArgs args)
        {
            Application.Current.MainPage = new ListaFornecedor();
        }
        void ControledeEstoque(object sender, EventArgs args)
        {
            Application.Current.MainPage = new EstoqueMateriaPrima();
        }
        void ControledeProducao(object sender, EventArgs args)
        {
            Application.Current.MainPage = new EtapadeProducao();
        }
    }
}

