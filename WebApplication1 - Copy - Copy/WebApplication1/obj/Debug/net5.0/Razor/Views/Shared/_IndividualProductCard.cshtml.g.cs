#pragma checksum "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bddd6c9d16e501e4c31b7f1015319dccacdab24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__IndividualProductCard), @"mvc.1.0.view", @"/Views/Shared/_IndividualProductCard.cshtml")]
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
#line 1 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bddd6c9d16e501e4c31b7f1015319dccacdab24", @"/Views/Shared/_IndividualProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9311070cf3b57be9f620fdc7d86c36529e7ebe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__IndividualProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark form-control btn-sm p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 43, "\"", 123, 6);
            WriteAttributeValue("", 51, "col-lg-4", 51, 8, true);
            WriteAttributeValue(" ", 59, "col-md-6", 60, 9, true);
            WriteAttributeValue(" ", 68, "pb-4", 69, 5, true);
            WriteAttributeValue(" ", 73, "filter", 74, 7, true);
#nullable restore
#line 2 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
WriteAttributeValue(" ", 80, Model.Category.Name.Replace(' ' , '_'), 81, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("   ", 120, "", 123, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <!-- Card-->\r\n    <div class=\"card bg-white rounded shadow-sm\" style=\"border:1px solid #222\" >\r\n\r\n        <div class=\"card-body px-3 pt-3 pb-1 row\">\r\n            <div class=\"col-7\" ><label class=\"float-left\">");
#nullable restore
#line 7 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n            <div class=\"col-5\"><label class=\"float-right\"><span class=\"text-info h5\">");
#nullable restore
#line 8 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
                                                                                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> /piece</label> </div>\r\n        </div>\r\n\r\n\r\n\r\n        <img class=\"card-img-top img-fluid d-block mx-auto mb-3\"");
            BeginWriteAttribute("src", " src=\"", 580, "\"", 611, 2);
#nullable restore
#line 13 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
WriteAttributeValue("", 586, WC.ImagePaht, 586, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
WriteAttributeValue("", 599, Model.Image, 599, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" >\r\n\r\n\r\n        <div class=\"card-body p-1 px-3 row\">\r\n            <br /><br />\r\n            <div class=\"col-6\">\r\n                <span class=\"badge p-2 border w-100\" style=\"background-color:lavenderblush\">");
#nullable restore
#line 19 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
                                                                                       Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n           \r\n\r\n            <div class=\"col-12 p-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bddd6c9d16e501e4c31b7f1015319dccacdab247615", async() => {
                WriteLiteral("View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Shared\_IndividualProductCard.cshtml"
                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
