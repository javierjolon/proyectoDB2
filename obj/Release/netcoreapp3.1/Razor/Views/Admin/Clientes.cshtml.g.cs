#pragma checksum "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce62c777f69e15c19e41e164f7898eccabc9c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Clientes), @"mvc.1.0.view", @"/Views/Admin/Clientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce62c777f69e15c19e41e164f7898eccabc9c51", @"/Views/Admin/Clientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeff24890e2c8930b96372bf3913e0712513b27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Clientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Persona>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
   Layout = "_LayoutAdmin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Ingreso Manual\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce62c777f69e15c19e41e164f7898eccabc9c514503", async() => {
                WriteLiteral(@"
                <div class=""d-flex"">
                    <div class=""input-group mb-3 col-6"">
                        <span class=""input-group-text"" id=""inputGroup-sizing-default"">DPI</span>
                        <input type=""text"" class=""form-control"" name=""dpi"" required>
                    </div>
                    <div class=""input-group mb-3 col-6"">
                        <span class=""input-group-text"" id=""inputGroup-sizing-default"">Email</span>
                        <input type=""email"" class=""form-control"" name=""email"" required>
                    </div>
                </div>

                <div class=""d-flex"">
                    <div class=""input-group mb-3 col-6"">
                        <span class=""input-group-text"" id=""inputGroup-sizing-default"">Nombre</span>
                        <input type=""text"" class=""form-control"" name=""nombre"" required>
                    </div>
                    <div class=""input-group mb-3 col-6"">
                        <span class=""inpu");
                WriteLiteral(@"t-group-text"" id=""inputGroup-sizing-default"">Apellido</span>
                        <input type=""text"" class=""form-control"" name=""apellido"" required>
                    </div>
                </div>

                <div class=""d-flex"">
                    <div class=""input-group mb-3 col-6"">
                        <span class=""input-group-text"" id=""inputGroup-sizing-default"">Fecha nacimiento</span>
                        <input type=""date"" class=""form-control"" name=""fechaNacimiento"" required>
                    </div>
                    <div class=""input-group mb-3 col-6"">
                        <span class=""input-group-text col-3"" id=""inputGroup-sizing-default"">Tipo persona</span>
                        <select class=""form-select col-9"" id=""inputGroupSelect03"" name=""tipoPersona"" required>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce62c777f69e15c19e41e164f7898eccabc9c516747", async() => {
                    WriteLiteral("Seleccione...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ce62c777f69e15c19e41e164f7898eccabc9c518600", async() => {
#nullable restore
#line 49 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
                                                    Write(item.Tipo);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                </div>


                <div class=""d-flex"">
                    <div class=""input-group mb-3 col-6"">
                        <span class=""input-group-text"" id=""inputGroup-sizing-default"">Telefono</span>
                        <input type=""text"" class=""form-control"" name=""telefono"" required>
                    </div>

                </div>

                <button type=""submit"" class=""btn btn-primary w-100"">Ingresar</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
AddHtmlAttributeValue("", 290, Url.Action("GuardarClienteMAnual", "Admin"), 290, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card mt-5\">\r\n        <div class=\"card-header\">\r\n            Ingreso por archivo\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 74 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
             using (Html.BeginForm("CargarClientesPorArchivo", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""input-group mb-3"">
                    <label class=""input-group-text"" for=""inputGroupFile01"">Subir</label>
                    <input type=""file"" class=""form-control"" id=""inputGroupFile01"" name=""formArchivo"">
                </div>
");
            WriteLiteral(@"                <div class=""mt-3 mb-3"">
                    <label for=""inputGroupFile01"">Que hacer con los usuarios repetidos?</label>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""saltarRepetidos"" id=""flexRadioDefault1"" value=""1"">
                        <label class=""form-check-label"" for=""flexRadioDefault1"">
                            Rollback
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""saltarRepetidos"" id=""flexRadioDefault2"" checked value=""2"">
                        <label class=""form-check-label"" for=""flexRadioDefault2"">
                            Saltarse los usuarios repeditos
                        </label>
                    </div>
                </div>
");
            WriteLiteral("                <div>\r\n                    <button class=\"btn btn-primary w-100\" type=\"submit\">Cargar </button>\r\n                </div>\r\n");
#nullable restore
#line 101 "C:\Users\DATOS\Desktop\ProyectoDB2\Views\Admin\Clientes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Persona>> Html { get; private set; }
    }
}
#pragma warning restore 1591