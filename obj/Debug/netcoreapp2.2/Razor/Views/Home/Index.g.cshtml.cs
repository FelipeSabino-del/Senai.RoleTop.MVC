#pragma checksum "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf522055a5de23c818831cc0e96d7a6d13b6607f"
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
#line 1 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf522055a5de23c818831cc0e96d7a6d13b6607f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Eventos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Social", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Casamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Universitario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Corporativo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 832, true);
            WriteLiteral(@"
<!-- &*&*&*&*&*&*&*&*&*& MAIN - INICIO *&*&*&*&*&*&*&*&*&* -->
<main>
    <div>
        <div class=""slideshow-container"">
            <div class=""mySlides1"">
                <img src=""img/1.jpg"" style=""width:100%"" height=""auto"">
            </div>
            <div class=""mySlides1"">
                <img src=""img/2.jpg"" style=""width:100%"" height=""auto"">
            </div>
            <div class=""mySlides1"">
                <img src=""img/3.jpg"" style=""width:100%"" height=""auto"">
            </div>
            <a class=""prev"" onclick=""plusSlides(-1, 0)"">&#10094;</a>
            <a class=""next"" onclick=""plusSlides(1, 0)"">&#10095;</a>
        </div>
    </div>
    <div id=""cardapio"">
    <br>
        <h2>Cardápio de eventos</h2>

<br>
<br>
<br>
<br>
<br>
<br>

    <div class=""btn-group"">
        ");
            EndContext();
            BeginContext(871, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf522055a5de23c818831cc0e96d7a6d13b6607f5556", async() => {
                BeginContext(919, 49, true);
                WriteLiteral("<i class=\"fas fa-birthday-cake\"><p>Social</p></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(972, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(982, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf522055a5de23c818831cc0e96d7a6d13b6607f7186", async() => {
                BeginContext(1033, 44, true);
                WriteLiteral("<i class=\"fas fa-heart\"><p>Casamento</p></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1081, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1091, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf522055a5de23c818831cc0e96d7a6d13b6607f8815", async() => {
                BeginContext(1146, 57, true);
                WriteLiteral("<i class=\"fas fa-graduation-cap\"><p>Universitário</p></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1207, 11, true);
            WriteLiteral(" \r\n        ");
            EndContext();
            BeginContext(1218, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf522055a5de23c818831cc0e96d7a6d13b6607f10458", async() => {
                BeginContext(1271, 50, true);
                WriteLiteral("<i class=\"fas fa-handshake\"><p>Corporativo</p></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1325, 62, true);
            WriteLiteral("\r\n    </div>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n<hr>\r\n<br>\r\n");
            EndContext();
#line 45 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
     if (@Model.Eventos.Count > 0)
    {         

#line default
#line hidden
            BeginContext(1439, 76, true);
            WriteLiteral("        <h2>Futuros eventos</h2>\r\n<br>\r\n<br>\r\n<br>\r\n        <div id=\"jef\">\r\n");
            EndContext();
#line 52 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
         foreach (var evento in @Model.Eventos){       
                

#line default
#line hidden
#line 53 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                 if (evento.Status == 1 && evento.Id == 1)
                {

#line default
#line hidden
            BeginContext(1651, 77, true);
            WriteLiteral("                    <div>                \r\n                        <p>Evento ");
            EndContext();
            BeginContext(1729, 18, false);
#line 56 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                             Write(evento.Espaço.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 10, true);
            WriteLiteral(" <br> Dia ");
            EndContext();
            BeginContext(1758, 39, false);
#line 56 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                                                          Write(evento.DataDoEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1797, 54, true);
            WriteLiteral("</p>                    \r\n                    </div>\r\n");
            EndContext();
#line 58 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 59 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                 if (evento.Status == 1 && evento.Id == 2)
                {

#line default
#line hidden
            BeginContext(1969, 81, true);
            WriteLiteral("                    <div>                    \r\n                        <p>Evento ");
            EndContext();
            BeginContext(2051, 18, false);
#line 62 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                             Write(evento.Espaço.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2069, 10, true);
            WriteLiteral(" <br> Dia ");
            EndContext();
            BeginContext(2080, 39, false);
#line 62 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                                                          Write(evento.DataDoEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2119, 34, true);
            WriteLiteral("</p>\r\n                    </div>\r\n");
            EndContext();
#line 64 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 65 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                 if (evento.Status == 1 && evento.Id == 3)
                {

#line default
#line hidden
            BeginContext(2271, 81, true);
            WriteLiteral("                    <div>                    \r\n                        <p>Evento ");
            EndContext();
            BeginContext(2353, 18, false);
#line 68 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                             Write(evento.Espaço.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2371, 10, true);
            WriteLiteral(" <br> Dia ");
            EndContext();
            BeginContext(2382, 39, false);
#line 68 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                                                          Write(evento.DataDoEvento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2421, 54, true);
            WriteLiteral("</p>                    \r\n                    </div>\r\n");
            EndContext();
#line 70 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 70 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
                                     
        }

#line default
#line hidden
            BeginContext(2525, 238, true);
            WriteLiteral("        </div>\r\n<br>\r\n<br>\r\n<br>\r\n    <div id=\"feed-buttom\">\r\n        <button class=\"button-feedback\" onclick=\"openForm()\">\r\n            <span>\r\n                Faça o seu também\r\n            </span>\r\n        </button>\r\n    </div>\r\n<hr>\r\n");
            EndContext();
#line 84 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
    }else
    {

#line default
#line hidden
            BeginContext(2781, 329, true);
            WriteLiteral(@"        <h2>Nenhum evento no momento</h2>
<br>
<br>
<br>
            <div id=""feed-buttom"">
                <button class=""button-feedback"" onclick=""openForm()"">
                    <span>
                        Faça seu Rolê Top
                    </span>
                </button>
            </div>
        <hr>
");
            EndContext();
#line 98 "C:\Users\48417687858\Documents\Senai\RoleTop\MVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3117, 1408, true);
            WriteLiteral(@"

</main>
<!-- &*&*&*&*&*&*&*&*&*& MAIN - FIM *&*&*&*&*&*&*&*&*&* -->

<script>
    function myFunction() {
    var x = document.getElementById(""go"");
    if (x.className === ""topnav"") {
        x.className += "" responsive"";
        
    } else {
        x.className = ""topnav"";
    }
    }
</script>

<script>
        function myFunction() {
        var x = document.getElementById(""go"");
        if (x.className === ""topnav"") {
                x.className += "" responsive"";
                if (x.className === ""topnav responsive""){
                document.getElementById(""go"").style.paddingBottom = ""23em"";
                document.getElementById(""go"").style.fontSize = ""2.5em"";
                document.getElementById(""go"").style.backgroundColor = ""black"";
                document.getElementById(""go"").style.margin = ""0em"";
                
                }
        } else {
                x.className = ""topnav"";
                document.getElementById(""go"").style.paddingBottom = ""0"";");
            WriteLiteral(@"
                document.getElementById(""go"").style.fontSize = ""1.3em"";
                document.getElementById(""go"").style.backgroundColor = ""transparent"";
                document.getElementById(""go"").style.margin = ""0em"";
                
        }
        }
</script>

    <script>if (document.documentElement.clientWidth < 900) {
    // scripts
    }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591