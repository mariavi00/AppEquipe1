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
        public void SetDatadeEntrada (string e)
        {
            DatadeEntrada=e;
        }
        public string GetDatadeEntrada()
        {
            return DatadeEntrada;
        }
        public void SetdatadeSaida (string s)
        {
            DatadeSaida=s;
        }
        public string GetDatadeSaida()
        {
            return DatadeSaida;
        }
    }
}