using LiteDB;

namespace AppEquipe1.Modelos;

public class Materiaprima:Registro
{
   
    [BsonId]
    public int IdMateriaPrima {get; set;}
    public Unidade unidade {get; set;}

}