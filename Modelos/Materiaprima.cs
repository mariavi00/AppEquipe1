using LiteDB;

namespace AppEquipe1.Modelos;

public class Materiaprima:Registro
{
    [BsonId]
    public int IdMateriaPrima { get; set; }
    public string MateriaPrima { get; set; }
    public int Quantidade {get; set;}
    public Unidade unidade {get; set;}

}