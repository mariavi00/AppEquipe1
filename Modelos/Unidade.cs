using LiteDB;

namespace AppEquipe1.Modelos;

public class Unidade:Registro
{
    [BsonId]
    public int IdUnidade {get; set;}
    public string NomeUnidade {get; set;}

}