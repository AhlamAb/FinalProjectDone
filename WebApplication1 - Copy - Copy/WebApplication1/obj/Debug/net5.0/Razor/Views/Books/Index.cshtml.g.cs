#pragma checksum "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b45bcc8316f8fa18ffaca853ab5210fba648e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b45bcc8316f8fa18ffaca853ab5210fba648e2", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9311070cf3b57be9f620fdc7d86c36529e7ebe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Summary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ahlam\OneDrive\Desktop\Test\WebApplication1 - Copy - Copy\WebApplication1\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--//header-->
<!-- banner section -->
<section id=""home"" class=""w3l-banner py-5"">
    <div class=""banner-image"">
    </div>
    <div id=""book"" class=""banner-content"">
        <div class=""container pt-5 pb-md-4"">
            <div class=""row align-items-center py-4"">
                <div class=""col-md-6 pr-lg-5"">
                    <h3 id=""pro"" class=""mb-lg-4 mb-3 title"">We Provide Your <span>Books</span></h3>
                    <p class=""mr-5"">
                        This site aims to provide services related to books electronically 
                        so that you can purchase the book electronically, which saves you time and effort
                    </p>
                    <div class=""mt-md-5 mt-4 mb-lg-0 mb-4"">
                        <a class=""btn btn-style"" href=""about.html"">Get Started</a>
                    </div>
                </div>
                <div class=""col-md-6 mt-md-0 mt-5 mb-lg-0 mb-5 right-banner-2 position-relative"">
                    <div class=""sub");
            WriteLiteral(@"-banner-image"">
                        <img src=""assets/images/banner-img.jpg""
                             class=""img-fluid radius-image-full position-relative"" alt="" "">
                    </div>
                    <div class=""banner-style-1 d-flex align-items-center"">
                        <i class=""fas fa-chart-line green-clr-bg""></i>
                        <h4>Buy books</h4>
                    </div>
                    <div class=""banner-style-1 banner-style-2 d-flex align-items-center"">
                        <i class=""fas fa-shield-alt primary-clr-bg""></i>
                        <h4>99.99% Save Effort</h4>
                    </div>
                    <div class=""banner-style-1 banner-style-3 d-flex align-items-center"">
                        <i class=""fas fa-chart-area blue-clr-bg""></i>
                        <h4>Save Time</h4>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- //banner section -->
<!-- 3grid");
            WriteLiteral(@"s section -->
<section id=""eff"" class=""about-section py-5"">
    <div class=""container py-lg-5 py-4"">
        <div  class=""title-heading-w3 mx-auto text-center mb-sm-5 mb-4 pb-xl-4"" style=""max-width:600px"">
            <h3  class=""title-style mb-2"">We Provide Effective Services!</h3>
            <p >
                We show you the books in the  book shop,
                 you can browse the available books, 
                 and you can also buy this book online.
            </p>
        </div>
        <div class=""row justify-content-center text-center"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""about-single p-3"">
                    <div class=""about-icon mb-4"">
                        <i class=""fas fa-business-time primary-clr-bg""></i>
                    </div>
                    <div class=""about-content"">
                        <h5 class=""mb-2""><a href=""about.html"">Browsing</a></h5>
                        <p>
                            Browsing books");
            WriteLiteral(@"
                            Finding out which books are available is now easy to do!
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-md-0 mt-3"">
                <div class=""about-single p-3"">
                    <div class=""about-icon mb-4"">
                        <i class=""fas fa-chart-pie green-clr-bg""></i>
                    </div>
                    <div class=""about-content"">
                        <h5 class=""mb-2""><a href=""about.html"">Selection</a></h5>
                        <p>
                            You can choose books and put them in the cart
                            also you can also remove them from the cart
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-lg-0 mt-2"">
                <div class=""about-single p-3"">
                    <div class=""about-icon mb-4"">
            ");
            WriteLiteral(@"            <i class=""fas fa-shipping-fast blue-clr-bg""></i>
                    </div>
                    <div class=""about-content"">
                        <h5 class=""mb-2""><a href=""about.html"">Buying</a></h5>
                        <p>
                           You can complete your order and you can buy books and pay online
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- //3grids section -->
<!-- home block 3 -->
<section class=""w3l-servicesblock py-5"">
    <div class=""container pb-lg-5"">
        <div class=""row pb-xl-5 align-items-center"">
            <div class=""col-lg-6 position-relative home-block-3-left pb-lg-0 pb-5"">
                <div class=""position-relative"">
                    <img id=""ser"" src=""assets/images/home1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5048, "\"", 5054, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid radius-image"">
                </div>
                <div class=""imginfo__box"">
                    <h6 class=""imginfo__title"">Get services now!</h6>
                    <p>Browse books, choose the right book for you, <br> and pay online </p>
                    <a href=""tel:http://962-796-931-416""><span class=""fa fa-phone mr-2""></span> 962-796-931-417</a>
                </div>

            </div>
            <div  class=""col-xl-5 col-lg-6 offset-xl-1 mt-lg-0 mt-5 pt-lg-0 pt-5"">
                <h3 class=""title-style"">
                    We have services
                    that will increase your comfort
                </h3>
                <p class=""mt-lg-4 mt-3 mb-sm-5 mb-4"">
                   



                </p>
                <div class=""two-grids mt-md-0 mt-md-5 mt-4"">
                    <div class=""grids_info"">
                        <i class=""fas fa-user-clock primary-clr-bg""></i>
                        <div class=""detail"">
                      ");
            WriteLiteral(@"      <h4>Create your account now!</h4>
                            <p>
                                Enter your name,phone number, email,
                                and choose a password to secure your account through it
                            </p>
                        </div>
                    </div>
                    <div class=""grids_info mt-5"">
                        <i class=""fas fa-laptop-house green-clr-bg""></i>
                        <div class=""detail"">
                            <h4>Tell your colleagues about our services!</h4>
                            <p>
                                Tell your colleagues about our website
                                so that they can buy books online
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- //home block 3 -->
<!-- home page service block -->
<section id=""serv"" class=""home-service");
            WriteLiteral(@"s py-5"" id=""services"">
    <div class=""container py-md-5 py-4"">
        <div class=""title-heading-w3 mx-auto text-center mb-sm-5 mb-4 pb-xl-4"" style=""max-width:600px"">
            <h3 id=""mec"" class=""title-style mb-2"">What's Services We Are Offering to Our Students/Sellers</h3>
            <p>
             
            </p>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""box-wrap"">
                    <div class=""icon"">
                        <i class=""fas fa-laptop-code blue-clr-bg""></i>
                    </div>
                    <h4 class=""number"">01</h4>
                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b45bcc8316f8fa18ffaca853ab5210fba648e214785", async() => {
                WriteLiteral("Create Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                    <p>
                        The seller can create an admin account through the website, 
                        and add all his information


                    </p>
                    <a href=""#read"" class=""read""></a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-md-0 mt-4"">
                <div class=""box-wrap"">
                    <div class=""icon"">
                        <i class=""fas fa-chart-bar primary-clr-bg""></i>
                    </div>
                    <h4 class=""number"">02</h4>
                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b45bcc8316f8fa18ffaca853ab5210fba648e216850", async() => {
                WriteLiteral(" Categorization Books");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                    <p>
                        You can create categories for books,
                        so that books can be classified according to them
                    </p>
                    <a href=""#read"" class=""read""></a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-lg-0 mt-4"">
                <div class=""box-wrap"">
                    <div class=""icon"">
                        <i class=""fas fa-copy green-clr-bg""></i>
                    </div>
                    <h4 class=""number"">03</h4>
                    <h4> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b45bcc8316f8fa18ffaca853ab5210fba648e219120", async() => {
                WriteLiteral("  Publish books");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                    <p>
                        You can publish books on the website with all the details, 
                         you can edit and delete it
                    </p>
                    <a href=""#read"" class=""read""></a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-4"">
                <div class=""box-wrap"">
                    <div class=""icon"">
                        <i class=""fas fa-user-cog green-clr-bg""></i>
                    </div>
                    <h4 class=""number"">04</h4>
                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b45bcc8316f8fa18ffaca853ab5210fba648e221380", async() => {
                WriteLiteral("User Account");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                    <p>
                        The student can create user account through the website , 
                         and add all his information


                    </p>
                    <a href=""#read"" class=""read""></a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-4"">
                <div class=""box-wrap"">
                    <div class=""icon"">
                        <i class=""fas fa-marker primary-clr-bg""></i>
                    </div>
                    <h4 class=""number"">05</h4>
                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b45bcc8316f8fa18ffaca853ab5210fba648e223433", async() => {
                WriteLiteral("Selection books");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                    <p>
                        The student can browse the available books , 
                        can choose the appropriate books and then put them in the basket
                    </p>
                    <a href=""#read"" class=""read""></a>
                </div>
            </div>
           
            <div class=""col-lg-4 col-md-6 mt-4"">
                <div class=""box-wrap"">
                    <div class=""icon"">
                        <i class=""fas fa-coins blue-clr-bg""></i>
                    </div>
                    <h4 class=""number"">06</h4>


   
                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b45bcc8316f8fa18ffaca853ab5210fba648e225734", async() => {
                WriteLiteral("Confirmation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                    <p>
                        The student can confirm his request, 
                        and then the details of the request appear for both the seller and the student
                    </p>
                    <a href=""#read"" class=""read""></a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- //home page service block -->
<!-- video section -->
<section class=""w3l-ab-section py-5"">
    <div class=""container py-md-5 py-4"">
        <div class=""row py-lg-4"">
            <div class=""col-lg-6 section-width align-self"">
                <h3 class=""title-style pr-xl-5"">We help businesses launch, grow and succeed</h3>
                <p class=""mt-lg-4 mt-3 pb-3"">
                    We help provide online services
                    so that it facilitates interaction between the service provider and the person requesting the service
                </p>
                <a href=""services.html"" class=""btn btn-style mt-4"">Our Services<");
            WriteLiteral(@"/a>
            </div>
            <div class=""col-lg-6 history-info mt-5 pt-lg-0 pt-5"">
                <div class=""position-relative img-border"">
                    <img src=""assets/images/video.jpg"" class=""img-fluid video-popup-image"" alt=""video-popup"">

                    <a href=""#small-dialog"" class=""popup-with-zoom-anim play-view text-center position-absolute"">
                        <span class=""video-play-icon"">
                            <span class=""fa fa-play""></span>
                        </span>
                    </a>
                    <!-- dialog itself, mfp-hide class is required to make dialog hidden -->
                    <div id=""small-dialog"" class=""zoom-anim-dialog mfp-hide"">
                        <iframe src=""https://player.vimeo.com/video/80590590"" allowfullscreen></iframe>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- //video section -->
<!-- footer -->
<footer class=""w3l-footer-29-main""");
            WriteLiteral(@">
    <div class=""footer-29 py-5"">
        <div class=""container py-lg-4"">
            <div class=""row footer-top-29"">
                <div class=""col-lg-9"">
                    <div class=""row"">
                        <div class=""col-md-3 col-6 footer-list-29"">
                            <ul>
                                <h6 class=""footer-title-29"">Book Shoop?</h6>
                                <li><a href=""#book"">About Us?</a></li>
                                <li><a href=""#eff"">What We Are Provide?</a></li>
                                <li><a href=""#ser"">About Our Services?</a></li>
                                <li><a href=""#mec"">Check Our Mechanism?</a></li>
                            </ul>
                        </div>
                        <div class=""col-lg-3 footer-contact-list mt-lg-0 mt-md-5 mt-4"">
                    <h6 class=""footer-title-29"">Social Media</h6>
                    <div class=""main-social-footer-29"">
                        <a href=""#facebook"" ");
            WriteLiteral(@"class=""facebook""><i class=""fab fa-facebook-f""></i></a>
                        <a href=""#twitter"" class=""twitter""><i class=""fab fa-twitter""></i></a>
                        <a href=""#google""><i class=""fab fa-google-plus-g""></i></a>
                        <a href=""#instagram"" class=""instagram""><i class=""fab fa-instagram""></i></a>
                    </div>
                    <!-- copyright -->
                    <p class=""copy-footer-29 mt-4"">
                        © 2022. All rights reserved. Developed by Ahlam AbedAljawwad & Morad Abu Radahha
                    </p>
                        
                    </div>
                </div>
               
                </div>
            </div>
        </div>
    </div>
</footer>
<!-- //footer -->
<!-- Js scripts -->
<!-- move top -->
<button onclick=""topFunction()"" id=""movetop"" title=""Go to top"">
    <span class=""fas fa-level-up-alt"" aria-hidden=""true""></span>
</button>
<script>
    // When the user scrolls down 20px from th");
            WriteLiteral(@"e top of the document, show the button
    window.onscroll = function () {
        scrollFunction()
    };

    function scrollFunction() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            document.getElementById(""movetop"").style.display = ""block"";
        } else {
            document.getElementById(""movetop"").style.display = ""none"";
        }
    }

    // When the user clicks on the button, scroll to the top of the document
    function topFunction() {
        document.body.scrollTop = 0;
        document.documentElement.scrollTop = 0;
    }
</script>
<!-- //move top -->
<!-- common jquery plugin -->
<script src=""assets/js/jquery-3.3.1.min.js""></script>
<!-- //common jquery plugin -->
<!-- banner image moving effect -->
<script>
    var lFollowX = 0,
        lFollowY = 0,
        x = 0,
        y = 0,
        friction = 1 / 30;

    function animate() {
        x += (lFollowX - x) * friction;
        y += (lFollowY - y) * fr");
            WriteLiteral(@"iction;

        translate = 'translate(' + x + 'px, ' + y + 'px) scale(1.1)';

        $('.banner-image').css({
            '-webit-transform': translate,
            '-moz-transform': translate,
            'transform': translate
        });

        window.requestAnimationFrame(animate);
    }

    $(window).on('mousemove click', function (e) {

        var lMouseX = Math.max(-100, Math.min(100, $(window).width() / 2 - e.clientX));
        var lMouseY = Math.max(-100, Math.min(100, $(window).height() / 2 - e.clientY));
        lFollowX = (20 * lMouseX) / 100; // 100 : 12 = lMouxeX : lFollow
        lFollowY = (10 * lMouseY) / 100;

    });

    animate();
</script>
<!-- //banner image moving effect -->
<!-- magnific popup -->
<script src=""assets/js/jquery.magnific-popup.min.js""></script>
<script>
    $(document).ready(function () {
        $('.popup-with-zoom-anim').magnificPopup({
            type: 'inline',

            fixedContentPos: false,
            fixedBgPos: true");
            WriteLiteral(@",

            overflowY: 'auto',

            closeBtnInside: true,
            preloader: false,

            midClick: true,
            removalDelay: 300,
            mainClass: 'my-mfp-zoom-in'
        });

        $('.popup-with-move-anim').magnificPopup({
            type: 'inline',

            fixedContentPos: false,
            fixedBgPos: true,

            overflowY: 'auto',

            closeBtnInside: true,
            preloader: false,

            midClick: true,
            removalDelay: 300,
            mainClass: 'my-mfp-slide-bottom'
        });
    });
</script>
<!-- //magnific popup -->
<!-- theme switch js (light and dark)-->
<script src=""assets/js/theme-change.js""></script>
<!-- //theme switch js (light and dark)-->
<!-- MENU-JS -->
<script>
    $(window).on(""scroll"", function () {
        var scroll = $(window).scrollTop();

        if (scroll >= 80) {
            $(""#site-header"").addClass(""nav-fixed"");
        } else {
            $(""#site-he");
            WriteLiteral(@"ader"").removeClass(""nav-fixed"");
        }
    });

    //Main navigation Active Class Add Remove
    $("".navbar-toggler"").on(""click"", function () {
        $(""header"").toggleClass(""active"");
    });
    $(document).on(""ready"", function () {
        if ($(window).width() > 991) {
            $(""header"").removeClass(""active"");
        }
        $(window).on(""resize"", function () {
            if ($(window).width() > 991) {
                $(""header"").removeClass(""active"");
            }
        });
    });
</script>
<!-- //MENU-JS -->
<!-- disable body scroll which navbar is in active -->
<script>
    $(function () {
        $('.navbar-toggler').click(function () {
            $('body').toggleClass('noscroll');
        })
    });
</script>
<!-- //disable body scroll which navbar is in active -->
<!-- bootstrap -->
<script src=""assets/js/bootstrap.min.js""></script>
<!-- //bootstrap -->
<!-- //Js scripts -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
