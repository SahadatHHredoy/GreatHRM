#pragma checksum "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb588658967585c12a1d7f1e8b8fb57db20be67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Add), @"mvc.1.0.view", @"/Views/Department/Add.cshtml")]
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
#line 1 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
using GreatHRM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb588658967585c12a1d7f1e8b8fb57db20be67", @"/Views/Department/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15739349698fa3a7453cc19cafc1f7c61e93f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GreatHRM.Entities.Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
 using (Html.BeginForm("Add", "Department", FormMethod.Post, new { @class = "form-horizontal" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Department Add</h3>
            <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                    <i class=""fa fa-minus""></i>
                </button>
            </div>
        </div>
        <div class=""box-body"">
            <div class=""row"">
                ");
#nullable restore
#line 16 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 20 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
                   Write(Html.LabelFor(model => model.DepartmentName, new { @class = "col-md-5 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 22 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.DepartmentName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 23 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 29 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
                   Write(Html.LabelFor(model => model.HeadEmail, new { @class = "col-md-5 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 31 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.HeadEmail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 32 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.HeadEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"box-footer\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1866, "\"", 1904, 1);
#nullable restore
#line 40 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
WriteAttributeValue("", 1873, Url.Action("Index", "Company"), 1873, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Cancel</a>\r\n            <button type=\"submit\" class=\"btn btn-info pull-right\">Save</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 44 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Department\Add.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreatHRM.Entities.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
