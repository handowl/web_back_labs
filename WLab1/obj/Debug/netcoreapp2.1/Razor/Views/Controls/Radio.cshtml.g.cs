#pragma checksum "/home/elisey/Projects/WLab1/WLab1/Views/Controls/Radio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a0699bff743183e46ef9a9fe7575ce7ee64ad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Radio), @"mvc.1.0.view", @"/Views/Controls/Radio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Controls/Radio.cshtml", typeof(AspNetCore.Views_Controls_Radio))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a0699bff743183e46ef9a9fe7575ce7ee64ad8", @"/Views/Controls/Radio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9193637c5092b2b8dfe1bd96a85a22782986a4eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_Radio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 30, true);
            WriteLiteral("<h1>Radio</h1>\n<h3>Month</h3>\n");
            EndContext();
#line 3 "/home/elisey/Projects/WLab1/WLab1/Views/Controls/Radio.cshtml"
  
    var val = ViewBag.Value;
    if (val != null){

#line default
#line hidden
            BeginContext(84, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(96, 3, false);
#line 6 "/home/elisey/Projects/WLab1/WLab1/Views/Controls/Radio.cshtml"
      Write(val);

#line default
#line hidden
            EndContext();
            BeginContext(99, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 7 "/home/elisey/Projects/WLab1/WLab1/Views/Controls/Radio.cshtml"
    }
    else{

#line default
#line hidden
            BeginContext(120, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(128, 1111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "222c0519b5964ff7854641b84484659b", async() => {
                BeginContext(148, 1084, true);
                WriteLiteral(@"
            <input type=""radio"" name=""value"" value=""January""><span>January</span><br>
            <input type=""radio"" name=""value"" value=""February""><span>February</span><br>
            <input type=""radio"" name=""value"" value=""March""><span>March</span><br>
            <input type=""radio"" name=""value"" value=""April""><span>April</span><br>
            <input type=""radio"" name=""value"" value=""May""><span>May</span><br>
            <input type=""radio"" name=""value"" value=""June""><span>June</span><br>
            <input type=""radio"" name=""value"" value=""July""><span>July</span><br>
            <input type=""radio"" name=""value"" value=""August""><span>August</span><br>
            <input type=""radio"" name=""value"" value=""September""><span>Septembe</span><br>
            <input type=""radio"" name=""value"" value=""October""><span>October</span><br>
            <input type=""radio"" name=""value"" value=""November""><span>November</span><br>
            <input type=""radio"" name=""value"" value=""December""><span>December</span><br>
            ");
                WriteLiteral("<br>\n            <input type=\"submit\" value=\"send\">\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1239, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 25 "/home/elisey/Projects/WLab1/WLab1/Views/Controls/Radio.cshtml"
    }

#line default
#line hidden
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
