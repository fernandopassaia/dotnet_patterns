using NerdStore.BDD.Tests.Config;

namespace NerdStore.BDD.Tests.Usuario
{
    public class CadastroDeUsuarioTela : BaseUsuarioTela
    {
        public CadastroDeUsuarioTela(SeleniumHelper helper) : base(helper)
        {
        }

        public void ClicarNoLinkRegistrar()
        {
            Helper.ClicarLinkPorTexto("Register");
        }

        public void PreencherFormularioRegistro(Usuario usuario)
        {
            Helper.PreencherTextBoxPorId("Input_Email", usuario.Email);
            Helper.PreencherTextBoxPorId("Input_Password", usuario.Senha);
            Helper.PreencherTextBoxPorId("Input_ConfirmPassword", usuario.Senha);
        }

        public bool ValidarPreenchimentoFormularioRegistro(Usuario usuario)
        {
            if (Helper.ObterValorTextBoxPorId("Input_Email") != usuario.Email) return false;
            if (Helper.ObterValorTextBoxPorId("Input_Password") != usuario.Senha) return false;
            if (Helper.ObterValorTextBoxPorId("Input_ConfirmPassword") != usuario.Senha) return false;

            return true;
        }

        public void ClicarNoBotaoRegistrar()
        {
            var botao = Helper.ObterElementoPorXPath("/html/body/div/main/div/div/form/button");
            botao.Click();
        }
    }
}