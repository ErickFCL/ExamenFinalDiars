#pragma checksum "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\Compartir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b35af5825750be3666cdaab13a0c01f1bfac7a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_Compartir), @"mvc.1.0.view", @"/Views/Nota/Compartir.cshtml")]
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
#nullable restore
#line 1 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\_ViewImports.cshtml"
using ExFinalDiarsN00020449;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\_ViewImports.cshtml"
using ExFinalDiarsN00020449.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b35af5825750be3666cdaab13a0c01f1bfac7a6", @"/Views/Nota/Compartir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794813ca4ede787838e7c77ec1d5b41eec12722f", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_Compartir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card\" style=\" background: #000000\">\r\n    <h3 class=\"card-header text-center\" style=\"color: #ffffff\">NOTAS COMPARTIDAS DE AMIGOS</h3>\r\n    <div class=\"card-body\" style=\" background: #000000\">\r\n        <br />\r\n");
#nullable restore
#line 7 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\Compartir.cshtml"
         foreach (var item in ViewBag.notaCompartida)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body my-3\">\r\n\r\n                            <h6 align=\"center\">");
#nullable restore
#line 14 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\Compartir.cshtml"
                                          Write(item.Notas.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("  Compartido de: ");
#nullable restore
#line 14 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\Compartir.cshtml"
                                                                             Write(item.Usuarios.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> <hr />\r\n                            <span>");
#nullable restore
#line 15 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\Compartir.cshtml"
                             Write(item.Notas.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 21 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\Compartir.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
