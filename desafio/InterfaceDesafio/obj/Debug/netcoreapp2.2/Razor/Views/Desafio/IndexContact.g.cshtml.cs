#pragma checksum "C:\projetos\desafio\desafio\InterfaceDesafio\Views\Desafio\IndexContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ace181e2736b1b35091be85439abf48e5be4c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desafio_IndexContact), @"mvc.1.0.view", @"/Views/Desafio/IndexContact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Desafio/IndexContact.cshtml", typeof(AspNetCore.Views_Desafio_IndexContact))]
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
#line 1 "C:\projetos\desafio\desafio\InterfaceDesafio\Views\_ViewImports.cshtml"
using InterfaceDesafio;

#line default
#line hidden
#line 2 "C:\projetos\desafio\desafio\InterfaceDesafio\Views\_ViewImports.cshtml"
using InterfaceDesafio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ace181e2736b1b35091be85439abf48e5be4c5", @"/Views/Desafio/IndexContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99f536e122cfcf950cb878a5ef048f3b66b715c", @"/Views/_ViewImports.cshtml")]
    public class Views_Desafio_IndexContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editar-form-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\projetos\desafio\desafio\InterfaceDesafio\Views\Desafio\IndexContact.cshtml"
  
    ViewData["Title"] = "IndexContact";

#line default
#line hidden
            BeginContext(50, 597, true);
            WriteLiteral(@"
<div class=""container"">
    <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#janela"" id=""adicionar-contato"">Adicionar</button>

    <div class=""modal fade"" role=""dialog"" id=""janela"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Adicionar Contato</h5>
                    <button class=""close"" data-dismiss=""modal""><span>&times;</span></button>
                </div>
                <div class=""modal-body"">
                    ");
            EndContext();
            BeginContext(647, 979, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ace181e2736b1b35091be85439abf48e5be4c55315", async() => {
                BeginContext(684, 935, true);
                WriteLiteral(@"
                        <table class=""table"">
                            <input type=""hidden"" id=""id-contato"">
                            <tr>
                                <td>Nome</td>
                                <td><input class=""form-control"" type=""text"" id=""nome-contato"" /></td>
                            </tr>
                            <tr>
                                <td>Celular</td>
                                <td><input class=""form-control"" type=""text"" id=""celular-contato"" /></td>
                            </tr>
                            <tr>
                                <td>Endereço</td>
                                <td><input class=""form-control"" type=""text"" id=""endereco-contato"" /></td>
                            </tr>
                        </table>
                        <td><input class=""btn btn-primary form-control"" type=""submit""/></td>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1626, 874, true);
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-danger"" data-dismiss=""modal"">Fechar</button>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container"">
    <button hidden class=""btn btn-primary"" data-toggle=""modal"" data-target=""#janela-editar"" id=""janela-editar-contato"">Adicionar</button>

    <div class=""modal fade"" role=""dialog"" id=""janela-editar"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Editar Contato</h5>
                    <button class=""close"" data-dismiss=""modal""><span id=""span-close"">&times;</span></button>
                </div>
                <div class=""modal-body"">
                    ");
            EndContext();
            BeginContext(2500, 1015, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ace181e2736b1b35091be85439abf48e5be4c58803", async() => {
                BeginContext(2544, 964, true);
                WriteLiteral(@"
                        <table class=""table"">
                            <input type=""hidden"" id=""editar-id-contato"">
                            <tr>
                                <td>Nome</td>
                                <td><input class=""form-control"" type=""text"" id=""editar-nome-contato"" /></td>
                            </tr>
                            <tr>
                                <td>Celular</td>
                                <td><input class=""form-control"" type=""text"" id=""editar-celular-contato"" /></td>
                            </tr>
                            <tr>
                                <td>Endereço</td>
                                <td><input class=""form-control"" type=""text"" id=""editar-endereco-contato"" /></td>
                            </tr>
                        </table>
                        <td><input class=""btn btn-primary form-control"" type=""submit"" /></td>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3515, 428, true);
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-danger"" data-dismiss=""modal"">Fechar</button>
                </div>
            </div>
        </div>
    </div>
</div>
<h1>Contatos</h1>

<table class=""table"">
    <tr>
        <th>Nome</th>
        <th>Celular</th>
        <th>Endereço</th>
    </tr>
    <tbody id=""contatos-body""></tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
