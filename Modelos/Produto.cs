using LiteDB;

namespace AppEquipe1.Modelos;

public class Produto:Registro
{
    public int Materiaprima Materiaprima {get; set;}
    public Pedido Pedido {get; set;}
    [BsonId]
    public int IdProduto {get; set;}
    
}