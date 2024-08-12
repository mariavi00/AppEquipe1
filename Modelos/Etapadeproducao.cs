using LiteDB;

namespace AppEquipe1.Modelos;

public class Etapadeproducao
{
    public string Endereço {get; set;}
    public string Telefone {get; set;}
    [BsonId]
    public int Idproduçao {get; set;}
    public string TempodeProduçao {get; set;}

}