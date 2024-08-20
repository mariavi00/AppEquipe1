using System;
using AppEquipe1.Controles;
using Microsoft.Maui.Controls;

namespace AppEquipe1
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string telefone = TelefoneEntry.Text;
            string materiaPrima = MateriaPrimaEntry.Text;
            
            DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        
            if (Application.Current != null)
            Application.Current.MainPage = new ListaFornecedorPage();
            }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            MateriaPrimaEntry.Text = string.Empty;
            DisplayAlert("Cancelar", "Cadastro cancelado!", "OK");
        }
    }
}
