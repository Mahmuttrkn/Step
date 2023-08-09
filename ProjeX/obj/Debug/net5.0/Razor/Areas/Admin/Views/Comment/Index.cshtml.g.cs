#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3fc45c39b5381ba216ea61385791a1d118d4150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fc45c39b5381ba216ea61385791a1d118d4150", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0125dfdaf465294780b3e5a7587c6532cf6d847b", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Comment List</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Username</th>
        <th>Surname</th>
        <th>Date</th>
        <th>Destination</th>
        <th>Content</th>
        <th>Status</th>
        <th>Delete</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentUserSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
            Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 837, "\"", 888, 2);
            WriteAttributeValue("", 844, "/Admin/Comment/DeleteComment/", 844, 29, true);
#nullable restore
#line 29 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 873, item.CommentID, 873, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\Comment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
