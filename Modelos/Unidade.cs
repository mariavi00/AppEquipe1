using LiteDB;

namespace AppEquipe1.Modelos;

public class Unidade
{
    [BsonId]
    public int IdUnidade {get; set;}
    public string NomeUnidade {get; set;}

}