#pragma checksum "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dc687bf6304d4d28cb668ad6a1130281ceee7ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Products), @"mvc.1.0.view", @"/Views/Home/Products.cshtml")]
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
#line 1 "D:\Jobsogning\PicoPublish\Case\Views\_ViewImports.cshtml"
using Case;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jobsogning\PicoPublish\Case\Views\_ViewImports.cshtml"
using Case.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dc687bf6304d4d28cb668ad6a1130281ceee7ff", @"/Views/Home/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529b6a7782c03b1a13ff366f6c5456af597d47dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Case.Models.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
  
    ViewData["Title"] = "Vis Produkter";
    ViewBag.Title = "Produkter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dc687bf6304d4d28cb668ad6a1130281ceee7ff3454", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dc687bf6304d4d28cb668ad6a1130281ceee7ff4456", async() => {
                WriteLiteral("\r\n    <h1>Produkter</h1>\r\n    </br>\r\n    \r\n    <table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </th>        \r\n    </tr>\r\n \r\n");
#nullable restore
#line 32 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 35 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
       Write(Html.DisplayFor(model => item.ProductID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 38 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 41 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>       \r\n    </tr>\r\n");
#nullable restore
#line 44 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"button\" value=\"Forrige Side\"");
                BeginWriteAttribute("onclick", " onclick=\"", 939, "\"", 1039, 3);
                WriteAttributeValue("", 949, "location.href=\'", 949, 15, true);
#nullable restore
#line 45 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
WriteAttributeValue("", 964, Url.Action("Products", "Home", new {pageNumber = ViewBag.pageNumber - 1}), 964, 74, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1038, "\'", 1038, 1, true);
                EndWriteAttribute();
                WriteLiteral("/>\r\n<input type=\"button\" value=\"Næste Side\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1083, "\"", 1183, 3);
                WriteAttributeValue("", 1093, "location.href=\'", 1093, 15, true);
#nullable restore
#line 46 "D:\Jobsogning\PicoPublish\Case\Views\Home\Products.cshtml"
WriteAttributeValue("", 1108, Url.Action("Products", "Home", new {pageNumber = ViewBag.pageNumber + 1}), 1108, 74, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1182, "\'", 1182, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n \r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Case.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591