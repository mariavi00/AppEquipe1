using LiteDB;

namespace AppEquipe1.Modelos;

public class Produto:Registro
{
    [BsonId]
    public int IdMateriaPrima {get; set;}
    public int IdPedido {get; set;}
    public int IdProduto {get; set;}
    
}