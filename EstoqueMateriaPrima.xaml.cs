using System.Collections.ObjectModel;
using AppEquipe1.Controles;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class EstoqueMateriaPrima : ContentPage
    {
        Controles.MateriaprimaControle materiaPrimaControle = new Controles.MateriaprimaControle();
        public EstoqueMateriaPrima()
        {
           InitializeComponent();

            Lista.ItemsSource = materiaPrimaControle.LerTodos();
        }

        private void VoltarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void CadastroClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroMateriaPrima();        
        }
    }

    
}
