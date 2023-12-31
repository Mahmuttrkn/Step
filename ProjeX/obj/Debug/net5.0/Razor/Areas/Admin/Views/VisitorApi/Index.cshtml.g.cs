#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1f466ed58bb0986b634182333ef490dea59770"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VisitorApi_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
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
#line 1 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\_ViewImports.cshtml"
using ProjeX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\_ViewImports.cshtml"
using ProjeX.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a1f466ed58bb0986b634182333ef490dea59770", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0125dfdaf465294780b3e5a7587c6532cf6d847b", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_VisitorApi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjeX.Areas.Admin.Models.VisitorViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Api Ziyaretçi Listesi</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad</th>
        <th>Soyad</th>
        <th>Şehir</th>
        <th>Ülke</th>
        <th>Mail</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a class=\"btn btn-outline-info\"");
            BeginWriteAttribute("href", " href=\"", 775, "\"", 828, 2);
            WriteAttributeValue("", 782, "/Admin/VisitorApi/VisitorDelete/", 782, 32, true);
#nullable restore
#line 31 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 814, item.VistorID, 814, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n            <td><a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 894, "\"", 947, 2);
            WriteAttributeValue("", 901, "/Admin/VisitorApi/VisitorUpdate/", 901, 32, true);
#nullable restore
#line 32 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 933, item.VistorID, 933, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\VisitorApi\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/VisitorApi/VisitorCreate\" class=\"btn btn-outline-secondary\">Ziyaretçi Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjeX.Areas.Admin.Models.VisitorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
