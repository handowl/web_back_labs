#pragma checksum "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01247233a2ad7dfd9335e88666bbb0510aa66bcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_Quiz), @"mvc.1.0.view", @"/Views/Mockups/Quiz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mockups/Quiz.cshtml", typeof(AspNetCore.Views_Mockups_Quiz))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01247233a2ad7dfd9335e88666bbb0510aa66bcd", @"/Views/Mockups/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb0f732f014f444ce62a5be1e8dd97992d8de77", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_Quiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(5, 11, false);
#line 1 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/Quiz.cshtml"
Write(Model.First);

#line default
#line hidden
            EndContext();
            BeginContext(16, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(19, 15, false);
#line 1 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/Quiz.cshtml"
             Write(Model.Operation);

#line default
#line hidden
            EndContext();
            BeginContext(34, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(36, 12, false);
#line 1 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/Quiz.cshtml"
                              Write(Model.Second);

#line default
#line hidden
            EndContext();
            BeginContext(48, 9, true);
            WriteLiteral(" = </h2>\n");
            EndContext();
            BeginContext(58, 14, false);
#line 2 "/home/elisey/Projects/WLab1/WLab1/Views/Mockups/Quiz.cshtml"
Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(72, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(73, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab663627a484d19a6d81fddbab8659f", async() => {
                BeginContext(93, 185, true);
                WriteLiteral("\n    <input name=\"InputAnswer\" type=\"text\">\n    <br>\n    <input type=\"submit\" value=\"next\" name=\"action\">\n    <input style=\"bacjground: blue\"type=\"submit\" value=\"finish\" name=\"action\">\n");
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