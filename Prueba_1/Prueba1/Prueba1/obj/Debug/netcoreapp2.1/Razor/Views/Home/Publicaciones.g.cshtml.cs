#pragma checksum "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd91cdce7c19d77a2f0916d88edecf17ab4383d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Publicaciones), @"mvc.1.0.view", @"/Views/Home/Publicaciones.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Publicaciones.cshtml", typeof(AspNetCore.Views_Home_Publicaciones))]
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
#line 1 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\_ViewImports.cshtml"
using Prueba1;

#line default
#line hidden
#line 2 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\_ViewImports.cshtml"
using Prueba1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd91cdce7c19d77a2f0916d88edecf17ab4383d5", @"/Views/Home/Publicaciones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275d7bd50e4b4c701110f41f093aa96dca980672", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Publicaciones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prueba1.Models.Posts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
  
    ViewData["Title"] = "ComentariosDe";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 23, true);
            WriteLiteral("\r\n<h2>Publicaciones De ");
            EndContext();
            BeginContext(164, 14, false);
#line 8 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
                Write(ViewBag.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(178, 276, true);
            WriteLiteral(@"</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                T&iacute;tulo
            </th>
            <th>
                Publicaci&oacute;n
            </th>
            <th>Comentarios</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(503, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(564, 40, false);
#line 27 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
               Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
            EndContext();
            BeginContext(604, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(672, 39, false);
#line 30 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
               Write(Html.DisplayFor(modelItem => item.body));

#line default
#line hidden
            EndContext();
            BeginContext(711, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(779, 66, false);
#line 33 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
               Write(await Html.PartialAsync("Comments", Comments.GetComments(item.id)));

#line default
#line hidden
            EndContext();
            BeginContext(845, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 37 "D:\Nuxiba\Prueba_1\Prueba1\Prueba1\Views\Home\Publicaciones.cshtml"
        }

#line default
#line hidden
            BeginContext(902, 56, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p></p>\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(958, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36aa39eccbff4bba989a426e2393b484", async() => {
                BeginContext(980, 31, true);
                WriteLiteral("Regresar a la lista de usuarios");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1015, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prueba1.Models.Posts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
