using AppEquipe1.Modelos;
using LiteDB;

namespace AppEquipe1;

public class Pedido:Registro
{
    [BsonId]
    public int IdPedido { get; set; }

    public string Descricao { get; set; }

    public Cliente Cliente{ get; set; }

    public string EtapadeProducao { get; set; }
    public DateTime DatadeEntrada;
    public DateTime DatadeSaidaEsperada;

}

