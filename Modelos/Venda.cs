using LiteDB;

namespace AppEquipe1.Modelos;

public class Venda:Registro
{
    [BsonId]
    public int IdCliente {get; set;}
    public string Pedido {get; set;}
    [BsonId]
    public int IdPedido {get; set;}
    public int Quantidade {get; set;}
   
}