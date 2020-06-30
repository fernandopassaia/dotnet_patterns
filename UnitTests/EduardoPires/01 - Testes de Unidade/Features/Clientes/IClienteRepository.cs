using Features.Core;

namespace Features.Clientes
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorEmail(string email);
    }
}