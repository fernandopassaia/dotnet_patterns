### Hi There. Starting now my knowledgments on Azure

**Nota sobre imagens**: Imagens de apoio na pasta Azure > img.

## Parte 1 Curso Azure na Prática Gratuíto do Canal DotNet

No Azure você tem três tipos de contratação:
Contas gratuítas - além de serviços grátis pra sempre - eles te dão 200 dólares pra gastar em 30 dias, e vários recursos gratuítos por 12 meses.
Contas por demanda - você paga pelo serviço que você consome, compra créditos e vai usando.
Contas por parceiros - Você pode fechar um contrato com uma empresa parceira do Azure, no Brasil a FCNuvem.

No mundo de Desenvolvimento você tem 4 tipos de Servidores pra sua hospedagem (ver imagem 3):
On Premises: Você cuida de tudo, includindo até mesmo a estrutura física, local, ar condicionado, seguro, parte elétrica (Brazilian).
IAS (Infrastructure as a Service): Você tem um modelo parecido com o VPS da Hostinger, você tem a máquina, você cuida do servidor, do sistema, updates, vírus  e tudo mais, mas ele fica fora.
PaaS - Platform as a Service: Azure, onde eu vou hospedar a aplicação e a infra por trás disso será cuidado por alguma empresa (aqui entra o Azure, AWS, Google Cloud).
SaaS - Software as a Service: Eu recebo o Software na Núvem e uso ele como é, o Office 365 é um exemplo disso.



**Storage Account**:
Serviço de armazenamento em núvem totalmente gerenciado, seguro, redundante e altamente disponível. Você tem pleno controle de tudo que acontece dentro dele, acessando o painel, seguro - todas transações que ocorrem são https e ele também tem uma criptografia e segurança dos arquivos armazenados.

Tem serviços de redundância integrados - ou seja, você pode fazer armazenamento dos seus dados em outros locais, até mesmo continentes, para que os dados estejam sempre seguros - dependendo muito do quanto você pretende gastar com isso $. O custo vai variar de acordo com a região que você quiser armazenar - Brasil, Oceania, Europa, América do Norte. EastWest geralmente é a mais barata.

Storage é dívidido em 4 serviços: Blob, Table, Queue e File. Veja as imagens na pasta para saber a diferença.


**Indo pra parte prática do curso** (minuto 01:30:30):






## Parte 2 Curso Azure na Prática Gratuíto 2 - Docker do Canal DotNet:






## Parte 3 Curso Azure na Prática Gratuíto 3 - GitHub Actions build e deploy automarizados - Docker do Canal DotNet:







## Curso do André Baltieri sobre GitHub Actions:

Dentro pasta eShop: dotnet new mvc (pra virar uma app qualquer).

**Ambiente de Produção x Desenvolvimento:**
Dentro do meu arquivo appSettings eu criei uma variavel chamada AMBIENTE, no settings normal ela está "PROD" e no meu de appsettings.development.json está DEV. Ou seja: Agora eu tenho duas variáveis de ambiente DEV e PROD, nos respectivos settings.json.

Alterei meu Index do HomeController, fiz DI do IConfiguration pra pegar essas variáveis e adicionei essas variáveis via ViewBag só pra mostrar elas na tela.

Antes:
public IActionResult Index()
{
            return View();
}

Depois:
public IActionResult Index([FromServices] IConfiguration config)
{
    ViewBag.Environment = config["Ambiente"];
    return View();
}

E adicionei a linha na minha Index pra mostrar essa variável: <h1 class="display-4">Welcome from @ViewBag.Environment</h1>
E ao Rodar minha App (dotnet watch run) você verá ela na tela de Desenvolvimento.

Nota: O ambiente que o .NET usará é setado no .vscode > lauch.json > env > "ASPNETCORE_ENVIRONMENT": "Development".

**Deploy**:
Eu não irei gravar dados sensíveis nos meus AppSettings, seja de produção ou não. Ou seja: A minha connectionString Real, um ID de loja do Android ou Apple, qualquer informação verdadeira, não deve ser guardada no appsettings pois isso daria acesso a todos os outros desenvolvedores.

Tudo que está no "appSettings" também irá numa cessão chamada AppSettings no Azure. Ou seja: Se eu tenho 'Ambiente" no meu AppSettings, eu devo criar também essa variável do meu appsettings no AZURE, e meu app irá ler esses dados de dentro do Azure, e não do meu projeto. Ou seja: O meu appsettings do projeto quase **morre** quando eu vou pra um Deploy em um ambiente como Azure que permite ter essas configurações na núvem.

Nota: Agora eu entrei no meu GitHub e criei um repositório chamado "aspnet-env-sample" para hospedar essa aplicação e integrar o Azure com o GitHub Actions. Como eu criei a aplicação ANTES de criar o repositório, terei que fazer uma **"engenharia" reversa** criando e inicializando o git na pasta APÓS ter criado o projeto. Então na pasta eShop:

git init
Dentro da pasta criei um ".gitignore" e adicionei "bin", "obj", "Properties" e ".vscode" para que as pastas sejam ignoradas. Verifique se os arquivos ficaram cinzas, significa que eles não serão enviados.
git add --all
git remote add origin https://github.com/fernandopassaia/aspnet-env-sample.git (esse path aparece logo ao criar o projeto no git)
git commit -m "Iniciando repo"
git push -u origin master

Pronto, basta consultar o projeto online e lá está. Agora vamos acessar o Azure e configurar um deployment a partir do repositório do github:

portal.azure.com
App Services > Add .

Subscription: Free Trial
Resource Group: passaia (criei novo)
Name: aspnet-env-sample
Publish: code
Runtime stack: .Net Core 3.1 (LTS)
Operational System: Linux
Region: Brazil South

(Nota: Dei PRINT nas configurações, dentro da pasta Azure > eShop_img estão as imagens.).

Espere a criação e quando estiver disponível: Click "Go To Resource". Irá abrir todos os detalhes e um painel bem legal, meu address é: **https://aspnet-env-sample.azurewebsites.net/**
Ao entrar no link verei uma aplicação "padrão" .NetCore do Azure pronta pra ser substituída pelo meu app do github. Bora lá?

Desça um pouco na barra esquerda e você verá a opção "Deployment Center". Aqui temos: Azure Repos, GitHub, BitBucket, LocalGit, FTP.
Ao escolher GitHub precisei dar permissão pro AzureApps acessar meu Git, e após isso escolhi o GitHub Actions.

Então ele listou todos meus projetos, e eu selecionei o aspnet-env-sample. Legal não? Ai eu mandei criar.

**NOTA**: Ele vai criar dentro do meu github, no meu repositório, um arquivo WorkFlow (eu posso ver a workflow indo na Aba ACTIONS do meu GitHub).
Meu GitHub fará o Deploy da aplicação e tudo mais, clicando sobre o Job terei todos os detalhes. Veja as imagens de 8 a 10.

É preciso esperar um pouco, dá pra acompanhar em tempo REAL a compilação, deploy e publicação do site, mas depois de 5 minutos no endereço o meu site estava lá. SHOW DEMAIS!
Veja a imagem 12 pra Entender.