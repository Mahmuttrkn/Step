#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\GuideDetails\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2420a6dac1dd6fc266552bf7e298e229e1ce11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GuideDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GuideDetails/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2420a6dac1dd6fc266552bf7e298e229e1ce11", @"/Views/Shared/Components/GuideDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6c392127b12acb4426bb12ffcfa98e78a49d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GuideDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Guide>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"author-card mt-5\">\r\n    <div class=\"row align-items-center\">\r\n        <div class=\"col-sm-3 col-6\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 188, "\"", 206, 1);
#nullable restore
#line 7 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\GuideDetails\Default.cshtml"
WriteAttributeValue("", 194, Model.Image, 194, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 207, "\"", 213, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle img-fluid\">\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n            <h3 class=\"mb-3 title\">");
#nullable restore
#line 11 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\GuideDetails\Default.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 13 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\GuideDetails\Default.cshtml"
           Write(Model.Description);

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
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""linkedin"" href=""#url"">
                        <span class=""fa fa-linkedin""
                              aria-hidden=""true""></span>
                    </a>
                </li>
             ");
            WriteLiteral(@"   <li>
                    <a class=""github"" href=""#url"">
                        <span class=""fa fa-github""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""dribbble"" href=""#url"">
                        <span class=""fa fa-dribbble""
                              aria-hidden=""true""></span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Guide> Html { get; private set; }
    }
}
#pragma warning restore 1591
