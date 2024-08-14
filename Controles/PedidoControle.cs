using AppEquipe1.Modelos;

namespace AppEquipe1.Controles;

public class PedidoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PedidoControle() : base()
  {
    NomeDaTabela = "Pedidos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return collection.FindOne(d => d.IdPedido == idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pedido>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return new List<Pedido>(tabela.FindAll().OrderBy(d => d.DatadeEntrada));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Delete(idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pedido Pedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Upsert(Pedido);
  }

  //----------------------------------------------------------------------------
}