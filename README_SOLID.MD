### SOLID:

**S**: Single Responsability - uma classe deve ter apenas uma responsabilidade e apenas uma razão pra mudar. Ou seja:
Uma classe de produto não deve conter métodos de cliente, e nem deve mudar por alguma razão do cliente.

Ou seja, uma classe assim está totalmente errada, por que Program.cs tem várias responsabilidades, além de ser um
Controlador (chamando os métodos em ordem), ela está calculando salário, pagamento, atualizando banco de horas:

        static void Main()
        {
            var employee = new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 };
            decimal nettoSalary = CalculateSalary(employee);
            Console.WriteLine($"Junior Salary Gross: {employee.Sallary:C2}, netto sallary: {nettoSalary:C2}");
            ProcessPayment(employee, nettoSalary);
            UpdateBankOfHours(employee);
            Console.ReadLine();
        }

        private static decimal CalculateSalary(Employee employee)
        {
            return employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
        }

        private static void ProcessPayment(Employee employee, decimal nettoSalary)
        {
            Console.WriteLine($"Transfer done: {employee.Name}|{ employee.Account}|{nettoSalary:C2}");
        }

        private static void UpdateBankOfHours(Employee employee)
        {
            Console.WriteLine($"Bank of Hours: {employee.Name} worked {employee.WorkedHoursMonth} on actual month");
        }


A solução para isso claro, é separar esse código em várias classes:

    public static class BankOfHours
    {
        public static void UpdateBankOfHours(Employee employee)
        {
            Console.WriteLine($"Bank of Hours: {employee.Name} worked {employee.WorkedHoursMonth} on actual month");
        }
    }

    public static class Calculator
    {
        public static decimal CalculateSalary(Employee employee)
        {
            return employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
        }
    }

    public static class Payment
    {
        public static void ProcessPayment(Employee employee, decimal nettoSalary)
        {
            Console.WriteLine($"Transfer done: {employee.Name}|{ employee.Account}|{nettoSalary:C2}");
        }
    }

    static void Main()
        {
            var employee = new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 };
            decimal nettoSalary = Calculator.CalculateSalary(employee);
            Console.WriteLine($"Junior Salary Gross: {employee.Sallary:C2}, netto sallary: {nettoSalary:C2}");
            Payment.ProcessPayment(employee, nettoSalary);
            BankOfHours.UpdateBankOfHours(employee);
            Console.ReadLine();
        }


**O**: Open Close Principle - Uma classe deve estar aberta pra extensão, mas fechada para modificação. Esse principio
diz que minhas classes devem ser modificadas o menos possível. Ou seja: Vamos supor que eu tenha uma classe Employee,
e dentro dela um ENUM para o Level (Junior, Pleno, Senior). Baseado no Enum (level) o funcionário ganhará um acrescimo
de salário. Se eu desenvolver assim, terei uma classe "Calculadora" que fará um "IF" e verificará o level, dando um
acrescimo. O primeiro problema é que isso quebra o "S" por que calculadora está verificando o nível. Segundo: Toda vez
que eu tiver que entrar um Level (junior, ou aprendiz por exemplo) terei que modificar e quebrar o código.

A solução para isso é criar uma interface para o Funcionário:

    public interface IEmployee
    {
        string Account { get; set; }
        ICalculator Calculator { get; set; }
        string Name { get; set; }
        decimal Sallary { get; set; }
        int WorkedHoursMonth { get; set; }
        int WorkHoursMonth { get; set; }
    }

E classes que irão implementar essa interface (note que o Calculator é de Senior nesse caso também):

    class SeniorEmployee : IEmployee
    {
        public string Account { get; set; }
        public ICalculator Calculator { get; set; } = new SeniorCalculator();
        public string Name { get; set; }
        public decimal Sallary { get; set; }
        public int WorkedHoursMonth { get; set; }
        public int WorkHoursMonth { get; set; }
    }

E então a interface de calculadora e a implementação dela pra Senior:

    public interface ICalculator
    {
        decimal CalculateSalary(IEmployee employee);
    }

    public class SeniorCalculator : ICalculator
    {
        public decimal CalculateSalary(IEmployee employee)
        {
            decimal salary = employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
            salary *= 1.2M;
            return salary;
        }
    }


Desse modo a entrada de novos níveis (como Junior) não alteraria em NADA as classes já existentes, eu apenas teria que
fazer uma classe JuniorEmployee (implementando IEmployee) e a calculadora pra JuniorCalculator.

**L**: Barbara Liskov LSP Principle: Se 'S' é um subtipo de 'T', então objetos do tipo 'T' podem ser substituídos por
objetos do tipo 'S' sem que essa substituição gere efeitos colaterais na nossa aplicação. Para essa regra usaremos o
exemplo clássico de Barbara Liskov: O Quadrado (square) e Retângulo (rectangle). Só lembrando: Um retângulo é um quadrado,
porém os lados (altura e largura) não são iguais.

Se eu tentar fazer uma herança (por exemplo quadrado herdar de retângulo) isso não daria certo, uma vez que apesar deles
serem iguais, o quadrado tem os 4 lados iguais, logo o cálculo de Area é diferente, e o quadrado não precisa saber da
altura e largura para saber se calcular, o quadrado precisa apenas do "tamanho" de 1 dos 4 lados, pois são iguais.

A solução é que você tenha uma classe abstrata que tenha um método abstrato de cálculo de Área (que será sobre-escrito)
pelas classes que herdarem dela:

    public abstract class Figura
    {
        public abstract double Area();
    }

    public class Quadrado : Figura
    {
        private double _tamanho; //veja que quadrado não contém Altura e Largura, visto que os lados são iguais        

        public void setTamanho(double tamanho)
        {
            _tamanho = tamanho;
        }

        public override double Area()
        {
            return Math.Pow(_tamanho, 2); //tamanho elevado ao quadrado
        }
    }

    public class Retangulo : Figura
    {
        private double _altura;
        private double _largura;

        public void SetAltura(double altura)
        {
            _altura = altura;
        }

        public void SetLargura(double largura)
        {
            _largura = largura;
        }

        public override double Area() //o método área sobreescreve da classe pai Figura
        {
            return _largura * _altura;
        }
    }


E dessa forma Retângulo e Quadrado são classes do tipo "Figura" e ambas podem ser substitutas uma da outra ao usar
uma List<Figura> por exemplo. Veja só (nesse caso ambas figuras imprimirão suas áreas corretamente):

            List<Figura> objetos = new List<Figura>();

            var objeto1 = new Retangulo();
            objeto1.SetAltura(4);
            objeto1.SetLargura(5);
            objetos.Add(objeto1); // adiciono um retangulo as figuras

            var objeto2 = new Quadrado();
            objeto2.setTamanho(4);
            objetos.Add(objeto2); // adiciono um quadrado as figuras

            foreach (Figura figura in objetos)
            {
                Console.WriteLine($"Area do {figura.GetType().Name} é: {figura.Area()}");
            }



**I**: Interface Segregation Principle. Diz que classes não devem ser forçadas a depender de métodos que não utilizam.
É melhor termos várias interfaces curtas do que interfaces longas. Ou seja: Se você quer uma banana, não precisa lidar
com o cacho inteiro, muito menos com o macaco. Ou seja: Devo quebrar as coisas em várias interfaces.

Se eu tiver uma classe "ImpressoraMultifuncional" com 3 métodos (Imprimir, Scanear e EnviarFax):

    public interface IImpressoraMultifuncional
    {
        void Imprimir(string conteudo);
        void Digitalizar(string conteudo);
        void EnviarFax(string conteudo);
    }

Até ai tudo bem. Agora imagine que algum dia no futuro eu tiver uma Impressora40Colunas, terei um problema, pois a
Impressora40Colunas APENAS Imprime, não envia fax, nem scaneia. Então o ideal é que eu quebre isso em várias interfaces.

    public interface IFax
    {
        void EnviarFax(string conteudo);
    }

    public interface IScanner
    {
        void Digitalizar(string conteudo);
    }

    public interface IImpressora
    {
        void Imprimir(string conteudo);
    }

E então minhas implementações pra impressoras, herdando e implementando apenas as interfaces que preciso:

    public class ImpressoraSimples : IImpressora
        {
            public void Imprimir(string conteudo)
            {
                Console.WriteLine($"Impresso: '{conteudo}'");
            }
        }
    }

    public class ImpressoraMultifuncional : IImpressora, IScanner, IFax
    {
        public void Digitalizar(string conteudo)
        {
            Console.WriteLine($"Digitalizado: '{conteudo}'");
        }

        public void EnviarFax(string conteudo)
        {
            Console.WriteLine($"Fax Enviado: '{conteudo}'");
        }

        public void Imprimir(string conteudo)
        {
            Console.WriteLine($"Impresso: '{conteudo}'");
        }

        public void ImprimirDuplex(string conteudo)
        {
            Console.WriteLine($"Impresso Frente e Verso: '{conteudo}'");
        }
    }


**D**: Dependency Inversion Principle.
Primeira Regra: Módulos de alto nível não devem depender de módulos de baixo nível, ambos devem depender de abstrações.
Segunda Regra: Abstrações não devem depender de detalhes, porém detalhes devem depender de abstrações.

Primeira Nota: Classes de alto nível são aquelas que tem dependências, como email ou SMS (que dependem de Cliente).
Classes de baixo nível são aquelas que não tem dependência nenhuma, como a entidade Cliente.

Uma classe assim:

        static void Main(string[] args)
        {
            Cliente cliente = new Cliente { Nome = "Joao", Email = "joao@email.com", Celular = "99999-8888" };
            Email email = new Email();
            email.EnviarEmail(cliente, "Sobre seu saldo...", "Seu saldo está baixo");
            SMS sms = new SMS();
            sms.EnviarSMS(cliente, "Seu saldo está baixo");

            Console.ReadLine();
        }

        public class Cliente
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Celular { get; set; }
        }

        public class Email
        {
            public void EnviarEmail(Cliente cliente, string assunto, string mensagem)
            {
                Console.WriteLine($"Email enviado para {cliente.Email}: Assunto: '{assunto}' Mensagem: '{mensagem}'");
            }
        }

        public class SMS
        {
            public void EnviarSMS(Cliente cliente, string mensagem)
            {
                Console.WriteLine($"SMS enviado para {cliente.Celular}: Mensagem: '{mensagem}'");
            }
        }

O primeiro problema dessa classe é que ela tem alto acoplamento, está criando várias instâncias. Se eu usar "new" no
meu sistema, terei vários "news" espalhados por todo o projeto, e se algo mudar terei um grande problema. Então a solução
é criar um Factory de criação de instâncias. Um Framework de "Injeção de Dependência" é também uma das maneiras de resolver.

O segundo problema é que as classes de ALTO NIVEL SMS e EMAIL estão dependentes da classe de baixo nível Cliente. Ou seja:
Elas apenas vão enviar Email e SMS se o Cliente for informado, elas estão amarradas a uma classe específica. Então para
resolver o Dependency Inversion nós precisamos que:

SMS e Email dependam de abstrações. Program precisa de um injetor de dependências pra funcionar:

    public interface IContato
    {
        string Celular { get; set; }
        string Email { get; set; }
        string Nome { get; set; }
    }

    public class Cliente : IContato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }

    public interface IEmail
    {
        void EnviarEmail(IContato cliente, string assunto, string mensagem);
    }

    public interface IMensagemCelular
    {
        void EnviarMensagem(IContato cliente, string mensagem);
    }

    public class Email : IEmail
    {
        public void EnviarEmail(IContato cliente, string assunto, string mensagem)
        {
            Console.WriteLine($"Email enviado para {cliente.Email}: Assunto: '{assunto}' Mensagem: '{mensagem}'");
        }
    }

    public class SMS : IMensagemCelular
    {
        public void EnviarMensagem(IContato cliente, string mensagem)
        {
            Console.WriteLine($"SMS enviado para {cliente.Celular}: Mensagem: '{mensagem}'");
        }
    }

Dessa forma, a classe de Email e Celular não dependem mais de Cliente, mas de IContato. Qualquer classe que implementar
IContato (seja classe Empresa, etc) irá conseguir enviar email e sms. Para resolver a injeção de dependência:

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