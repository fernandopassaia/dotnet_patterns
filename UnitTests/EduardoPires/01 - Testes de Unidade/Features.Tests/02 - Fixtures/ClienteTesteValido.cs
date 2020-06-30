using Xunit;

namespace Features.Tests
{
    //todas as classes de teste que receberão a FIXTURE injeta precisam fazer parte da mesma collection
    [Collection(nameof(ClienteCollection))]
    public class ClienteTesteValido
    {
        // a Fixture resolve meu problema de ARRANGE, de toda vez precisar declarar um cliente,
        // seja no arrange, seja no construtor da classe. Aqui eu tenho uma classe de apoio que
        // irám me devolver um cliente, tanto válido quanto inválido. Isso me resolve muita coisa =)
        private readonly ClienteTestsFixture _clienteTestsFixture;

        public ClienteTesteValido(ClienteTestsFixture clienteTestsFixture)
        {
            _clienteTestsFixture = clienteTestsFixture;
        }
        

        [Fact(DisplayName = "Novo Cliente Válido")]
        [Trait("Categoria", "Cliente Fixture Testes")]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            // Arrange
            var cliente = _clienteTestsFixture.GerarClienteValido();

            // Act
            var result = cliente.EhValido();

            // Assert 
            Assert.True(result);
            Assert.Equal(0, cliente.ValidationResult.Errors.Count);
        }
    }
}