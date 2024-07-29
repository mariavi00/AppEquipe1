namespace Modelos;

public class Materiaprima:Registro
{
    int IdFornecedor;
    int IdMateriaPrima;
    Unidade unidade;

    public void SetIdFornecedor (int IdF)
    {
        IdFornecedor=IdF;
    }
    public int GetIdFornecedor()
    {
        return IdFornecedor;
    }
    public void SetIdMateriaPrima (int IdMT)
    {
        IdMateriaPrima=IdMT;
    }
    public int GetIdMateriaPrima()
    {
        return IdMateriaPrima;
    }
    public void SetUnidade (Unidade u)
    {
        unidade=u;
    }
    public Unidade GetUnidade()
    {
        return unidade;
    }
}