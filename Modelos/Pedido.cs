using LiteDB;

namespace AppEquipe1;

public class Pedido
{
    [BsonId]
    public int IdPedido { get; set; }
    public string EtapadeProducao { get; set; }
    DateTime DatadeEntrada;
    DateTime DatadeSaida;

}

