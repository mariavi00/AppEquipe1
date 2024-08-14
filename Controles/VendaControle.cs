using AppEquipe1.Modelos;

namespace AppEquipe1.Controles;

public class VendaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public VendaControle() : base()
  {
    NomeDaTabela = "Vendas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idVenda)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    return collection.FindOne(d => d.IdVenda == idVenda);
  }

  //----------------------------------------------------------------------------

  public virtual List<Venda>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Venda>(NomeDaTabela);
    return new List<Venda>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idVenda)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    collection.Delete(idVenda);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Venda Venda)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    collection.Upsert(Venda);
  }

  //----------------------------------------------------------------------------
}