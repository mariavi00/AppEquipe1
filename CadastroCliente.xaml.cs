using System;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            // Lógica para salvar os dados
            DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            DisplayAlert("Cancelar", "Cadastro cancelado!", "OK");
        }
    }
}
