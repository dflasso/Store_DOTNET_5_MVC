#pragma checksum "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Auth/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad90ce3b78399f3b2fd8f191753f6ad3e9de85e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad90ce3b78399f3b2fd8f191753f6ad3e9de85e", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f782ea00ed2145aacc25b6b07d862c844f196f", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Auth/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Auth/Login.cshtml"
  
  ViewData["Title"] = "Home Page";
  Layout = "_LayoutPublic";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
  <div class=""row no-gutter"">
    <div class=""d-none d-md-flex col-md-4 col-lg-6 bg-image""></div>
    <div class=""col-md-8 col-lg-6"">
      <div class=""login d-flex align-items-center py-5"">
        <div class=""container"">
          <div class=""row"">
            <div class=""col-md-9 col-lg-8 mx-auto"">
              <h3 class=""login-heading mb-4"">Bienvenido!</h3>
");
#nullable restore
#line 15 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Auth/Login.cshtml"
                
                string error = ViewBag.Error;
                if (error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"alert alert-danger\" role=\"alert\">\n                    ");
#nullable restore
#line 20 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Auth/Login.cshtml"
               Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                  </div>\n");
#nullable restore
#line 22 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Auth/Login.cshtml"
                }
              

#line default
#line hidden
#nullable disable
            WriteLiteral("\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad90ce3b78399f3b2fd8f191753f6ad3e9de85e5403", async() => {
                WriteLiteral(@"
                <div class=""form-label-group"">
                  <label for=""inputEmail"">Nombre de usuario o correo:</label>
                  <input type=""text"" id=""inputEmail"" class=""form-control"" required autofocus name=""usernameOrEmail"">
                </div>

                <div class=""form-label-group"">
                  <label for=""inputPassword"">Contrase??a</label>
                  <input type=""password"" id=""inputPassword"" class=""form-control"" required name=""password"">
                </div>
                <div class=""row-center"">
                  <button class=""btn-login"" type=""submit"">Iniciar Sesi??n</button>
                </div>

                <div class=""text-center"">
                  <a class=""small"" href=""#"">Olvide mi contrase??a?</a>
                </div>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n          </div>\n        </div>\n      </div>\n    </div>\n  </div>\n</div>");
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
