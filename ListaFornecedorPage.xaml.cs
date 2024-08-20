using AppEquipe1.Modelos;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppEquipe1
{
    public partial class ListaFornecedorPage : ContentPage
    {
        public ObservableCollection<Fornecedor> Fornecedores { get; set; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListaFornecedorPage()
        {
            InitializeComponent();
           
        }

        private void VoltarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Lógica para busca
        }

        private void CadastrarClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroFornecedor();
        }

        private void OnEdit(Fornecedor fornecedor)
        {
            // Lógica para edição
        }

        private void OnDelete(Fornecedor fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }
    }


}
