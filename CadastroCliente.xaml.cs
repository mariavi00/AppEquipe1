using System;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class CadastroCliente : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void SalvarFoiClicado(object sender, EventArgs e)
        {
            var cliente = new Modelos.Cliente();
            cliente.Nome = NomeEntry.Text;
            cliente.CPF = CPFEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;
            
            clienteControle.CriarOuAtualizar(cliente);
            
            frameSalvar.IsVisible = true;
        }

        void BotaoOkClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new ListaClientePage();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            DisplayAlert("Cancelar", "Cadastro cancelado!", "OK");
        }
    }
}
