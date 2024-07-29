namespace Modelos;

public class Venda:Registro
{
    int IdCliente;
    string Pedido;
    int IdPedido;
    int Quantidade;

    public void SetIdCliente (int IdC)
    {
        IdCliente=IdC;
    }
    public int GetIdCliente()
    {
        return IdCliente;
    }
    public void SetPedido (string p)
    {
        Pedido=p;
    }
    public string GetPedido()
    {
        return Pedido;
    }
    public void SetIdPedido (int IdP)
    {
        IdPedido=IdP;
    }
    public int GetIdPedido()
    {
        return IdPedido;
    }
    public void SetQuantidade (int q)
    {
        Quantidade=q;
    }
    public int GetQuantidade()
    {
        return Quantidade;
    }

}