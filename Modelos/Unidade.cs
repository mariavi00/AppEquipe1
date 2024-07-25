namespace Modelos;

public class Unidade
{
    int IdUnidade;
    string NomeUnidade;

    public void SetIdUnidade (int IdU)
    {
        IdUnidade=IdU;
    }
    public int GetIdUnidade()
    {
        return IdUnidade;
    }
    public void SetNomeUnidade (string NU)
    {
        NomeUnidade=NU;
    }
    public string GetNomeUnidade()
    {
        return NomeUnidade;
    }
}