using System;
using AppEquipe1.Controles;
using AppEquipe1.Modelos;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void SalvarFoiClicado(object sender, EventArgs e)
        {
            var fornecedor = new Modelos.Fornecedor();
            fornecedor.Nome = NomeEntry.Text;
            fornecedor.Telefone = TelefoneEntry.Text;
            fornecedor.Materiarima = MateriaPrimaEntry.Text;
            
             FornecedorControle.CriarOuAtualizar(fornecedor);
            
            frameSalvar.IsVisible = true;
            }

        private void CancelarClicado(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            MateriaPrimaEntry.Text = string.Empty;
            DisplayAlert("Cancelar", "Cadastro cancelado!", "OK");
        }

        void BotaoOkClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
        }
    }
}
