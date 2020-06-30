using System;
using NerdStore.BDD.Tests.Config;

namespace NerdStore.BDD.Tests.Pedido
{
    public class PedidoTela : PageObjectModel
    {
        public PedidoTela(SeleniumHelper helper) : base(helper) { }

        public void AcessarVitrineDeProdutos()
        {
            Helper.IrParaUrl(Helper.Configuration.VitrineUrl);
        }

        public void ObterDetalhesDoProduto(int posicao = 1)
        {
            Helper.ClicarPorXPath($"html/body/div/main/div/div/div[{posicao}]/span/a");
        }

        public bool ValidarProdutoDisponivel()
        {
            return Helper.ValidarConteudoUrl(Helper.Configuration.ProdutoUrl);
        }

        public int ObterQuantidadeNoEstoque()
        {
            var elemento = Helper.ObterElementoPorXPath("/html/body/div/main/div/div/div[2]/p[1]");
            var quantidade = elemento.Text.ApenasNumeros();

            if (char.IsNumber(quantidade.ToString(), 0)) return quantidade;

            return 0;
        }

        public void ClicarEmComprarAgora()
        {
            Helper.ClicarPorXPath("/html/body/div/main/div/div/div[2]/form/div[2]/button");
        }

        public bool ValidarSeEstaNoCarrinhoDeCompras()
        {
            return Helper.ValidarConteudoUrl(Helper.Configuration.CarrinhoUrl);
        }

        public decimal ObterValorUnitarioProdutoCarrinho()
        {
            return Convert.ToDecimal(Helper.ObterTextoElementoPorId("valorUnitario")
                .Replace("$", string.Empty).Replace(",", string.Empty).Trim());
        }

        public decimal ObterValorTotalCarrinho()
        {
            return Convert.ToDecimal(Helper.ObterTextoElementoPorId("valorTotalCarrinho")
                .Replace("$", string.Empty).Replace(",", string.Empty).Trim());
        }

        public void ClicarAdicionarQuantidadeItens(int quantidade)
        {
            var botaoAdicionar = Helper.ObterElementoPorClasse("btn-plus");
            if (botaoAdicionar == null) return;

            for (var i = 1; i < quantidade; i++)
            {
                botaoAdicionar.Click();
            }
        }

        public string ObterMensagemDeErroProduto()
        {
            return Helper.ObterTextoElementoPorClasseCss("alert-danger");
        }

        public void NavegarParaCarrinhoDeCompras()
        {
            Helper.ObterElementoPorXPath("/html/body/header/nav/div/div/ul/li[3]/a").Click();
        }
        public string ObterIdPrimeiroProdutoCarrinho()
        {
            return Helper.ObterElementoPorXPath("/html/body/div/main/div/div/div/table/tbody/tr[1]/td[1]/div/div/h4/a")
                .GetAttribute("href");
        }

        public void GarantirQueOPrimeiroItemDaVitrineEstejaAdicionado()
        {
            NavegarParaCarrinhoDeCompras();
            if (ObterValorTotalCarrinho() > 0) return;

            AcessarVitrineDeProdutos();
            ObterDetalhesDoProduto();
            ClicarEmComprarAgora();
        }

        public int ObterQuantidadeDeItensPrimeiroProdutoCarrinho()
        {
            return Convert.ToInt32(Helper.ObterValorTextBoxPorId("quantidade"));
        }

        public void VoltarNavegacao(int vezes = 1)
        {
            Helper.VoltarNavegacao(vezes);
        }

        public void ZerarCarrinhoDeCompras()
        {
            while (ObterValorTotalCarrinho() > 0)
            {
                Helper.ClicarPorXPath("/html/body/div/main/div/div/div/table/tbody/tr[1]/td[5]/form/button");
            }
        }
    }
}