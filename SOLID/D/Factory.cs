
namespace D
{
    public static class Factory
    {
        public static Cliente GetCliente()
        {
            return new Cliente();
        }

        public static Email GetEmail()
        {
            return new Email();
        }

        public static SMS GetMensageiroCelular()
        {
            return new SMS();
        }
    }
}
