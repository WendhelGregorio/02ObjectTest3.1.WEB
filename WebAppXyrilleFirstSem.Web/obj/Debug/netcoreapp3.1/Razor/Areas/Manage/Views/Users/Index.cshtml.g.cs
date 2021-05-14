#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfea2714b4d43aa3a80236f0a7e4b04b3f051172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Users/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfea2714b4d43aa3a80236f0a7e4b04b3f051172", @"/Areas/Manage/Views/Users/Index.cshtml")]
    public class Areas_Manage_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/users/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("User Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("User Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Index</h1>


<div class=""row"">
    <div class=""col-lg-5"">
        <div class=""input-group mt-5"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Users</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""User Status"">
");
#nullable restore
#line 19 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                  
                    foreach (UserStatus userStatus in Model.UserStatuses)
                    {
                        if (Model.UserStatus == userStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 958, "\"", 977, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 966, userStatus, 966, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                                                            Write(userStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1140, "\"", 1159, 1);
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 1148, userStatus, 1148, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                                                   Write(userStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>

    <div class=""col-lg-3 "">
        <div class=""input-group mt-5"">
            <input type=""text"" id=""searchKeyword"" placeholder=""search user"" class=""form-control"" aria-label=""search susertudent"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1545, "\"", 1572, 1);
#nullable restore
#line 38 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 1553, Model.User.Keyword, 1553, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""input-group-append"">
                <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search"" aria-hidden=""true""></i></a></span>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""table-responsive table--no-card m-b-30 mt-md-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfea2714b4d43aa3a80236f0a7e4b04b3f0511729465", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create User</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
 if (Model.User.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>FullName</th>
                <th>PhoneNumber</th>
                <th>Address</th>
                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 70 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
              
                foreach (User user in Model.User.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                       Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                       Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                       Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                       Write(user.UserStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfea2714b4d43aa3a80236f0a7e4b04b3f05117213086", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2947, "~/manage/users/details/", 2947, 23, true);
#nullable restore
#line 79 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 2970, user.Id, 2970, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfea2714b4d43aa3a80236f0a7e4b04b3f05117214844", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-arrow-up\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3114, "~/manage/users/edit/", 3114, 20, true);
#nullable restore
#line 80 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 3134, user.Id, 3134, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            \r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3313, "\"", 3370, 6);
            WriteAttributeValue("", 3323, "confirmDeleteUser(\'", 3323, 19, true);
#nullable restore
#line 82 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 3342, user.Id, 3342, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3350, "\',", 3350, 2, true);
            WriteAttributeValue(" ", 3352, "\'", 3353, 2, true);
#nullable restore
#line 82 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 3354, user.FullName, 3354, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3368, "\')", 3368, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"User Delete\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            BeginWriteAttribute("value", " value=\"", 4753, "\"", 4782, 1);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 4761, Model.User.PageIndex, 4761, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4824, "\"", 5081, 18);
            WriteAttributeValue("", 4836, "javascript:", 4836, 11, true);
            WriteAttributeValue(" ", 4847, "if(event.keyCode", 4848, 17, true);
            WriteAttributeValue(" ", 4864, "==", 4865, 3, true);
            WriteAttributeValue(" ", 4867, "13", 4868, 3, true);
            WriteAttributeValue(" ", 4870, "&&", 4871, 3, true);
            WriteAttributeValue(" ", 4873, "isNaN(parseInt($(this).val()))==false)", 4874, 39, true);
            WriteAttributeValue(" ", 4912, "window.location=\'/manage/users/index?pageIndex=\'", 4913, 49, true);
            WriteAttributeValue(" ", 4961, "+", 4962, 2, true);
            WriteAttributeValue(" ", 4963, "(isNaN(parseInt($(this).val()))", 4964, 32, true);
            WriteAttributeValue(" ", 4995, "?", 4996, 2, true);
            WriteAttributeValue(" ", 4997, "1", 4998, 2, true);
            WriteAttributeValue(" ", 4999, ":", 5000, 2, true);
            WriteAttributeValue(" ", 5001, "parseInt($(this).val()))", 5002, 25, true);
            WriteAttributeValue(" ", 5026, "+", 5027, 2, true);
            WriteAttributeValue(" ", 5028, "\'&keyword=", 5029, 11, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 5039, Model.User.Keyword, 5039, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5060, "&status=", 5060, 8, true);
#nullable restore
#line 106 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
WriteAttributeValue("", 5068, Model.User, 5068, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 107 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                                                                                                       Write(Model.User.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 108 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                              
                                var prev = Model.User.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfea2714b4d43aa3a80236f0a7e4b04b3f05117221856", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5522, "~/manage/users/index?keyword=", 5522, 29, true);
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 5551, Model.User.Keyword, 5551, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5570, "&status=", 5570, 8, true);
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 5578, Model.UserStatus, 5578, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5595, "&pageSize=", 5595, 10, true);
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 5605, Model.User.PageSize, 5605, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5625, "&pageIndex=", 5625, 11, true);
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 5636, prev, 5636, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 113 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 115 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                                                                            Write(Model.User.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 116 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                              
                                var next = Model.User.PageIndex + 1;
                                if (next <= Model.User.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfea2714b4d43aa3a80236f0a7e4b04b3f05117225837", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6162, "~/manage/users/index?keyword=", 6162, 29, true);
#nullable restore
#line 120 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 6191, Model.User.Keyword, 6191, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6210, "&status=", 6210, 8, true);
#nullable restore
#line 120 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 6218, Model.UserStatus, 6218, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6235, "&pageSize=", 6235, 10, true);
#nullable restore
#line 120 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 6245, Model.User.PageSize, 6245, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6265, "&pageIndex=", 6265, 11, true);
#nullable restore
#line 120 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
AddHtmlAttributeValue("", 6276, next, 6276, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 121 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 129 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 133 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-user"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete User</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-user-fullname""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-user-confirm""><button type=""button"" class=""btn btn-primary"">Delete User</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<div class=""modal"" tabi");
            WriteLiteral(@"ndex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL Publish-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publish"">
    <div class=""modal-dialog"" role=""docume");
            WriteLiteral(@"nt"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>



<script type=""text/javascript"">

    ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
    function confirmUnpublish(id, name) {
        $(""#modal-unpublish-name"").html(name);
            WriteLiteral(@"
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishUser('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishUser(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/users/unpublish"",
            data: { id: id },
            success: function (data) {
                location.reload();
            },
            error: function (xhr) {
                var response = JSON.parse(xhr.responseText);
                alert(""Error Occured : "" + response.errors[0]);
                location.reload();
            }
        });
    }


    //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
    function confirmPublish(id, name) {
        $(""#modal-publish-name"").html(name);
        $(""#modal-publish-button"").attr(""onclick"", ""PublishUser('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishUser(id) {
        $.ajax({
            type: ""POST"",
            WriteLiteral(@"
            url: ""/manage/users/publish"",
            data: { id: id },
            success: function (data) {
                location.reload();
            },
            error: function (xhr) {
                var response = JSON.parse(xhr.responseText);
                alert(""Error Occured : "" + response.errors[0]);
                location.reload();
            }
        });
    }

    function confirmDeleteUser(userId, Name) {
        $(""#modal-delete-user-fullname"").html(Name);
        $(""#modal-delete-user-confirm"").attr(""href"", ""/manage/users/delete/"" + userId);
        $(""#modal-delete-user"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/users/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus"").val();
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591