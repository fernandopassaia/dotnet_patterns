using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CarregarCotacoes
{
    public class PaginaCotacoes
    {
        private SeleniumConfigurations _configurations;
        private IWebDriver _driver;

        public PaginaCotacoes(SeleniumConfigurations seleniumConfigurations)
        {
            _configurations = seleniumConfigurations;

            FirefoxOptions optionsFF = new FirefoxOptions();
            optionsFF.AddArgument("--headless");
            
            _driver = new FirefoxDriver(
                _configurations.CaminhoDriverFirefox
                , optionsFF);
        }

        public void CarregarPagina()
        {
            _driver.Manage().Timeouts().PageLoad =
                TimeSpan.FromSeconds(30);
            _driver.Navigate().GoToUrl(
                _configurations.UrlPaginaCotacoes);
        }

        public List<Cotacao> ObterCotacoes()
        {
            // NOTA BY FERNANDO: A PÁGINA DE COTAÇÕES DO UOL QUE O GROFFE USOU ERA DE 2018. MUDOU BASTANTE! O Driver até tenta ler, mas dá pau.
            // Eu NÃO irei corrigir a página, mas sim gerar alguns números randômicos e adicionar na tabela, só pra simular... https://economia.uol.com.br/cotacoes/
            List<Cotacao> cotacoes = new List<Cotacao>();
            //var tableCotacoes = _driver.FindElement(
            //    By.ClassName("quatro-colunas"));
            //var rowsCotacoes = tableCotacoes.FindElement(By.TagName("tbody"))
            //    .FindElements(By.TagName("tr"));
            //foreach (var rowCotacao in rowsCotacoes)
            //{
            //    var dadosCotacao =
            //        rowCotacao.FindElements(By.TagName("td"));

            //    Cotacao cotacao = new Cotacao();
            //    cotacao.NomeMoeda =
            //        dadosCotacao[0].FindElement(
            //            By.TagName("a")).GetAttribute("innerHTML");
            //    cotacao.DtUltimaCarga = DateTime.Now;
            //    cotacao.ValorCompra = Convert.ToDouble(
            //        dadosCotacao[1].GetAttribute("innerHTML"));
            //    cotacao.ValorVenda = Convert.ToDouble(
            //        dadosCotacao[2].GetAttribute("innerHTML"));
            //    cotacao.Variacao =
            //        dadosCotacao[3].FindElement(By.TagName("span")).Text;

            int segDigDolar = new Random().Next(0, 9);
            int terDigDolar = new Random().Next(0, 9);
            int segDigEuro = new Random().Next(0, 9);
            int terDigEuro = new Random().Next(0, 9);

            Cotacao cotacao = new Cotacao();
            cotacao.NomeMoeda = "Dólar";
            cotacao.DtUltimaCarga = DateTime.Now;
            cotacao.ValorCompra = Convert.ToDouble("4," + segDigDolar + terDigDolar);
            cotacao.ValorVenda = cotacao.ValorCompra + 0.32;
            cotacao.Variacao = "4,32%";
            cotacoes.Add(cotacao);

            Cotacao cotacao2 = new Cotacao();
            cotacao2.NomeMoeda = "Euro";
            cotacao2.DtUltimaCarga = DateTime.Now;
            cotacao2.ValorCompra = Convert.ToDouble("5," + segDigEuro + terDigEuro);
            cotacao2.ValorVenda = cotacao2.ValorCompra + 0.41;
            cotacao2.Variacao = "5,12%";
            cotacoes.Add(cotacao2);

            return cotacoes;
        }

        public void Fechar()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}