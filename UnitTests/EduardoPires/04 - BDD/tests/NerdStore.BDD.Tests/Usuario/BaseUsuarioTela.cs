using NerdStore.BDD.Tests.Config;

namespace NerdStore.BDD.Tests.Usuario
{
    public abstract class BaseUsuarioTela : PageObjectModel
    {
        protected BaseUsuarioTela(SeleniumHelper helper) : base(helper) { }

        public void AcessarSiteLoja()
        {
            Helper.IrParaUrl(Helper.Configuration.DomainUrl);
        }

        public bool ValidarSaudacaoUsuarioLogado(Usuario usuario)
        {
            return Helper.ObterTextoElementoPorId("saudacaoUsuario").Contains(usuario.Email);
        }

        public bool ValidarMensagemDeErroFormulario(string mensagem)
        {
            return Helper.ObterTextoElementoPorClasseCss("text-danger")
                .Contains(mensagem);
        }
    }
}