#pragma checksum "C:\_AppLanches\LanchesMac\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4332e70d3be5f9ec2a76a81e872c84fbb7c024c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 3 "C:\_AppLanches\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4332e70d3be5f9ec2a76a81e872c84fbb7c024c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e2e2c91193b66902d69037864d377d9b6eabe14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(25, 36, false);
#line 3 "C:\_AppLanches\LanchesMac\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Carousel"));

#line default
#line hidden
            EndContext();
            BeginContext(61, 86, true);
            WriteLiteral("\r\n\r\n<h2>Os preferidos da semana </h2>\r\n<h4>Tá com fome ???</h4>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "C:\_AppLanches\LanchesMac\Views\Home\Index.cshtml"
     foreach (var lanche in Model.LanchesPreferidos)
    {
        

#line default
#line hidden
            BeginContext(217, 38, false);
#line 11 "C:\_AppLanches\LanchesMac\Views\Home\Index.cshtml"
   Write(Html.Partial("_LanchesResumo", lanche));

#line default
#line hidden
            EndContext();
#line 11 "C:\_AppLanches\LanchesMac\Views\Home\Index.cshtml"
                                               
    }

#line default
#line hidden
            BeginContext(264, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
