#pragma checksum "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5701f21f8c9fe40adaeb037d8fda124bfde47af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_QuizResult), @"mvc.1.0.view", @"/Views/Mockups/QuizResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mockups/QuizResult.cshtml", typeof(AspNetCore.Views_Mockups_QuizResult))]
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
#line 1 "/home/elisey/Projects/WLab1/WLab1/Views/_ViewImports.cshtml"
using WLab1;

#line default
#line hidden
#line 2 "/home/elisey/Projects/WLab1/WLab1/Views/_ViewImports.cshtml"
using WLab1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5701f21f8c9fe40adaeb037d8fda124bfde47af1", @"/Views/Mockups/QuizResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb0f732f014f444ce62a5be1e8dd97992d8de77", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_QuizResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 14, true);
            WriteLiteral("<h1>Правильно ");
            EndContext();
            BeginContext(15, 15, false);
#line 1 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
         Write(ViewBag.Correct);

#line default
#line hidden
            EndContext();
            BeginContext(30, 4, true);
            WriteLiteral(" из ");
            EndContext();
            BeginContext(35, 13, false);
#line 1 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
                             Write(ViewBag.Total);

#line default
#line hidden
            EndContext();
            BeginContext(48, 11, true);
            WriteLiteral("</h1>\n<ul>\n");
            EndContext();
#line 3 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
  
    foreach (var Ex in (ViewBag.Result))
    {

#line default
#line hidden
            BeginContext(109, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(122, 8, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
       Write(Ex.First);

#line default
#line hidden
            EndContext();
            BeginContext(130, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(132, 12, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
                 Write(Ex.Operation);

#line default
#line hidden
            EndContext();
            BeginContext(144, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(146, 9, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
                               Write(Ex.Second);

#line default
#line hidden
            EndContext();
            BeginContext(155, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(159, 14, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
                                            Write(Ex.InputAnswer);

#line default
#line hidden
            EndContext();
            BeginContext(173, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 7 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/QuizResult.cshtml"
    }

#line default
#line hidden
            BeginContext(187, 5, true);
            WriteLiteral("</ul>");
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