#pragma checksum "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f36a430c8da07493f9045c229e20f3781344f01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shift_Add), @"mvc.1.0.view", @"/Views/Shift/Add.cshtml")]
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
#line 1 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
using GreatHRM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f36a430c8da07493f9045c229e20f3781344f01", @"/Views/Shift/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15739349698fa3a7453cc19cafc1f7c61e93f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Shift_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GreatHRM.Entities.Shift>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.inputmask.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.inputmask.date.extensions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.inputmask.extensions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
 using (Html.BeginForm("Add", "Shift", FormMethod.Post, new { @class = "form-horizontal" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Shfit Add</h3>
            <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                    <i class=""fa fa-minus""></i>
                </button>
            </div>
        </div>
        <div class=""box-body"">
            ");
#nullable restore
#line 15 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <fieldset class=\"row row-bordered\">\r\n                <legend class=\"sectionLedgend\">Basic</legend>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 21 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.ShiftCode, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 23 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.ShiftCode, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ShiftCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 28 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.StartTime, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 30 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.StartTime, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 31 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 35 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Duration, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 37 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.Duration, new { @class = "form-control time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 38 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 44 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.ShiftName, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 46 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.ShiftName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ShiftName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group \">\r\n                        ");
#nullable restore
#line 51 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.EndTime, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 53 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.EndTime, new { @class = "form-control time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 54 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group \">\r\n                        ");
#nullable restore
#line 58 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.ShiftDetail, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 60 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextAreaFor(model => model.ShiftDetail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 61 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ShiftDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </fieldset>
            <fieldset class=""row row-bordered"">
                <legend class=""sectionLedgend"">Break</legend>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        ");
#nullable restore
#line 70 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Break1Begin, new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 72 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.TextBoxFor(model => model.Break1Begin, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 73 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Break1Begin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 76 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Break2Begin, new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 78 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.TextBoxFor(model => model.Break2Begin, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 79 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Break2Begin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"col-md-3 col-md-offset-1\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 85 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Break1End, new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 86 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.TextBoxFor(model => model.Break1End, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 87 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Break1End));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 90 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Break2End, new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 91 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.TextBoxFor(model => model.Break2End, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 92 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Break2End));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-3 col-md-offset-1\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 97 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Break1Duration, new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 98 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.TextBoxFor(model => model.Break1Duration, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 99 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Break1Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 102 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.Break2Duration, new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 103 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.TextBoxFor(model => model.Break2Duration, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 104 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Break2Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

            </fieldset>
            <fieldset class=""row row-bordered"">
                <legend class=""sectionLedgend"">Others</legend>
                <div class=""col-md-6"">
                    <div class=""form-group"">
                        ");
#nullable restore
#line 113 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.NoOfPresentForWeekend, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 115 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.NoOfPresentForWeekend, new { @class = "form-control input-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 116 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.NoOfPresentForWeekend));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 120 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.RemoveDuplicatePunch, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 122 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.RemoveDuplicatePunch, new { @class = "form-control input-sm time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 123 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.RemoveDuplicatePunch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 127 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.MaxEarlyHourAllow, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 129 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.MaxEarlyHourAllow, new { @class = "form-control time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 130 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.MaxEarlyHourAllow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 136 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.MaxOTAllow, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 138 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.MaxOTAllow, new { @class = "form-control time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 139 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.MaxOTAllow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group \">\r\n                        ");
#nullable restore
#line 143 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.FirstWeeklyOff, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n\r\n                            ");
#nullable restore
#line 146 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.FirstWeeklyOff, new { @class = "form-control", @type = "week" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 147 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.FirstWeeklyOff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group \">\r\n                        ");
#nullable restore
#line 151 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                   Write(Html.LabelFor(model => model.SecondWeeklyOff, new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-7\">\r\n                            ");
#nullable restore
#line 153 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.TextBoxFor(model => model.SecondWeeklyOff, new { @class = "form-control", @type = "week" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 154 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
                       Write(Html.ValidationMessageFor(model => model.SecondWeeklyOff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </fieldset>\r\n\r\n        </div>\r\n        <div class=\"box-footer\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 9278, "\"", 9314, 1);
#nullable restore
#line 162 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
WriteAttributeValue("", 9285, Url.Action("Index", "Shfit"), 9285, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Cancel</a>\r\n            <button type=\"submit\" class=\"btn btn-info pull-right\">Save</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 166 "D:\Projects\GreatHRM\GreatHRM.Web\Views\Shift\Add.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f36a430c8da07493f9045c229e20f3781344f0125939", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f36a430c8da07493f9045c229e20f3781344f0127043", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f36a430c8da07493f9045c229e20f3781344f0128143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n\r\n        $(\'.time\').inputmask({ \"mask\": \"99:99\" })\r\n        $(\'[data-mask]\').inputmask({ \"mask\": \"99:99\" })\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreatHRM.Entities.Shift> Html { get; private set; }
    }
}
#pragma warning restore 1591
