using LiteDB;

namespace AppEquipe1.Modelos;

public class Pessoa : Registro
{
    public string Nome {get; set;}
    public string Telefone {get; set;}
    [BsonId]
    public int Id {get; set;}
    
}