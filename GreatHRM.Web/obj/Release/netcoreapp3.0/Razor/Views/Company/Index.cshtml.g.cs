#pragma checksum "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52dabfd71027731cecb382de689b559bd1f07469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "D:\Projects\GreatHRM\GreatHRM.Web\Views\_ViewImports.cshtml"
using GreatHRM.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\GreatHRM\GreatHRM.Web\Views\_ViewImports.cshtml"
using GreatHRM.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
using GreatHRM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52dabfd71027731cecb382de689b559bd1f07469", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15739349698fa3a7453cc19cafc1f7c61e93f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GreatHRM.Entities.Company>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"box\">\r\n    <div class=\"box-header\">\r\n        <h3 class=\"box-title\"></h3>\r\n\r\n        <div class=\"box-tools\">\r\n            <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("href", " href=\"", 239, "\"", 274, 1);
#nullable restore
#line 8 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
WriteAttributeValue("", 246, Url.Action("Add","Company"), 246, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-plus""></i></a>
        </div>
    </div>
    <!-- /.box-header -->
    <div class=""box-body no-padding"">
        <div class=""form-horizontal"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>");
#nullable restore
#line 17 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 18 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 19 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 20 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 23 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                     foreach (var company in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                           Write(Html.DisplayFor(model => company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                           Write(Html.DisplayFor(model => company.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                           Write(Html.DisplayFor(model => company.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                           Write(Html.DisplayFor(model => company.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 31 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Company\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </thead>\r\n\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GreatHRM.Entities.Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
