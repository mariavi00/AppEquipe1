namespace Modelos;

public class Etapadeproducao
{
    protected string Endereço;
    protected string Telefone;
    protected int Idproduçao;
    protected string TempodeProduçao;

    public void SetEndereço (string e)
    {
        Endereço=e;
    }
    public string GetEndereço()
    {
        return Endereço;
    }
    public void SetTelefone (string t)
    {
        Telefone=t;
    }
    public string GetTelefone()
    {
        return Telefone;
    }
    public void SetIdproduçao (int Idp)
    {
        Idproduçao=Idp;
    }
    public int GetIdproduçao()
    {
        return Idproduçao;
    }
    public void SetTempo (string tempo)
    {
        TempodeProduçao=tempo;
    }
    public string GetTempo()
    {
        return TempodeProduçao;
    }
}