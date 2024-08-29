using System;
using AppEquipe1.Controles;
using AppEquipe1.Modelos;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class CadastroFornecedor : ContentPage
    {
        Controles.FornecedorControle fornecedorControle = new Controles.FornecedorControle();
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void SalvarFoiClicado(object sender, EventArgs e)
        {
            var fornecedor = new Modelos.Fornecedor();
            fornecedor.Nome = NomeEntry.Text;
            fornecedor.Telefone = TelefoneEntry.Text;

            
            fornecedorControle.CriarOuAtualizar(fornecedor);
            
            frameSalvar.IsVisible = true;
            }

        void BotaoOkClicado(object sender, EventArgs args)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
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
            Application.Current.MainPage = new ListaFornecedorPage();
        }

    }
}
