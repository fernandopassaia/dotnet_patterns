namespace D
{
    public interface IEmail
    {
        void EnviarEmail(IContato cliente, string assunto, string mensagem);
    }
}