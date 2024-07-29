using System;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class ConfirmacaoPage : ContentPage
    {
        public ConfirmacaoPage()
        {
            InitializeComponent();
        }

        private void OnSimClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar a ação
            DisplayAlert("Confirmação", "Ação confirmada!", "OK");
        }

        private void OnNaoClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a ação
            DisplayAlert("Confirmação", "Ação cancelada!", "OK");
        }
    }
}
