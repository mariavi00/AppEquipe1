using LiteDB;

namespace AppEquipe1.Modelos;

public class Fornecedor:Pessoa
{
    [BsonId]
    public int IdMateriaPrima {get; set;}

}