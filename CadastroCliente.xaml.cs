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

        void CancelarClicado(object sender, EventArgs args)
        {
            frameCancelar.IsVisible = true;
        }

        void NaoCancelarClicado(object sender, EventArgs args)
        {
            frameCancelar.IsVisible = false;
        }

        void SimCancelarClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new ListaClientePage();
        }

    }
}
