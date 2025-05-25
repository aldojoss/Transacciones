namespace Transacciones_en_.net.Interfaces
{
    public interface ICuenta
    {
        void AgregarCuenta(string numeroCuenta, decimal saldo, int clienteId);
    }
}
