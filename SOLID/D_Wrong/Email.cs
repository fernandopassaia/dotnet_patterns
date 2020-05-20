using System;

namespace D_Wrong
{
    public class Email
    {
        public void EnviarEmail(Cliente cliente, string assunto, string mensagem)
        {
            Console.WriteLine($"Email enviado para {cliente.Email}: Assunto: '{assunto}' Mensagem: '{mensagem}'");
        }
    }
}
