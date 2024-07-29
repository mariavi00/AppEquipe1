namespace Modelos;

public class Fornecedor:Pessoa
{
    int IdMateriaPrima;

    public void SetIdMateriaPrima (int Idmt)
    {
        IdMateriaPrima=Idmt;
    }
    public int GetIdMateriaPrima ()
    {
        return IdMateriaPrima;
    }
}