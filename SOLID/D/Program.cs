using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            IContato cliente = Factory.GetCliente();
            cliente.Nome = "Joao";
            cliente.Email = "joao@email.com";
            cliente.Celular = "99999-8888";

            IEmail email = Factory.GetEmail();
            email.EnviarEmail(cliente, "Sobre seu saldo...", "Seu saldo está baixo");

            IMensagemCelular sms = Factory.GetMensageiroCelular();
            sms.EnviarMensagem(cliente, "Seu saldo está baixo");

            Console.ReadLine();
        }
    }
}
