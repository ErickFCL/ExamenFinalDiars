#pragma checksum "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55b44bb4e060d37a6ca5c3567ba9229a23f770fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota__Index), @"mvc.1.0.view", @"/Views/Nota/_Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b44bb4e060d37a6ca5c3567ba9229a23f770fd", @"/Views/Nota/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794813ca4ede787838e7c77ec1d5b41eec12722f", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
   Layout = null;
    var nota = (List<Nota>)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .list-group-item {
        background: #000000;
    }
</style>
<div class=""container-fluid"" style=""margin-left:40px;margin-right:40px"">
    <div class=""list-group"">
        <div class=""list-group-item"">
            <label id=""Nombre"" style="" background: #000000"" class=""form-control"">Todas las Notas</label><br />
");
#nullable restore
#line 14 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
             foreach (var item in nota)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 518, 2);
            WriteAttributeValue("", 493, "/Nota/Detalle?Id=", 493, 17, true);
#nullable restore
#line 16 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 510, item.Id, 510, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong style=\"color :#ffffff\"><li>");
#nullable restore
#line 16 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
                                                                                                    Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></strong></a>\r\n                <br />\r\n");
            WriteLiteral("                <span>\r\n");
#nullable restore
#line 20 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
                     if (item.Contenido.Length > 50)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"container\">\r\n                            <parcial style=\"color :#bfbbbb\">");
#nullable restore
#line 23 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
                                                       Write(item.Contenido.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial>\r\n                        </div>\r\n");
#nullable restore
#line 25 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"container\">\r\n                            <parcial style=\"color :#bfbbbb\">");
#nullable restore
#line 29 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
                                                       Write(item.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>\r\n                        </div>\r\n");
#nullable restore
#line 31 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n                <div align=\"right\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1249, "\"", 1282, 2);
            WriteAttributeValue("", 1256, "/Nota/Eliminar?id=", 1256, 18, true);
#nullable restore
#line 34 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1274, item.Id, 1274, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:20px;\" class=\"btn btn-danger float-lg-right\">Eliminar</a>\r\n                    <button id=\"editModal\" style=\"margin-right:20px;\" class=\"btn btn-primary float-lg-right\" href=\"#\" data-toggle=\"modal\" data-target=\"#edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1519, "\"", 1583, 7);
            WriteAttributeValue("", 1529, "selCuenta(\'", 1529, 11, true);
#nullable restore
#line 35 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1540, item.Id, 1540, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1548, "\',\'", 1548, 3, true);
#nullable restore
#line 35 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1551, item.Titulo, 1551, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1563, "\',\'", 1563, 3, true);
#nullable restore
#line 35 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1566, item.Contenido, 1566, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1581, "\')", 1581, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\r\n                </div><br /><br />\r\n");
#nullable restore
#line 37 "F:\ERICK\UPN\Ciclo 8\Calidad\ExFinalDiarsN00020449\ExFinalDiarsN00020449\Views\Nota\_Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

    </div>
    <br />
</div>

<!-- Modal -->
<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"">Guardar</button>
            </div>
        </div>
    </div>
</div>

<script>
    function selCuenta(id, titulo, cuerpo) {
        console.log(id + titulo + cue");
            WriteLiteral(@"rpo);
        $('#mtxtId').val(id);
        $('#mtxtTitulo').val(titulo);
        $('#mtxtCuerpo').val(cuerpo);
    };

    $.ajax({
        url: '/Nota/Edit',
        type: 'get'
    }).done(function (html) {
        $('#editNotita').html(html);
    })

    function submitForm() {
        $('#editNota').submit();
    }

    function editar(event) {
        event.preventDefault();
        var dataString = new FormData($('#edit form')[0]);
        $.ajax({
            url: ""/Nota/Edit"",
            type: ""post"",
            processData: false,  // Important!
            contentType: false,
            cache: false,
            data: dataString
        }).done(function (html) {
            location.reload();
        }).fail(function (html) {
            $('#editNotita').html(html.responseText);
        });
    }
</script>");
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
