using LiteDB;

namespace AppEquipe1.Modelos;

public class FornecedorMateriaPrima:Registro
{
    public Fornecedor Fornecedor { get; set; }
    public Materiaprima Materiaprima{ get; set; }
}
