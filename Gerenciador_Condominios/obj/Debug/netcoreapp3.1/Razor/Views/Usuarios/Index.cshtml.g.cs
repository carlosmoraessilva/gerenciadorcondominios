#pragma checksum "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35c3d773855706d9a50780487fdbdc7c53825fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\_ViewImports.cshtml"
using Gerenciador_Condominios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\_ViewImports.cshtml"
using Gerenciador_Condominios.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
using Gerenciador_Condominios.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35c3d773855706d9a50780487fdbdc7c53825fdf", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c3fb716a4439769dcdf4d425ae0e2c69665eae", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gerenciador_Condominios.BLL.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerenciarUsuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Moradores cadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""tabelas"">
     <div class=""collection with-header"">
         <div class=""collection-header grey darken-1"">
             <div class=""row"">
                 <div class=""col s10"">
                     <h6 class=""white-text"">Moradores cadastrados</h6>
                 </div>
                 <div class=""col s2"">

                 </div>
             </div>

         </div>
         <div class=""collection-item"">
             <table class=""striped highlight"">
                 <thead>
                     <tr>
                         <th>
                            Nome
                         </th>
                         <th>
                             CPF
                         </th>
                         <th>
                             Email
                         </th>
                         <th>
                             Telefone
                         </th>
                         <th>
                             Status
                     ");
            WriteLiteral("    </th>\r\n                     </tr>\r\n                 </thead>\r\n                 <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                      foreach (var item in Model)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <tr>\r\n                         <td>\r\n                             ");
#nullable restore
#line 46 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         </td>\r\n                         <td>\r\n                             ");
#nullable restore
#line 49 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         </td>\r\n                         <td>\r\n                             ");
#nullable restore
#line 52 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         </td>\r\n                         <td>\r\n                             ");
#nullable restore
#line 55 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                         </td>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                          if (item.Status == StatusConta.Analisando)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td>\r\n                                 <span class=\"new badge purple darken-3\" data-badge-caption=\"\"");
            BeginWriteAttribute("id", " id=\"", 2160, "\"", 2173, 1);
#nullable restore
#line 62 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2165, item.Id, 2165, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 62 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                             </td>\r\n");
            WriteLiteral("                             <td");
            BeginWriteAttribute("class", " class=\"", 2297, "\"", 2313, 1);
#nullable restore
#line 65 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2305, item.Id, 2305, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                 <a class=\"btn-floating blue darkin-4 btnAprovar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2398, "\"", 2452, 6);
            WriteAttributeValue("", 2408, "AprovarUsuario(\'", 2408, 16, true);
#nullable restore
#line 66 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2424, item.Id, 2424, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2432, "\',", 2432, 2, true);
            WriteAttributeValue(" ", 2434, "\'", 2435, 2, true);
#nullable restore
#line 66 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2436, item.UserName, 2436, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2450, "\')", 2450, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\">thumb_up</i></a>\r\n                                 <a class=\"btn-floating red darkin-4 btnReprovar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2579, "\"", 2634, 6);
            WriteAttributeValue("", 2589, "ReprovarUsuario(\'", 2589, 17, true);
#nullable restore
#line 67 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2606, item.Id, 2606, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2614, "\',", 2614, 2, true);
            WriteAttributeValue(" ", 2616, "\'", 2617, 2, true);
#nullable restore
#line 67 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2618, item.UserName, 2618, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2632, "\')", 2632, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"material-icons\">thumb_down</i></a>\r\n                             </td>\r\n");
#nullable restore
#line 69 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                         }
                         else if (item.Status == StatusConta.Aprovado)
                         {


#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td>\r\n                                 <span class=\"new badge green darken-3\" data-badge-caption=\"\"> ");
#nullable restore
#line 74 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                             </td>\r\n");
            WriteLiteral("                             <td>\r\n                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35c3d773855706d9a50780487fdbdc7c53825fdf12584", async() => {
                WriteLiteral("<i class=\"material-icons\">group</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                                                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                                                                                                                                                            WriteLiteral(item.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                             </td>\r\n");
#nullable restore
#line 80 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                         }
                         else
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td>\r\n                                 <span class=\"new badge orange darken-3\" data-badge-caption=\"\"> ");
#nullable restore
#line 84 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                                                                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                             </td>\r\n");
#nullable restore
#line 86 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"

                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Carlos\source\repos\Gerenciador_Condominios\Gerenciador_Condominios\Views\Usuarios\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 </tbody>\r\n             </table>\r\n\r\n\r\n         </div>\r\n\r\n     </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gerenciador_Condominios.BLL.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
