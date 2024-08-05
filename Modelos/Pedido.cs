namespace AppEquipe1

{
    public class Pedido
    {
        int IdPedido;
        string EtapadeProducao;
        DateTime DatadeEntrada;
        DateTime DatadeSaida;

        public void SetIdPedido (int IdPd)
        {
            IdPedido=IdPd;
        }
        public int GetIdPedido()
        {
            return IdPedido;
        }
        public void SetEtapadeProducao (string ep)
        {
            EtapadeProducao=ep;
        }
        public string GetEtapadeProducao()
        {
            return EtapadeProducao;
        }
        public void SetDatadeEntrada (DateTime e)
        {
            DatadeEntrada=e;
        }
        public DateTime GetDatadeEntrada()
        {
            return DatadeEntrada;
        }
        public void SetdatadeSaida (DateTime s)
        {
            DatadeSaida=s;
        }
        public DateTime GetDatadeSaida()
        {
            return DatadeSaida;
        }
    }
}