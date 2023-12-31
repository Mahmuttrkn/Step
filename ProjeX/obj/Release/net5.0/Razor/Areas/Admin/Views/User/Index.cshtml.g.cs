#pragma checksum "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad429f06069b6d599b0b4dbecec50e4d212d747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad429f06069b6d599b0b4dbecec50e4d212d747", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0125dfdaf465294780b3e5a7587c6532cf6d847b", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>User Page</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Username</th>
        <th>Name</th>
        <th>Surname</th>
        <th>Image</th>
        <th>Email</th>
        <th>Gender</th>
        <th>Phone Number</th>
        <th>Sil</th>
        <th>Güncelle</th>
        <th>Yorumlar</th>
        <th>Tur Geçmişi</th>

    </tr>
");
#nullable restore
#line 25 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"hidden\">");
#nullable restore
#line 28 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 760, "\"", 780, 1);
#nullable restore
#line 32 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 766, item.ImageUrl, 766, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 918, "\"", 956, 2);
            WriteAttributeValue("", 925, "/Admin/User/DeleteUser/", 925, 23, true);
#nullable restore
#line 36 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 948, item.Id, 948, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1013, "\"", 1051, 2);
            WriteAttributeValue("", 1020, "/Admin/User/UpdateUser/", 1020, 23, true);
#nullable restore
#line 37 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1043, item.Id, 1043, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1153, 2);
            WriteAttributeValue("", 1121, "/Admin/User/CommentUser/", 1121, 24, true);
#nullable restore
#line 38 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1145, item.Id, 1145, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Yorumlar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1213, "\"", 1256, 2);
            WriteAttributeValue("", 1220, "/Admin/User/ReservationUser/", 1220, 28, true);
#nullable restore
#line 39 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1248, item.Id, 1248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Tur Geçmişi</a></td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\mturkan\source\repos\ProjeX\ProjeX\Areas\Admin\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Login/SignUp\" class=\"btn btn-outline-primary\">New User</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
