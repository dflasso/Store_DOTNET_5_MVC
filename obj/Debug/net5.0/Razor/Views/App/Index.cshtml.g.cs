#pragma checksum "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/App/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88df806dc6ceb6827923e4f3411dd5d73a10cf51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Index), @"mvc.1.0.view", @"/Views/App/Index.cshtml")]
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
#line 1 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/_ViewImports.cshtml"
using G10COMERCIALIZADORA_DOTNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/_ViewImports.cshtml"
using G10COMERCIALIZADORA_DOTNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88df806dc6ceb6827923e4f3411dd5d73a10cf51", @"/Views/App/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f782ea00ed2145aacc25b6b07d862c844f196f", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/App/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"container-root\">\n    <article class=\"container-welcome\">\n            Bienvenido al Sistema:\n");
#nullable restore
#line 8 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/App/Index.cshtml"
              
                string userName = ViewBag.userName;
                if (userName != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/App/Index.cshtml"
               Write(userName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/App/Index.cshtml"
                             
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("    </article>\n</section>");
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
