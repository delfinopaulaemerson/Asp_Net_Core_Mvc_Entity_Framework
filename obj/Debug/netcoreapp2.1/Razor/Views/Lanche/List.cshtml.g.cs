#pragma checksum "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ba89a5b0c29bc19612ef1b5671ef5a2a663f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lanche_List), @"mvc.1.0.view", @"/Views/Lanche/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lanche/List.cshtml", typeof(AspNetCore.Views_Lanche_List))]
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
#line 1 "C:\_AppLanches\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#line 2 "C:\_AppLanches\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ba89a5b0c29bc19612ef1b5671ef5a2a663f0c", @"/Views/Lanche/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eaea5eb06b4f2d63f8b5aef9f2ab88fe446ee42", @"/Views/_ViewImports.cshtml")]
    public class Views_Lanche_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LancheMac.Models.Lanche>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(87, 21, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n<h2>");
            EndContext();
            BeginContext(109, 14, false);
#line 8 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
Write(ViewBag.Lanche);

#line default
#line hidden
            EndContext();
            BeginContext(123, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(135, 20, false);
#line 9 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
Write(ViewData["Ctegoria"]);

#line default
#line hidden
            EndContext();
            BeginContext(155, 16, true);
            WriteLiteral("</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(171, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdfa74b07b9f4b57a916d613c789a293", async() => {
                BeginContext(194, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(208, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(301, 40, false);
#line 17 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(341, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(397, 50, false);
#line 20 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoCurta));

#line default
#line hidden
            EndContext();
            BeginContext(447, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(503, 54, false);
#line 23 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoDetalhada));

#line default
#line hidden
            EndContext();
            BeginContext(557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(613, 41, false);
#line 26 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(654, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(710, 45, false);
#line 29 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.imagemUrl));

#line default
#line hidden
            EndContext();
            BeginContext(755, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(811, 54, false);
#line 32 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagemThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(865, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(921, 53, false);
#line 35 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.isLanchePreferido));

#line default
#line hidden
            EndContext();
            BeginContext(974, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1030, 45, false);
#line 38 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.EmEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1131, 45, false);
#line 41 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1294, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1343, 39, false);
#line 50 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1438, 49, false);
#line 53 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescricaoCurta));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1543, 53, false);
#line 56 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.DescricaoDetalhada));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1652, 40, false);
#line 59 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1748, 44, false);
#line 62 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.imagemUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1848, 53, false);
#line 65 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImagemThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1957, 52, false);
#line 68 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.isLanchePreferido));

#line default
#line hidden
            EndContext();
            BeginContext(2009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2065, 44, false);
#line 71 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2165, 56, false);
#line 74 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria.CategoriaId));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2276, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da718c571aa548c48ae20d9915d72dd0", async() => {
                BeginContext(2327, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
                                       WriteLiteral(item.LancheId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2335, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2355, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c593d0df11a64cf2b396b3218c8e6bf5", async() => {
                BeginContext(2409, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
                                          WriteLiteral(item.LancheId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2420, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2440, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99661687eda4d56b71cb0b81d7d549e", async() => {
                BeginContext(2493, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
                                         WriteLiteral(item.LancheId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2503, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 82 "C:\_AppLanches\LanchesMac\Views\Lanche\List.cshtml"
}

#line default
#line hidden
            BeginContext(2542, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LancheMac.Models.Lanche>> Html { get; private set; }
    }
}
#pragma warning restore 1591