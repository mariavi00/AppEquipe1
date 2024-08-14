using LiteDB;

namespace AppEquipe1.Modelos;

public class Venda:Registro
{
    [BsonId]
    public int IdVenda {get; set;}
    public Pedido Pedido {get; set;}
    public Cliente Cliente {get; set;}
    public int Quantidade {get; set;}

   
}