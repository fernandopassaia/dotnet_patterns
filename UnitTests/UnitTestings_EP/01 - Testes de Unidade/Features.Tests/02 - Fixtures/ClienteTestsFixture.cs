 using System;
using Features.Clientes;
using Xunit;

namespace Features.Tests
{
    // Nota: Eu estou implementando essa classe "ClienteCollection" e a interface "ICollectionFixture" (do xUnit)
    // para que o Framework cuide das instâncias e GC dessas classes corretamente. Poderia funcionar se eu não
    // fizesse isso, porém, todavia, essa é uma maneira mais correta de implementar.
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture>
    {}

    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Eduardo",
                "Pires",
                DateTime.Now.AddYears(-30),
                "edu@edu.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public Cliente GerarClienteInValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "edu2edu.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public void Dispose()
        {
        }
    }
}