#pragma checksum "C:\_AppLanches\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfdab4e60cf70badba457837aec2eb19868b1533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CheckoutCompleto), @"mvc.1.0.view", @"/Views/Pedido/CheckoutCompleto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/CheckoutCompleto.cshtml", typeof(AspNetCore.Views_Pedido_CheckoutCompleto))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfdab4e60cf70badba457837aec2eb19868b1533", @"/Views/Pedido/CheckoutCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a79152fb628f03e848a1c6a79dff455c83b0923", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CheckoutCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 82, true);
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n        <h2>");
            EndContext();
            BeginContext(83, 32, false);
#line 5 "C:\_AppLanches\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
       Write(ViewBag.CheckoutCompletoMensagem);

#line default
#line hidden
            EndContext();
            BeginContext(115, 61, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <div>\r\n        Número do Pedido     : ");
            EndContext();
            BeginContext(177, 20, false);
#line 8 "C:\_AppLanches\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                          Write(ViewBag.NumeroPedido);

#line default
#line hidden
            EndContext();
            BeginContext(197, 33, true);
            WriteLiteral("\r\n        Valor Total do Pedido: ");
            EndContext();
            BeginContext(231, 19, false);
#line 9 "C:\_AppLanches\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                          Write(ViewBag.TotalPedido);

#line default
#line hidden
            EndContext();
            BeginContext(250, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
