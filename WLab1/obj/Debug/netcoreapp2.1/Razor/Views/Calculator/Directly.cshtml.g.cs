#pragma checksum "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198e107ddfd7a2d1f67538f94f33938a2336c52b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Directly), @"mvc.1.0.view", @"/Views/Calculator/Directly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Directly.cshtml", typeof(AspNetCore.Views_Calculator_Directly))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198e107ddfd7a2d1f67538f94f33938a2336c52b", @"/Views/Calculator/Directly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb0f732f014f444ce62a5be1e8dd97992d8de77", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Directly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 14, true);
            WriteLiteral("\n<h2>Numbers: ");
            EndContext();
            BeginContext(40, 18, false);
#line 3 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
        Write(service.GetFirst());

#line default
#line hidden
            EndContext();
            BeginContext(58, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(64, 19, false);
#line 3 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                                Write(service.GetSecond());

#line default
#line hidden
            EndContext();
            BeginContext(83, 16, true);
            WriteLiteral("</h2>\n\n<h3>Add: ");
            EndContext();
            BeginContext(100, 18, false);
#line 5 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
    Write(service.GetFirst());

#line default
#line hidden
            EndContext();
            BeginContext(118, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(122, 19, false);
#line 5 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                          Write(service.GetSecond());

#line default
#line hidden
            EndContext();
            BeginContext(141, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(145, 13, false);
#line 5 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                                                 Write(service.Add());

#line default
#line hidden
            EndContext();
            BeginContext(158, 15, true);
            WriteLiteral("</h3>\n<h3>Sub: ");
            EndContext();
            BeginContext(174, 18, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
    Write(service.GetFirst());

#line default
#line hidden
            EndContext();
            BeginContext(192, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(196, 19, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                          Write(service.GetSecond());

#line default
#line hidden
            EndContext();
            BeginContext(215, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(219, 13, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                                                 Write(service.Sub());

#line default
#line hidden
            EndContext();
            BeginContext(232, 15, true);
            WriteLiteral("</h3>\n<h3>Mul: ");
            EndContext();
            BeginContext(248, 18, false);
#line 7 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
    Write(service.GetFirst());

#line default
#line hidden
            EndContext();
            BeginContext(266, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(270, 19, false);
#line 7 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                          Write(service.GetSecond());

#line default
#line hidden
            EndContext();
            BeginContext(289, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(293, 13, false);
#line 7 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                                                 Write(service.Mul());

#line default
#line hidden
            EndContext();
            BeginContext(306, 15, true);
            WriteLiteral("</h3>\n<h3>Div: ");
            EndContext();
            BeginContext(322, 18, false);
#line 8 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
    Write(service.GetFirst());

#line default
#line hidden
            EndContext();
            BeginContext(340, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(344, 19, false);
#line 8 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                          Write(service.GetSecond());

#line default
#line hidden
            EndContext();
            BeginContext(363, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(367, 13, false);
#line 8 "/home/elisey/Projects/WLab1/WLab1/Views/Calculator/Directly.cshtml"
                                                 Write(service.Div());

#line default
#line hidden
            EndContext();
            BeginContext(380, 5, true);
            WriteLiteral("</h3>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IService service { get; private set; }
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
