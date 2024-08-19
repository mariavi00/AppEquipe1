using AppEquipe1.Controles;
using AppEquipe1.Modelos;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppEquipe1
{
    public partial class ListaClientePage : ContentPage
    {
        ClienteControle clienteControle=new ClienteControle();
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListaClientePage()
        {
            InitializeComponent();
            

            EditCommand = new Command<Cliente>(OnEdit);
            DeleteCommand = new Command<Cliente>(OnDelete);

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista.ItemsSource=clienteControle.LerTodos();
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Lógica para busca
        }

        private void CadastroClicado(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroCliente();        
        }

        private void OnEdit(Cliente cliente)
        {
            // Lógica para edição
        }

        private void OnDelete(Cliente cliente)
        {
       
        }
    }

}
