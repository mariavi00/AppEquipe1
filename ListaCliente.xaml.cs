using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppEquipe1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Cliente> Clientes { get; set; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public MainPage()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<Cliente>
            {
                new Cliente { Id = 1, Nome = "Cliente 1", Telefone = "12345" },
                new Cliente { Id = 2, Nome = "Cliente 2", Telefone = "67890" },
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

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            // Lógica para cadastro
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

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
