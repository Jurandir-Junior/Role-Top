#pragma checksum "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30fe82452c659e7d4304c99db976a5383b3de349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30fe82452c659e7d4304c99db976a5383b3de349", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fe82452c659e7d4304c99db976a5383b3de3494529", async() => {
                BeginContext(55, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(61, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30fe82452c659e7d4304c99db976a5383b3de3494912", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(134, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 2131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fe82452c659e7d4304c99db976a5383b3de3497128", async() => {
                BeginContext(151, 244, true);
                WriteLiteral("\r\n<main>\r\n    <h2>Dashboard</h2>\r\n    <section id=\"status-pedidos\">\r\n        <h3>Status dos Pedidos</h3>\r\n        <div id=\"painel\">\r\n            <div class=\"box-status-pedidos aprovados\">\r\n                <h4>Aprovados</h4>\r\n                <p>");
                EndContext();
                BeginContext(396, 22, false);
#line 13 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosAprovados);

#line default
#line hidden
                EndContext();
                BeginContext(418, 137, true);
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos pendentes\">\r\n                <h4>Pendentes</h4>\r\n                <p>");
                EndContext();
                BeginContext(556, 22, false);
#line 17 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosPendentes);

#line default
#line hidden
                EndContext();
                BeginContext(578, 139, true);
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"box-status-pedidos reprovados\">\r\n                <h4>Reprovados</h4>\r\n                <p>");
                EndContext();
                BeginContext(718, 23, false);
#line 21 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
              Write(Model.PedidosReprovados);

#line default
#line hidden
                EndContext();
                BeginContext(741, 665, true);
                WriteLiteral(@"</p>
            </div>
        </div>
    </section>

    <section id=""lista-pedidos"">
        <h3>Lista de Pedidos</h3>
        <table>
            <thead>
                <tr>
                    <th rowspan=""2"">Nome</th>
                    <th rowspan=""2"">Evento</th>
                    <th rowspan=""2"">Tipo</th>
                    <th rowspan=""1"">Início</th>
                    <th rowspan=""1"">Fim</th>
                    <th colspan=""2"" rowspan=""2"">Aprovar</th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <td colspan=""6"">
                        <p>Pedidos atualizados em ");
                EndContext();
                BeginContext(1407, 12, false);
#line 42 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                                             Write(DateTime.Now);

#line default
#line hidden
                EndContext();
                BeginContext(1419, 99, true);
                WriteLiteral("</p>\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n            <tbody>\r\n");
                EndContext();
#line 47 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                 foreach (var pedido in Model.Pedidos)
                {

#line default
#line hidden
                BeginContext(1593, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(1648, 19, false);
#line 50 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Cliente.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1667, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1703, 24, false);
#line 51 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Evento.NomeEvento);

#line default
#line hidden
                EndContext();
                BeginContext(1727, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1763, 24, false);
#line 52 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Evento.TipoEvento);

#line default
#line hidden
                EndContext();
                BeginContext(1787, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1823, 17, false);
#line 53 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Evento.Dia);

#line default
#line hidden
                EndContext();
                BeginContext(1840, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1876, 21, false);
#line 54 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                       Write(pedido.Evento.HoraFim);

#line default
#line hidden
                EndContext();
                BeginContext(1897, 37, true);
                WriteLiteral("</td>\r\n                        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1934, "\'", 1995, 1);
#line 55 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1941, Url.Action("Aprovar","Pedido", new {id = @pedido.Id}), 1941, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1996, 65, true);
                WriteLiteral(" class=\"aceitar\">Aceitar</a></td>\r\n                        <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2061, "\'", 2123, 1);
#line 56 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2068, Url.Action("Reprovar","Pedido", new {id = @pedido.Id}), 2068, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2124, 61, true);
                WriteLiteral("class=\"recusar\">Recusar</a></td>\r\n                    </tr>\r\n");
                EndContext();
#line 58 "C:\Users\51855643855\Documents\MVC\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                }

#line default
#line hidden
                BeginContext(2204, 65, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </section>\r\n</main>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
