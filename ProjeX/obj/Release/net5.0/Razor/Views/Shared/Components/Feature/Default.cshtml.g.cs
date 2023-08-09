#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24fade559f282ce8d4bc2a72f9942d81d73622b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Feature_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Feature/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24fade559f282ce8d4bc2a72f9942d81d73622b", @"/Views/Shared/Components/Feature/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6c392127b12acb4426bb12ffcfa98e78a49d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Feature_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"best-rooms py-5\">\r\n    <div class=\"container py-md-5\">\r\n        <div class=\"ban-content-inf row\">\r\n");
#nullable restore
#line 7 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
               
                var values1 = Model.Take(1);
                var values2 = Model.TakeLast(2);
                string cssCard = null;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
             if (values1.Any(x => x.FeatureID == Model[0].FeatureID))
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"maghny-gd-1 col-lg-6\">\r\n                <div class=\"maghny-grid\">\r\n                    <figure class=\"effect-lily border-radius  m-0\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 628, "\"", 649, 1);
#nullable restore
#line 19 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
WriteAttributeValue("", 634, Model[0].Image, 634, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 650, "\"", 656, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <figcaption>\r\n                            <div>\r\n                                <h4>");
#nullable restore
#line 22 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                               Write(Model[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                                <p>From ");
#nullable restore
#line 23 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                                   Write(Model[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("$ </p>\r\n                            </div>\r\n\r\n                        </figcaption>\r\n                    </figure>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"maghny-gd-1 col-lg-6 mt-lg-0 mt-4\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 33 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                     foreach (var item in Model.Skip(1).ToList())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                         if (values2.Any(x => x.FeatureID == item.FeatureID)) cssCard = "mt-4";
                        else cssCard = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1389, "\"", 1423, 3);
            WriteAttributeValue("", 1397, "maghny-gd-1", 1397, 11, true);
            WriteAttributeValue(" ", 1408, "col-6", 1409, 6, true);
#nullable restore
#line 38 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
WriteAttributeValue(" ", 1414, cssCard, 1415, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"maghny-grid\">\r\n                                <figure class=\"effect-lily border-radius\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1616, "\"", 1633, 1);
#nullable restore
#line 41 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
WriteAttributeValue("", 1622, item.Image, 1622, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1634, "\"", 1640, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <figcaption>\r\n                                        <div>\r\n                                            <h4>");
#nullable restore
#line 44 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                            <p>From ");
#nullable restore
#line 45 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("$ </p>\r\n                                        </div>\r\n\r\n                                    </figcaption>\r\n                                </figure>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 52 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Views\Shared\Components\Feature\Default.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
