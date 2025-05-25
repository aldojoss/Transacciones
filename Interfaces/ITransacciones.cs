namespace Transacciones_en_.net.Interfaces
{
    public interface ITransacciones
    {
        void Transferir(decimal monto, string cuentaOrigen, string cuentaDestino);
    }
}
