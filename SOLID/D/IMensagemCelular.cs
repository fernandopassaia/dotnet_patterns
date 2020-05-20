namespace D
{
    public interface IMensagemCelular
    {
        void EnviarMensagem(IContato cliente, string mensagem);
    }
}