#pragma checksum "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7d4ebb7d93995b688841b43403747404272a94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7d4ebb7d93995b688841b43403747404272a94", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeff24890e2c8930b96372bf3913e0712513b27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vuelo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
   Layout = "_LayoutAdmin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Viajes Programados</h1>\r\n    <div class=\"row d-flex justify-content-between\">\r\n");
#nullable restore
#line 12 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mt-2\" style=\"width: 18rem;\">\r\n                <img src=\"http://placeimg.com/640/480/nature\" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"text-right\">\r\n");
#nullable restore
#line 17 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                     if (item.IdStatus == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge table-success\">");
#nullable restore
#line 19 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                                                     Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 20 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge table-danger\">");
#nullable restore
#line 23 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                                                    Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">\r\n                        Desde: ");
#nullable restore
#line 28 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                          Write(item.Origen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <i class=\"bi bi-arrow-right\"></i>\r\n                        <br />\r\n                        Hacia: ");
#nullable restore
#line 32 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                          Write(item.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                    <p class=\"card-text text-left\" style=\"font-size: 15px;\">\r\n                        Fecha salida: ");
#nullable restore
#line 35 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                                 Write(item.FechaSalida);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        Fecha llegada: ");
#nullable restore
#line 37 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
                                  Write(item.FechaEntrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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