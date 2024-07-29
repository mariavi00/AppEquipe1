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

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string unidade = UnidadePicker.SelectedItem?.ToString();
            
            // Lógica para salvar os dados
            DisplayAlert("Salvar", $"Nome: {nome}\nUnidade: {unidade}", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a ação
            NomeEntry.Text = string.Empty;
            UnidadePicker.SelectedItem = null;
        }
    }
}
