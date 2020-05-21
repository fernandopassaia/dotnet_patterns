

using System;

namespace D_Wrong
{
    // Regras do DIP (Dependency Inversion Principle):
    // Primeira Regra: Módulos de alto nível não devem depender de módulos de baixo nível, ambos devem depender de abstrações.
    // Segunda Regra: Abstrações não devem depender de detalhes, porém detalhes devem depender de abstrações.

    // O que são módulos de alto nível: Program é um módulo de alto nível, por que ele tem dependências de outras classes concretas
    // (nesse caso Cliente, Email e SMS) para fazer o que precisa fazer. Nossa classe de Email e SMS também são módulos de alto nível
    // por que dependem de Cliente para fazer o que precisam fazer. Minha única classe sem dependência (baixo nível) é Cliente.

    // Além disso, toda vez que eu digito "new" e crio um novo objeto, como abaixo, quer dizer que estamos adicionando uma forte
    // dependência no nosso código, deixando altamente acoplado. Essas inicializações espalhadas pelo sistema é o problema. A idéia do
    // DIP é quebrar esse tipo de dependência, tanto nos módulos de baixo nível, como nos módulos de alto nível. Para resolver isso
    // criaremos uma classe de alto nível que tem como responsabilidade gerenciar essas inicializações.
    
    // Essa classe se responsabilizará por criar essas instâncias: Um nome comumente utilizado é "Factory", por tanto, quando ver essa
    // classe, ela vem pra resolver essa questão de criar objetos necessários (injeção de dependência).

    // Nota: Dependency Inversion não tem ligação com Dependency Injection. Dependency Injection é uma das formas possíveis pra resolver
    // a questão de injeção de novas classes e fazer com que a coisa funcione (assim como fiz manualmente com a Factory no projeto OK).
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente { Nome = "Joao", Email = "joao@email.com", Celular = "99999-8888" };
            Email email = new Email();
            email.EnviarEmail(cliente, "Sobre seu saldo...", "Seu saldo está baixo");
            SMS sms = new SMS();
            sms.EnviarSMS(cliente, "Seu saldo está baixo");

            Console.ReadLine();
        }
    }
}
