namespace Modelos;

public class Produto:Registro
{
    int IdMateriaPrima;
    int IdPedido;
    int IdProduto;
    public void SetIdMateriaPrima (int IdMP)
    {
        IdMateriaPrima=IdMP;
    }
    public int GetIdMateriaPrima()
    {
        return IdMateriaPrima;
    }
    public void SetIdPedido (int IdP)
    {
        IdPedido=IdP;
    }
    public int GetIdPedido()
    {
        return IdPedido;
    }
    public void SetIdProduto (int Id)
    {
        IdProduto=Id;
    }
    public int GetIdProduto()
    {
        return IdProduto;
    }
}