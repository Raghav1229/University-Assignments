#pragma checksum "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4597360ad14c63d71c6f1910746e0bc2e48735c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Developers_Details), @"mvc.1.0.view", @"/Views/Developers/Details.cshtml")]
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
#line 1 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\_ViewImports.cshtml"
using Waresoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\_ViewImports.cshtml"
using Waresoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4597360ad14c63d71c6f1910746e0bc2e48735c", @"/Views/Developers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6c707eff6e2a68160ca41d7b3816702fda01c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Developers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Software>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
  
    ViewData["Title"] = ViewBag.Developer;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
Write(ViewBag.Developer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <p><b>Назва:</b> ");
#nullable restore
#line 13 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><b>Вартість:</b> ");
#nullable restore
#line 14 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><b>Опис</b></p>\r\n            <p>");
#nullable restore
#line 16 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><b>Системні вимоги</b></p>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
          Write(item.Requirements);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Vlad_2\source\repos\C#\Waresoft(DB Lab2)\Waresoft\Views\Developers\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4597360ad14c63d71c6f1910746e0bc2e48735c6052", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" class=\"btn btn-outline-dark\" value=\"Назад до списку\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Software>> Html { get; private set; }
    }
}
#pragma warning restore 1591
