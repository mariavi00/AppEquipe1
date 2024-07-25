namespace Modelos;

public class Pessoa
{
    protected string Nome;
    protected string Telefone;
    protected int Id;

    public void SetNome (string n)
    {
        Nome=n;
    }
    public string GetNome()
    {
        return Nome;
    }public void SetTelefone (string t)
    {
        Telefone=t;
    }
    public string GetTelefone()
    {
        return Telefone;
    }
    public void SetId (int id)
    {
        Id=id;
    }
    public int GetId()
    {
        return Id;
    }

}