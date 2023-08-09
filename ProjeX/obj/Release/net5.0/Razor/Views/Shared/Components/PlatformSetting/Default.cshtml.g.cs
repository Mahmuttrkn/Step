#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\PlatformSetting\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23c60a12c714ce2476e801f750dcc99478310f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PlatformSetting_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PlatformSetting/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23c60a12c714ce2476e801f750dcc99478310f3", @"/Views/Shared/Components/PlatformSetting/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6c392127b12acb4426bb12ffcfa98e78a49d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PlatformSetting_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-0"">Platform Settings</h6>
        </div>
        <div class=""card-body p-3"">
            <h6 class=""text-uppercase text-body text-xs font-weight-bolder"">Account</h6>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault"" checked>
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault"">Profile Status</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault1"">
            ");
            WriteLiteral(@"            <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault1"">2 Factor authentication</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault2"" checked>
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault2"">Show Phone Number</label>
                    </div>
                </li>
            </ul>
            <h6 class=""text-uppercase text-body text-xs font-weight-bolder mt-4"">Application</h6>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefau");
            WriteLiteral(@"lt3"">
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault3"">New tour organizations</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault4"" checked>
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault4"">Monthly product updates</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0 pb-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault5"">
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefa");
            WriteLiteral("ult5\">Subscribe to newsletter</label>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
