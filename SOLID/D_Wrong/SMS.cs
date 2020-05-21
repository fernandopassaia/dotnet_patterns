using System;

namespace D_Wrong
{
    public class SMS
    {
        public void EnviarSMS(Cliente cliente, string mensagem)
        {
            Console.WriteLine($"SMS enviado para {cliente.Celular}: Mensagem: '{mensagem}'");
        }
    }
}
