using System;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        Controles.MateriaprimaControle materiaPrimaControle = new Controles.MateriaprimaControle();
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        private async void SalvarClicado(object sender, EventArgs e)
        {
            var materiaPrima = new Modelos.Materiaprima();
            materiaPrima.Quantidade = int.Parse(QuantidadeEntry.Text);
            
            materiaPrimaControle.CriarOuAtualizar(materiaPrima);

            await DisplayAlert("Salvo!", "Dados salvos com sucesso.", "Ok!");
            Application.Current.MainPage = new EstoqueMateriaPrima(); 
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            if(await DisplayAlert("Cancelar", "Tem certeza que deseja cancelar?", "Sim", "Não"))
                Application.Current.MainPage = new EstoqueMateriaPrima();
        }
    }
}
