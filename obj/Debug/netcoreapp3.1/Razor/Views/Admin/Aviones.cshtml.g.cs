#pragma checksum "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c72869861e11a10cefc536e18bf96661421b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Aviones), @"mvc.1.0.view", @"/Views/Admin/Aviones.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c72869861e11a10cefc536e18bf96661421b25", @"/Views/Admin/Aviones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeff24890e2c8930b96372bf3913e0712513b27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Aviones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Avion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
   Layout = "_LayoutAdmin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Aviones</h1>\r\n\r\n");
            WriteLiteral(@"
    <div class=""mt-3"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Placa</th>
                    <th scope=""col"">Modelo</th>
                    <th scope=""col"">Tipo</th>
                    <th scope=""col"">Capacidad</th>
");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 59 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                                   Write(item.IdAvion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 60 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                       Write(item.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 61 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                       Write(item.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                       Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 63 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                       Write(item.Capacidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Aviones.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Avion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
