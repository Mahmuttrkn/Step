#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Statistics\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c55b87330bf3d3b57229333dfd3c3cbb400130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Statistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Statistics/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c55b87330bf3d3b57229333dfd3c3cbb400130", @"/Views/Shared/Components/Statistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6c392127b12acb4426bb12ffcfa98e78a49d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Statistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"w3l-stats py-5\" id=\"stats\">\r\n    <div class=\"gallery-inner container py-lg-0 py-3\">\r\n        <div class=\"row stats-con pb-lg-3\">\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid\">\r\n                <p class=\"counter\">");
#nullable restore
#line 5 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Statistics\Default.cshtml"
                              Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Branches</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid1\">\r\n                <p class=\"counter\">");
#nullable restore
#line 9 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Statistics\Default.cshtml"
                              Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Travel Guides</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid mt-lg-0 mt-5\">\r\n                <p class=\"counter\">");
#nullable restore
#line 13 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Statistics\Default.cshtml"
                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Happy Customers</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid2 mt-lg-0 mt-5\">\r\n                <p class=\"counter\">");
#nullable restore
#line 17 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Statistics\Default.cshtml"
                              Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Awards</h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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