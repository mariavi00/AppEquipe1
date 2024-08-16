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

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var cliente = new Modelos.Cliente();
            cliente.Nome = NomeEntry.Text;
            cliente.CPF = CPFEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;


            // Lógica para salvar os dados
            clienteControle.CriarOuAtualizar(cliente);
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
