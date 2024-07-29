using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppEquipe1
{
    public partial class FornecedorPage : ContentPage
    {
        public ObservableCollection<Fornecedor> Fornecedores { get; set; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public FornecedorPage()
        {
            InitializeComponent();
            Fornecedores = new ObservableCollection<Fornecedor>
            {
                new Fornecedor { Id = 1, Nome = "Fornecedor 1", Telefone = "12345" },
                new Fornecedor { Id = 2, Nome = "Fornecedor 2", Telefone = "67890" },
                // Adicione mais fornecedores conforme necessário
            };

            EditCommand = new Command<Fornecedor>(OnEdit);
            DeleteCommand = new Command<Fornecedor>(OnDelete);

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

        private void OnEdit(Fornecedor fornecedor)
        {
            // Lógica para edição
        }

        private void OnDelete(Fornecedor fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }
    }

    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
