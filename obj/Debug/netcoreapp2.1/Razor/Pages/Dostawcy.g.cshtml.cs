#pragma checksum "C:\Users\Piotr\Documents\C# projects\ASP\Pages\Dostawcy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e56cb91a092f2d4195cee78773bb9d07b01a88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Dostawcy), @"mvc.1.0.razor-page", @"/Pages/Dostawcy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Dostawcy.cshtml", typeof(AspNetCore.Pages_Dostawcy), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e56cb91a092f2d4195cee78773bb9d07b01a88", @"/Pages/Dostawcy.cshtml")]
    public class Pages_Dostawcy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 206, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h1 class=\"display-2\">Dostawcy</h1>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-inverse\">\r\n            <tr><th>Nazwa firmy</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\Piotr\Documents\C# projects\ASP\Pages\Dostawcy.cshtml"
             foreach (var item in Model.Dostawcy)
            {

#line default
#line hidden
            BeginContext(374, 24, true);
            WriteLiteral("                <tr><td>");
            EndContext();
            BeginContext(399, 4, false);
#line 14 "C:\Users\Piotr\Documents\C# projects\ASP\Pages\Dostawcy.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(403, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 15 "C:\Users\Piotr\Documents\C# projects\ASP\Pages\Dostawcy.cshtml"
            }

#line default
#line hidden
            BeginContext(430, 110, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <p>Wprowadź nazwę swojego dostawcy:</p>\r\n    ");
            EndContext();
            BeginContext(540, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ef11c0f66bf4dd5b17624ce234d5f0f", async() => {
                BeginContext(560, 15, true);
                WriteLiteral("\r\n        <div>");
                EndContext();
                BeginContext(575, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c04d64e454e749ee97e2e760cf8b1676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 23 "C:\Users\Piotr\Documents\C# projects\ASP\Pages\Dostawcy.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Dostawca.CompanyName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(624, 59, true);
                WriteLiteral("</div>\r\n        <button type=\"submit\">Submit</button>\r\n    ");
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
            BeginContext(690, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindWeb.Pages.DostawcyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.DostawcyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.DostawcyModel>)PageContext?.ViewData;
        public NorthwindWeb.Pages.DostawcyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591