#pragma checksum "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3cd1418a007507461f3635f39f797ef5b21b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3cd1418a007507461f3635f39f797ef5b21b59", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd116ae04e8f30b9b173bea2948d4fecc147ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Наши контакты";

#line default
#line hidden
            BeginContext(49, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(54, 17, false);
#line 4 "C:\Users\FreakIris\Documents\Visual Studio 2019\VSC\LAB1\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(71, 497, true);
            WriteLiteral(@"</h2>

<p>
    <script type=""text/javascript"" charset=""utf-8"" async src=""https://api-maps.yandex.ru/services/constructor/1.0/js/?um=constructor%3Af71c0f74db8dedca5f64c5f40553a623a6ec64991a037d93e1016f162b3d2791&amp;width=614&amp;height=485&amp;lang=ru_RU&amp;scroll=true""></script>
</p>


<address>
    г.Крыжополь<br />
    ул.Строительная,228<br />
    <abbr title=""Phone""><i class=""glyphicon glyphicon-phone-alt"" aria-hidden=""true""></i>Тел:</abbr>
    8 800 555 35 35
</address>

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