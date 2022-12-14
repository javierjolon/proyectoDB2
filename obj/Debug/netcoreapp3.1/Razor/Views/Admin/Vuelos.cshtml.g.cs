#pragma checksum "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13cf80991b7ce3c0dd73a637fd0d5ad37c9db855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Vuelos), @"mvc.1.0.view", @"/Views/Admin/Vuelos.cshtml")]
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
#line 1 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\_ViewImports.cshtml"
using ProyectoDB2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\_ViewImports.cshtml"
using ProyectoDB2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13cf80991b7ce3c0dd73a637fd0d5ad37c9db855", @"/Views/Admin/Vuelos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeff24890e2c8930b96372bf3913e0712513b27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Vuelos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vuelo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
   Layout = "_LayoutAdmin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Vuelos</h1>\r\n    <div class=\"text-right\">\r\n        <a class=\"btn btn-primary text-white\"");
            BeginWriteAttribute("href", " href=\"", 246, "\"", 289, 1);
#nullable restore
#line 12 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
WriteAttributeValue("", 253, Url.Action("AgregarVuelo", "Admin"), 253, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Nuevo vuelo</a>
    </div>

    <div class=""mt-3"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Vuelo</th>
                    <th scope=""col"">Avion</th>
                    <th scope=""col"">Escalas</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">Acciones</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 28 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td class=\"text-left\">\r\n                            <i class=\"bi bi-arrow-up-right\"></i> ");
#nullable restore
#line 33 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                                            Write(item.Origen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br />\r\n                            <i class=\"bi bi-arrow-down-right\"></i> ");
#nullable restore
#line 35 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                                              Write(item.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                       Write(item.Avion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"d-flex flex-column\">\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 41 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                             switch (item.IdStatus)
                            {
                                case "1":

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-success\"> ");
#nullable restore
#line 44 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                                                  Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 45 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                    break;
                                case "2":

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-danger\"> ");
#nullable restore
#line 47 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                                                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 48 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                    break;
                                default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-info\"> Sin Status </span>\r\n");
#nullable restore
#line 51 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                                    break;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"d-flex flex-row justify-content-center\">\r\n");
#nullable restore
#line 55 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                             if (item.IdStatus == "1")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2239, "\"", 2310, 1);
#nullable restore
#line 57 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
WriteAttributeValue("", 2246, Url.Action("EliminarVuelo", "Admin", new { idVuelo = item.Id }), 2246, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"font-size: 12px\">\r\n                                    <i class=\"bi bi-dash-circle\"></i> Cancelar\r\n                                </a>\r\n");
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2515, "\"", 2597, 1);
#nullable restore
#line 61 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
WriteAttributeValue("", 2522, Url.Action("AgregarTripulacionAVuelo", "Admin", new { idVuelo = item.Id }), 2522, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning ml-1\" style=\"font-size: 12px\">\r\n                                    <i class=\"bi bi-plus-circle\"></i> Tripulacion\r\n                                </a>\r\n");
#nullable restore
#line 64 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Vuelos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        function ocultarEscala3() {
            document.getElementById(""divEscala3"").removeAttribute('style');
            document.getElementById(""divEscala3"").style.display = ""none"";
            document.getElementById(""es3"").value = """";
        }

        function escala3() {
            document.getElementById(""divEscala3"").removeAttribute('style');
            document.getElementById(""divEscala3"").style.display = ""flex"";
        }

        function ocultarEscala2() {
            document.getElementById(""divEscala2"").removeAttribute('style');
            document.getElementById(""divEscala2"").style.display = ""none"";

        }

        function escala2() {
            document.getElementById(""divEscala2"").removeAttribute('style');
            document.getElementById(""divEscala2"").style.display = ""flex"";
        }

        function escala1() {
            var check = $(""#checkEscala1"").is("":checked"");

            if (check) {
                document.getElementB");
                WriteLiteral(@"yId(""divEscala1"").removeAttribute('style');
                document.getElementById(""divEscala1"").style.display = ""flex"";
            } else {
                document.getElementById(""divEscala1"").removeAttribute('style');
                document.getElementById(""divEscala1"").style.display = ""none"";
            }

        }


    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vuelo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
