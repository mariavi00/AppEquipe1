using AppEquipe1.Modelos;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppEquipe1
{
    public partial class ListaClientePage : ContentPage
    {
        public ObservableCollection<Cliente> Clientes { get; set; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListaClientePage()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<Cliente>
            {
                new Cliente {   Id = 1, 
                                Nome = "Cliente 1", 
                                Telefone = "12345" },

                new Cliente {   Id = 2, 
                                Nome = "Cliente 2", 
                                Telefone = "67890" },
                // Adicione mais clientes conforme necessário
            };

            EditCommand = new Command<Cliente>(OnEdit);
            DeleteCommand = new Command<Cliente>(OnDelete);

            BindingContext = this;
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
            Clientes.Remove(cliente);
        }
    }

}
