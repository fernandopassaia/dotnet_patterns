#pragma checksum "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "191f5f3166479ca911d30994bce22693b7a32579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinho/Index.cshtml", typeof(AspNetCore.Views_Carrinho_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#line 2 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"191f5f3166479ca911d30994bce22693b7a32579", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdStore.Vendas.Application.Queries.ViewModels.CarrinhoViewModel>
    {
        private global::AspNetCore.Views_Carrinho_Index.__Generated__SummaryViewComponentTagHelper __SummaryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vitrine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoDetalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AplicarVoucher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResumoDaCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(115, 121, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12 col-md-10 col-md-offset-1\">\r\n\r\n            ");
            EndContext();
            BeginContext(236, 14, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "191f5f3166479ca911d30994bce22693b7a325797613", async() => {
            }
            );
            __SummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Carrinho_Index.__Generated__SummaryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SummaryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
              
                if (Model?.Items != null)
                {

#line default
#line hidden
            BeginContext(332, 503, true);
            WriteLiteral(@"                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Produto</th>
                                <th>Quantidade</th>
                                <th class=""text-center"">Valor</th>
                                <th class=""text-center"">Valor Total</th>
                                <th> </th>
                            </tr>
                        </thead>
                        <tbody>

");
            EndContext();
#line 26 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                              
                                foreach (var item in Model.Items)
                                {

#line default
#line hidden
            BeginContext(969, 331, true);
            WriteLiteral(@"                                    <tr>
                                        <td class=""col-sm-5 col-md-5"">
                                            <div class=""media"">
                                                <div class=""media-body"">
                                                    <h4 class=""media-heading"">");
            EndContext();
            BeginContext(1300, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191f5f3166479ca911d30994bce22693b7a3257910251", async() => {
                BeginContext(1388, 16, false);
#line 33 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                                                                                                Write(item.ProdutoNome);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                                                                        WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1408, 307, true);
            WriteLiteral(@"</h4>
                                                </div>
                                            </div>
                                        </td>

                                        <td class=""col-sm-2 col-md-2"" style=""text-align: center"">
                                            ");
            EndContext();
            BeginContext(1715, 955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191f5f3166479ca911d30994bce22693b7a3257913561", async() => {
                BeginContext(1788, 88, true);
                WriteLiteral("\r\n                                                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1876, "\"", 1899, 1);
#line 40 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 1884, item.ProdutoId, 1884, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1900, 237, true);
                WriteLiteral(" />\r\n                                                <div class=\"row\" style=\"float: left\">\r\n                                                    <input style=\"width: 70px\" type=\"text\" class=\"form-control\" name=\"quantidade\" id=\"quantidade\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2137, "\"", 2161, 1);
#line 42 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 2145, item.Quantidade, 2145, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2162, 501, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""row"" style=""float: right"">
                                                    <button type=""submit"" class=""btn btn-success"">
                                                        <span class=""fas fa-sync""></span>
                                                    </button>
                                                </div>
                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2670, 158, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-1 col-md-1 text-center\"><strong id=\"valorUnitario\">");
            EndContext();
            BeginContext(2829, 32, false);
#line 51 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                                        Write(item.ValorUnitario.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2861, 122, true);
            WriteLiteral("</strong></td>\r\n                                        <td class=\"col-sm-1 col-md-1 text-center\"><strong id=\"valorTotal\">");
            EndContext();
            BeginContext(2984, 29, false);
#line 52 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                                     Write(item.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 134, true);
            WriteLiteral("</strong></td>\r\n\r\n                                        <td class=\"col-sm-1 col-md-1\">\r\n                                            ");
            EndContext();
            BeginContext(3147, 493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191f5f3166479ca911d30994bce22693b7a3257918810", async() => {
                BeginContext(3218, 88, true);
                WriteLiteral("\r\n                                                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3306, "\"", 3329, 1);
#line 56 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 3314, item.ProdutoId, 3314, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3330, 303, true);
                WriteLiteral(@" />
                                                <button type=""submit"" class=""btn btn-danger"">
                                                    <span class=""fas fa-trash-alt""></span> Remover
                                                </button>
                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3640, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 63 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(3798, 295, true);
            WriteLiteral(@"
                            <tr>
                                <td> </td>
                                <td> </td>
                                <td> </td>
                                <td><h5>Subtotal</h5></td>
                                <td class=""text-right""><h5><strong>");
            EndContext();
            BeginContext(4094, 28, false);
#line 71 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                              Write(Model.SubTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4122, 220, true);
            WriteLiteral("</strong></h5></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> </td>\r\n                                <td colspan=\"2\">\r\n                                    ");
            EndContext();
            BeginContext(4342, 802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191f5f3166479ca911d30994bce22693b7a3257923134", async() => {
                BeginContext(4416, 247, true);
                WriteLiteral("\r\n                                        <div class=\"row\" style=\"float: left\">\r\n                                            <input placeholder=\"Voucher\" style=\"width: 150px\" type=\"text\" class=\"form-control\" name=\"VoucherCodigo\" id=\"VoucherCodigo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4663, "\"", 4691, 1);
#line 78 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 4671, Model.VoucherCodigo, 4671, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4692, 445, true);
                WriteLiteral(@">
                                        </div>
                                        <div class=""row"" style=""float: right"">
                                            <button type=""submit"" class=""btn btn-success"">
                                                <span class=""fas fa-sync""></span>
                                            </button>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5144, 168, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td><h5>Desconto</h5></td>\r\n                                <td class=\"text-right\"><h5><strong>");
            EndContext();
            BeginContext(5313, 33, false);
#line 88 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                              Write(Model.ValorDesconto.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(5346, 480, true);
            WriteLiteral(@"</strong></h5></td>
                            </tr>
                            <tr>
                                <td> </td>
                                <td> </td>
                                <td> </td>
                                <td>
                                    <h3>Total</h3>
                                </td>
                                <td class=""text-right"">
                                    <h3><strong id=""valorTotalCarrinho"">");
            EndContext();
            BeginContext(5827, 30, false);
#line 98 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                   Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(5857, 330, true);
            WriteLiteral(@"</strong></h3>
                                </td>
                            </tr>
                            <tr>
                                <td> </td>
                                <td> </td>
                                <td> </td>
                                <td>
                                    ");
            EndContext();
            BeginContext(6187, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191f5f3166479ca911d30994bce22693b7a3257928264", async() => {
                BeginContext(6255, 137, true);
                WriteLiteral("\r\n                                        <span class=\"fa fa-shopping-cart\"></span>Continuar Compra\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6396, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6511, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191f5f3166479ca911d30994bce22693b7a3257930185", async() => {
                BeginContext(6592, 136, true);
                WriteLiteral("\r\n                                        <span class=\"fas fa-play\"></span><br /> Finalizar Compra\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6732, 140, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 118 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(6932, 54, true);
            WriteLiteral("                    <div><p>Carrinho Vazio</p></div>\r\n");
            EndContext();
#line 122 "C:\Dev\dotnet_patterns\UnitTests\EduardoPires\03 - Testes de Integracao\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(7020, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdStore.Vendas.Application.Queries.ViewModels.CarrinhoViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:summary")]
        public class __Generated__SummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__SummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Summary", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
