#pragma checksum "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a9c5d4b503ea76790d88d7af6f9baf2e50392b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\_ViewImports.cshtml"
using LAB1;

#line default
#line hidden
#line 2 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\_ViewImports.cshtml"
using LAB1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a9c5d4b503ea76790d88d7af6f9baf2e50392b9", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd116ae04e8f30b9b173bea2948d4fecc147ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\About.cshtml"
  
    ViewData["Title"] = "О компании";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 4 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 72, true);
            WriteLiteral("</h2>\r\n<h3><i class=\"glyphicon glyphicon-user\" aria-hidden=\"true\" ></i> ");
            EndContext();
            BeginContext(141, 19, false);
#line 5 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\About.cshtml"
                                                            Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 362, true);
            WriteLiteral(@"</h3>

<p>Наша многовековая история началась с того, что разработчик увидел следующее: работа не сделана, а завтра надо что то показать</p>
<p>В общем работа создана за вечер бедным студентом за дошик</p>
<p>Это веб приложение фирмы приема металлолома, от приложения ничего хорошего ждать не стоит , но знай что метела забираем дороже чем у всех, ГЫЫre</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
