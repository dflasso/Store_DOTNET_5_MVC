#pragma checksum "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e696da6ce13c5cb12fc16a07645e2cfa51516da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Config_Profile), @"mvc.1.0.view", @"/Views/Config/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e696da6ce13c5cb12fc16a07645e2cfa51516da3", @"/Views/Config/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f782ea00ed2145aacc25b6b07d862c844f196f", @"/Views/_ViewImports.cshtml")]
    public class Views_Config_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Config/Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Config/EditProfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""container-root"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-2"">
                    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal""   data-target=""#New-Profiles"">Agregar Perfil
                    </button>
            </div>
        </div>
        <hr/>
        <div class=""row justify-content-md-center card"">
            <div class=""col-md-auto"">
");
#nullable restore
#line 12 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                  
                    List<Profile> LtsProfiles = ViewBag.LtsProfiles;
                    if (LtsProfiles.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-sm"">
                            <thead class=""table-light"">
                                <tr class=""table-primary"">
                                    <th scope=""col"">#</th>
                                    <th scope=""col"">Nombre del Perfil</th>
                                    <th scope=""col"">Estado del Perfil</th>
                                    <th scope=""col"">Editar</th>
                                    <th scope=""col"">Eliminar</th>
                                </tr>
                            </thead>
");
#nullable restore
#line 26 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                              
                                foreach (Profile pr in LtsProfiles)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"table-light\">\n                                        <th>");
#nullable restore
#line 30 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                       Write(pr.ProfileId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                                        <th>");
#nullable restore
#line 31 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                       Write(pr.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n");
#nullable restore
#line 32 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                          
                                            if(pr.IsEnable)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <th>Activo</th>\n");
#nullable restore
#line 36 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <th>Inactivo</th>\n");
#nullable restore
#line 40 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th scope=\"row\">\n                                            <button type=\"button\" class=\"btn btn-outline-primary\" data-toggle=\"modal\"\n                                                data-target=\"#Editar-Profiles\"");
            BeginWriteAttribute("onclick", "\n                                                onclick=\"", 2250, "\"", 2348, 3);
            WriteAttributeValue("", 2308, "page.onClickEditProfile(\'", 2308, 25, true);
#nullable restore
#line 45 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
WriteAttributeValue("", 2333, pr.ProfileId, 2333, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2346, "\')", 2346, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""bi bi-pencil-square""></i>
                                            </button>
                                        </th>
                                        <th scope=""row"">
                                            <button type=""button"" class=""btn btn-outline-danger""");
            BeginWriteAttribute("onclick", " onclick=\"", 2688, "\"", 2746, 5);
            WriteAttributeValue("", 2698, "deleteProfile(\'", 2698, 15, true);
#nullable restore
#line 50 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
WriteAttributeValue("", 2713, pr.ProfileId, 2713, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2726, "\',\'", 2726, 3, true);
#nullable restore
#line 50 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
WriteAttributeValue("", 2729, pr.ProfileName, 2729, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2744, "\')", 2744, 2, true);
            EndWriteAttribute();
            WriteLiteral(" >\n                                                <i class=\"bi bi-x-circle\"></i>\n                                            </button>\n                                        </th>\n                                    </tr>\n");
#nullable restore
#line 55 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\n");
#nullable restore
#line 58 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>

<!-- Modal New-->
  <div class=""modal fade"" id=""New-Profiles"" role=""dialog"">
    <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Nuevo Perfil</h5>
        <button type=""button"" class=""btn btn-danger btn-sm"" data-dismiss=""modal"" aria-label=""Close"">X</button>
      </div>
       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e696da6ce13c5cb12fc16a07645e2cfa51516da310979", async() => {
                WriteLiteral(@"
        <div class=""modal-body"">
            <input type=""hidden"" id=""modal-new-ProfileId""  name=""Key"" />
                <div class=""mb-3"">
                    <label for=""modal-new-ProfileName"" class=""form-label"">Nombre Perfil</label>
                    <input type=""text"" class=""form-control"" id=""modal-new-ProfileName"" name=""ProfileName""  >
                </div>
                <hr/>
                <div class=""mb-1"">
                    <label class=""form-label"">Seleccione los permisos del Perfil: </label>
                </div>
");
#nullable restore
#line 84 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                   
                    List<Permissions> permissions = ViewBag.LtsPermissons;

                    if (@permissions.Count > 0)
                    {
                        foreach(Permissions perm in permissions)
                        {
                            if(perm.PatternPermissonId != 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-check\" >\n                                    <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 4594, "\"", 4621, 1);
#nullable restore
#line 94 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
WriteAttributeValue("", 4602, perm.PermissionsId, 4602, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 4622, "\"", 4646, 1);
#nullable restore
#line 94 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
WriteAttributeValue("", 4627, perm.PermissionsId, 4627, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PermissonsSelected\"/>\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 4743, "\"", 4768, 1);
#nullable restore
#line 95 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
WriteAttributeValue("", 4749, perm.PermissionsId, 4749, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\n                                        ");
#nullable restore
#line 96 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                   Write(perm.TittleHeader);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </label>\n                                </div>    \n");
#nullable restore
#line 99 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                            }
                        }
                    }
                 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Cerrar</button>
            <button type=""submit"" class=""btn btn-outline-primary"" >Guardar</button>
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
            WriteLiteral(@"
    </div>
  </div>
  </div>

  <!-- Modal -Editar -->
  <div class=""modal fade"" id=""Editar-Profiles"" role=""dialog"">
    <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Editar Perfil</h5>
        <button type=""button"" class=""btn btn-danger btn-sm"" data-dismiss=""modal"" aria-label=""Close"">X</button>
      </div>
       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e696da6ce13c5cb12fc16a07645e2cfa51516da316343", async() => {
                WriteLiteral(@"
        <div class=""modal-body"">
                <input type=""hidden"" id=""modal-ProfileId""  name=""Key""  />
                <div class=""mb-3"">
                    <label for=""modal-ProfileName"" class=""form-label"">Nombre Menu</label>
                    <input type=""text"" class=""form-control"" id=""modal-ProfileName"" name=""ProfileName""  >
                </div>
                  <hr/>
                <div class=""mb-1"">
                    <label class=""form-label"">Seleccione los permisos del Perfil: </label>
                </div>
                <div class=""mb-1"" id=""containerOptionsPerm""></div>
        </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Cerrar</button>
            <button type=""submit"" class=""btn btn-outline-primary"" >Guardar Cambios</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n  </div>\n  </div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n      \n<script>\n    const prms = [\n");
#nullable restore
#line 147 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
         foreach (Profile pr in LtsProfiles)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("{ \"ProfileId\": \"");
#nullable restore
#line 149 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                         Write(pr.ProfileId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",  \"ProfileName\" : \"");
#nullable restore
#line 149 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                                           Write(pr.ProfileName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"IsEnable\":\"");
#nullable restore
#line 149 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
                                                                                         Write(pr.IsEnable);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n");
#nullable restore
#line 150 "/home/dlasso/Dany/Disribuidas/proyecto/G10COMERCIALIZADORA_DOTNET/Views/Config/Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    ];

    
    const context = () => {
        let prms = [];
        let prmFound = {};
        let permissons = [];
        let optionsPermisson = [];
        let awaitOptions = true;

        const addPrf = (Pr = []) => {
            prms = Pr;
        }
        const addPermss = (per = [] ) => {
            permissons = per;
        } 

        const getPrms = () => prms;

        const findProfile = (id ="""") => {
            let newPrms =  prms.filter( pr => pr.ProfileId === id);
            return (newPrms.length > 0) ? newPrms[0] : null;
        }

        const onClickEditProfile = (id = """") => {
            const profileFound = findProfile(id);
            if(profileFound)
            {
                prmFound = profileFound;
                document.getElementById(""modal-ProfileId"").value = profileFound.ProfileId; 
                document.getElementById(""modal-ProfileName"").value = profileFound.ProfileName;
                document.getElementById(""containerOptionsPerm"").innerHTML= render();
    ");
                WriteLiteral(@"            requestOptions(id);
            }
            
        }

        const getPrmFound = () => prmFound;

        const selectedNewPermisson = (event) => 
        {
            console.log(event.target.value);
        }


        const getOptionsPermisson = () => optionsPermisson;
        const setOptionsPermisson = (newOpt = []) => optionsPermisson = newOpt;

        const isAwaitOptions = () => awaitOptions;

        const requestOptions = (idProfile = """" ) => {
            fetch(`/Config/SearchPermissons?idProfile=${idProfile}`)
            .then(response => response.json())
            .then(data => {
                awaitOptions = false;
                optionsPermisson = data;
                document.getElementById(""containerOptionsPerm"").innerHTML=render();
            } );
        }

        const render = () => {
            if(awaitOptions){
                return `
                <div class=""spinner-border text-primary"" role=""status"">
                    <span class=""visually-hidden"">.</");
                WriteLiteral(@"span>
                </div>
                `;
            }else{
                return buildOptions();
            }
        }

        const buildOptions = () => {
            let  html = """";
            optionsPermisson.forEach( op => {
                html = html + `
                    <div class=""form-check"" >
                        <input class=""form-check-input"" type=""checkbox"" value=""${op.value}"" id=""${op.value}"" name=""PermissonsSelected"" ${op.isSelected? 'checked' : null} />
                        <label class=""form-check-label"" for=""${op.value}"" >
                            ${op.label}
                        </label>
                    </div>    
                `;
            });
            return html;
        } 

        return {
            addPrf,
            getPrms,
            onClickEditProfile,
            selectedNewPermisson,
            addPermss,
            getOptionsPermisson,
            setOptionsPermisson,
            isAwaitOptions,
            requestOptions,
          ");
                WriteLiteral(@"  render
        };
    }

    const page = context();
    page.addPrf(prms);

    const deleteProfile = (idProfile ="""", nameProfile = """") => {
        Swal.fire({
            title: `¿Está seguro de borrar el perfil: ${nameProfile}?`,
            text: ""Los usuarios asignados al perfil quedaran con el perfil de Invitado (sin permisos)."",
            icon: 'question',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Borrar',
            cancelButtonText: 'Cancelar'
            }).then((result) => {
            if (result.isConfirmed) {
                console.log(""borrar "" + idProfile);
            }
            })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
