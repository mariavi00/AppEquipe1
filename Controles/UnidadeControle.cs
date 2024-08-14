using AppEquipe1.Modelos;

namespace AppEquipe1.Controles;

public class UnidadeControle : BaseControle
{
  //----------------------------------------------------------------------------

  public UnidadeControle() : base()
  {
    NomeDaTabela = "Unidades";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idUnidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return collection.FindOne(d => d.IdUnidade == idUnidade);
  }

  //----------------------------------------------------------------------------

  public virtual List<Unidade>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return new List<Unidade>(tabela.FindAll().OrderBy(d => d.NomeUnidade));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idUnidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Delete(idUnidade);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Unidade Unidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Upsert(Unidade);
  }

  //----------------------------------------------------------------------------
}