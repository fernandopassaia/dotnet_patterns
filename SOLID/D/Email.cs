using System;

namespace D
{
    public class Email : IEmail
    {
        public void EnviarEmail(IContato cliente, string assunto, string mensagem)
        {
            Console.WriteLine($"Email enviado para {cliente.Email}: Assunto: '{assunto}' Mensagem: '{mensagem}'");
        }
    }
}
