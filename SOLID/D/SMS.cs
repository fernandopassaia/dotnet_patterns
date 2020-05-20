using System;

namespace D
{
    public class SMS : IMensagemCelular
    {
        public void EnviarMensagem(IContato cliente, string mensagem)
        {
            Console.WriteLine($"SMS enviado para {cliente.Celular}: Mensagem: '{mensagem}'");
        }
    }
}
