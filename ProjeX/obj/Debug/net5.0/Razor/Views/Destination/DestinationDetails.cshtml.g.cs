#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
#line 1 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using ProjeX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using ProjeX.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using ProjeX.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using DTOLayer.DTOS.Announcement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using ProjeX.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using ProjeX.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\_ViewImports.cshtml"
using ProjeX.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86f06c927ed9bbcaf6d9995f38f709cc4688d5e", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6c392127b12acb4426bb12ffcfa98e78a49d07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Destination>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/css/style-liberty.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/js/theme-change.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
  
    ViewData["Title"] = "DestinationDetails";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e7405", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>STEP</title>
    <!-- google fonts -->
    <link href=""//fonts.googleapis.com/css2?family=Montserrat:wght@300;400;600;700&display=swap"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css2?family=Lato:ital,wght@0,300;0,400;0,700;1,400&display=swap""
          rel=""stylesheet"">
    <!-- google fonts -->
    <!-- Template CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e8189", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Template CSS -->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e10105", async() => {
                WriteLiteral(@"
    <!--header-->
    <header id=""site-header"" class=""fixed-top"">
        <div class=""container"">
            <nav class=""navbar navbar-expand-lg stroke"">
                <h1>
                    <a class=""navbar-brand mr-lg-5"" href=""index.html"">
                        Step
                    </a>
                </h1>
                <!-- if logo is image enable this
                <a class=""navbar-brand"" href=""#index.html"">
                    <img src=""image-path"" alt=""Your logo"" title=""Your logo"" style=""height:35px;"" />
                </a> -->
                <button class=""navbar-toggler  collapsed bg-gradient"" type=""button"" data-toggle=""collapse""
                        data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false""
                        aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon fa icon-expand fa-bars""></span>
                    <span class=""navbar-toggler-icon fa icon-close fa-times""></spa");
                WriteLiteral(@"n>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Default/Index"">Home <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""about.html"">About</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""services.html"">Destinations</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""pricing.html"">Packages</a>
                        </li>
                        <li class=""nav-item dropdown active"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown1"" role=""button"" data-togg");
                WriteLiteral(@"le=""dropdown""
                               aria-haspopup=""true"" aria-expanded=""false"">
                                Blog<span class=""fa fa-angle-down""></span>
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown1"">
                                <a class=""dropdown-item"" href=""blog.html"">Blog Posts</a>
                                <a class=""dropdown-item"" href=""blog-single.html"">Blog single</a>
                                <a class=""dropdown-item"" href=""landing-single.html"">Landing Page</a>
                            </div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""contact.html"">Contact</a>
                        </li>

                    </ul>
                </div>
                <div class=""d-lg-block d-none"">
                    <a href=""contact.html"" class=""btn btn-style btn-secondary"">Get In Touch</a>
                <");
                WriteLiteral(@"/div>
                <!-- toggle switch for light and dark theme -->
                <div class=""mobile-position"">
                    <nav class=""navigation"">
                        <div class=""theme-switch-wrapper"">
                            <label class=""theme-switch"" for=""checkbox"">
                                <input type=""checkbox"" id=""checkbox"">
                                <div class=""mode-container"">
                                    <i class=""gg-sun""></i>
                                    <i class=""gg-moon""></i>
                                </div>
                            </label>
                        </div>
                    </nav>
                </div>
                <!-- //toggle switch for light and dark theme -->
            </nav>
        </div>
    </header>
    <!-- //header -->
    <!-- about breadcrumb -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e14571", async() => {
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Single Page</h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index"">Home</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Single Post </li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //about breadcrumb -->
    <!--/blog-->
    <div class=""py-5 w3l-homeblock1 text-center"">
        <div class=""container mt-md-3"">
            <h3 class=""blog-desc-big text-center mb-4"">
                Alanında En Yetkin Rehberlerin Yorumları
            </h3>
            <div class=""blog-post-align"">
                <div class=""blog-post-img"">
                    <a href=""#""><img");
                BeginWriteAttribute("src", " src=\"", 5730, "\"", 5754, 1);
#nullable restore
#line 123 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 5736, Model.Guide.Image, 5736, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5755, "\"", 5761, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid\" /></a>\r\n                </div>\r\n                <div class=\"blog-post-info\">\r\n                    <div class=\"author align-items-center mb-1\">\r\n                        <a href=\"#\">");
#nullable restore
#line 127 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> in <a href=\"#\">");
#nullable restore
#line 127 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                                                                    Write(Model.Guide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    </div>\r\n                    <ul class=\"blog-meta\">\r\n                        <li class=\"meta-item blog-lesson\">\r\n                            <span class=\"meta-value\">");
#nullable restore
#line 131 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                                                Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </li>
                        <li class=""meta-item blog-students"">
                            <span class=""meta-value""></span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <section class=""blog-post-main w3l-homeblock1"">
        <!--/blog-post-->
        <div class=""blog-content-inf pb-5"">
            <div class=""container pb-lg-4"">
                <div class=""single-post-image"">
                    <div class=""post-content"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 6848, "\"", 6866, 1);
#nullable restore
#line 147 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 6854, Model.Image, 6854, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:1000px;height:400px;margin-left:40px\"  class=\"radius-image img-fluid mb-5\"");
                BeginWriteAttribute("alt", " alt=\"", 6955, "\"", 6961, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"single-post-content\">\r\n                    <p class=\"alphabet mb-4\">\r\n                        <span class=\"big-letter\"></span>");
#nullable restore
#line 152 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                                                   Write(Model.Details1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>
                    <p class=""mb-4"">
                       
                    </p>
                    
                    <div class=""sing-post-thumb mb-5 row pt-3"">
                        <div class=""col-sm-6"">
                            <a href=""#url""><img");
                BeginWriteAttribute("src", " src=\"", 7487, "\"", 7510, 1);
#nullable restore
#line 160 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 7493, Model.CoverImage, 7493, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 7542, "\"", 7548, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                        <div class=\"col-sm-6 mt-sm-0 mt-3\">\r\n                            <a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=\"", 7696, "\"", 7715, 1);
#nullable restore
#line 163 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 7702, Model.Image2, 7702, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 7747, "\"", 7753, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n                    <h3 class=\"blog-desc-big m-0 mb-lg-4 mb-3\"></h3>\r\n                    <p class=\"mb-4\">\r\n                        ");
#nullable restore
#line 168 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                   Write(Model.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>
                    <div class=""d-grid left-right mt-5 pb-md-5"">
                        <div class=""buttons-singles tags"">
                            <h4>Tags :</h4>
                            <a href=""#blog-tag"">Travel</a>
                            <a href=""#blog-tag"">Culture</a>
                            <a href=""#blog-tag"">Hotel</a>
                            <a href=""#blog-tag"">Food</a>
                        </div>
                        <div class=""buttons-singles"">
                            <h4>Share :</h4>
                            <a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-pinterest-p"" aria-hidden=""true""></span></a>
     ");
                WriteLiteral(@"                   </div>
                    </div>
                

                    <div class=""author-card mt-5"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-3 col-6"">
                                <div>
                                    <img");
                BeginWriteAttribute("src", " src=\"", 9318, "\"", 9342, 1);
#nullable restore
#line 192 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 9324, Model.Guide.Image, 9324, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 9343, "\"", 9349, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid\">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n                                <h3 class=\"mb-3 title\">");
#nullable restore
#line 196 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                                                  Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 198 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Link1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </p>
                                <ul class=""author-icons mt-4"">
                                    <li>
                                        <a class=""facebook"" href=""#url"">
                                            <span class=""fa fa-facebook""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""twitter"" href=""#url"">
                                            <span class=""fa fa-twitter""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""google"" href=""#url"">
                                            <span class=""fa fa-google-plus""
                 ");
                WriteLiteral(@"                                 aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""linkedin"" href=""https://www.linkedin.com/in/mahmut-t%C3%BCrkan-76b290138/"">
                                            <span class=""fa fa-linkedin""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""github"" href=""#url"">
                                            <span class=""fa fa-github""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""dribbble"" href=""#ur");
                WriteLiteral(@"l"">
                                            <span class=""fa fa-dribbble""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!--//author-card-->

                    ");
#nullable restore
#line 243 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("Comment", new { id = ViewBag.destID }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 244 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <!--//blog-post-->\r\n        </div>\r\n    </section>\r\n\r\n    <!-- Template JavaScript -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e28867", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e29967", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!--/MENU-JS-->
    <script>
        $(window).on(""scroll"", function () {
            var scroll = $(window).scrollTop();

            if (scroll >= 80) {
                $(""#site-header"").addClass(""nav-fixed"");
            } else {
                $(""#site-header"").removeClass(""nav-fixed"");
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
    <!--//MENU-JS-->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86f06c927ed9bbcaf6d9995f38f709cc4688d5e32000", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Destination> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
