using AppEquipe1.Modelos;

namespace AppEquipe1.Controles;

public class PessoaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PessoaControle() : base()
  {
    NomeDaTabela = "Pessoas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idPessoa)
  {
    var collection = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idPessoa);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pessoa>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    return new List<Pessoa>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPessoa)
  {
    var collection = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    collection.Delete(idPessoa);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pessoa Pessoa)
  {
    var collection = liteDB.GetCollection<Pessoa>(NomeDaTabela);
    collection.Upsert(Pessoa);
  }

  //----------------------------------------------------------------------------
}