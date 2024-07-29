using System;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class PedidoPage : ContentPage
    {
        public PedidoPage()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            string cliente = ClienteEntry.Text;
            string pedido = PedidoEditor.Text;
            string quantidade = QuantidadeEntry.Text;
            
            // Lógica para salvar os dados
            DisplayAlert("Salvar", $"Cliente: {cliente}\nPedido: {pedido}\nQuantidade: {quantidade}", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a ação
            ClienteEntry.Text = string.Empty;
            PedidoEditor.Text = string.Empty;
            QuantidadeEntry.Text = string.Empty;
        }
    }
}
