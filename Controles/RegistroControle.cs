using AppEquipe1.Modelos;

namespace AppEquipe1.Controles;

public class RegistroControle : BaseControle
{
  //----------------------------------------------------------------------------

  public RegistroControle() : base()
  {
    NomeDaTabela = "Registros";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idRegistro)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idRegistro);
  }

  //----------------------------------------------------------------------------

  public virtual List<Registro>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Registro>(NomeDaTabela);
    return new List<Registro>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idRegistro)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    collection.Delete(idRegistro);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Registro Registro)
  {
    var collection = liteDB.GetCollection<Registro>(NomeDaTabela);
    collection.Upsert(Registro);
  }

  //----------------------------------------------------------------------------
}