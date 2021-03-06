#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3599ee381538d72b2a246a2f9cb0596ac8f3b760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Authors_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Authors/Index.cshtml")]
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
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3599ee381538d72b2a246a2f9cb0596ac8f3b760", @"/Areas/Manage/Views/Authors/Index.cshtml")]
    public class Areas_Manage_Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/authors/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg-3 btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Author Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Author Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
  
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
                <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Authors</span>
            </div>
            <select class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" id=""searchStatus"" onchange=""searchTrigger()"" placeholder=""Author Status"">
");
#nullable restore
#line 19 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                  
                    foreach (AuthorStatus authorStatus in Model.AuthorStatuses)
                    {
                        if (Model.AuthorStatus == authorStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 974, "\"", 995, 1);
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 982, authorStatus, 982, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                              Write(authorStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1160, "\"", 1181, 1);
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 1168, authorStatus, 1168, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                     Write(authorStatus.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
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
            <input type=""text"" id=""searchKeyword"" placeholder=""search research"" class=""form-control"" aria-label=""search research"" aria-describedby=""basic-addon2""");
            BeginWriteAttribute("value", " value=\"", 1570, "\"", 1599, 1);
#nullable restore
#line 38 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 1578, Model.Author.Keyword, 1578, 21, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3599ee381538d72b2a246a2f9cb0596ac8f3b7609534", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-plus\"></i>&nbsp;\r\n                <span>Create Research</span>\r\n            ");
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
#line 57 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
 if (Model.Author.Items.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless table-striped table-hover"">
        <thead>
            <tr class=""table-info"">
                <th>Name</th>
                <th>Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 68 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
              
                foreach (Author author in Model.Author.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                       Write(author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                       Write(author.AuthorStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3599ee381538d72b2a246a2f9cb0596ac8f3b76012469", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-info\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2814, "~/manage/authors/details/", 2814, 25, true);
#nullable restore
#line 75 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 2839, author.Id, 2839, 10, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3599ee381538d72b2a246a2f9cb0596ac8f3b76014234", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-arrow-up\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2987, "~/manage/authors/edit/", 2987, 22, true);
#nullable restore
#line 76 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 3009, author.Id, 3009, 10, false);

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
            WriteLiteral("\r\n\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3164, "\"", 3245, 9);
            WriteAttributeValue("", 3174, "confirmDeleteAuthor(\'", 3174, 21, true);
#nullable restore
#line 78 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3195, author.Id, 3195, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3205, "\',", 3205, 2, true);
            WriteAttributeValue(" ", 3207, "\'", 3208, 2, true);
#nullable restore
#line 78 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3209, author.ResearchId, 3209, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3227, "\',", 3227, 2, true);
            WriteAttributeValue(" ", 3229, "\'", 3230, 2, true);
#nullable restore
#line 78 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 3231, author.Name, 3231, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3243, "\')", 3243, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Author Delete\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 93 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
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
            BeginWriteAttribute("value", " value=\"", 4632, "\"", 4663, 1);
#nullable restore
#line 102 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 4640, Model.Author.PageIndex, 4640, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 4705, "\"", 4974, 18);
            WriteAttributeValue("", 4717, "javascript:", 4717, 11, true);
            WriteAttributeValue(" ", 4728, "if(event.keyCode", 4729, 17, true);
            WriteAttributeValue(" ", 4745, "==", 4746, 3, true);
            WriteAttributeValue(" ", 4748, "13", 4749, 3, true);
            WriteAttributeValue(" ", 4751, "&&", 4752, 3, true);
            WriteAttributeValue(" ", 4754, "isNaN(parseInt($(this).val()))==false)", 4755, 39, true);
            WriteAttributeValue(" ", 4793, "window.location=\'/manage/authors/index?pageIndex=\'", 4794, 51, true);
            WriteAttributeValue(" ", 4844, "+", 4845, 2, true);
            WriteAttributeValue(" ", 4846, "(isNaN(parseInt($(this).val()))", 4847, 32, true);
            WriteAttributeValue(" ", 4878, "?", 4879, 2, true);
            WriteAttributeValue(" ", 4880, "1", 4881, 2, true);
            WriteAttributeValue(" ", 4882, ":", 4883, 2, true);
            WriteAttributeValue(" ", 4884, "parseInt($(this).val()))", 4885, 25, true);
            WriteAttributeValue(" ", 4909, "+", 4910, 2, true);
            WriteAttributeValue(" ", 4911, "\'&keyword=", 4912, 11, true);
#nullable restore
#line 102 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 4922, Model.Author.Keyword, 4922, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4945, "&status=", 4945, 8, true);
#nullable restore
#line 102 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
WriteAttributeValue("", 4953, Model.AuthorStatus, 4953, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
#nullable restore
#line 103 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                                                                       Write(Model.Author.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
#nullable restore
#line 104 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                              
                                var prev = Model.Author.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3599ee381538d72b2a246a2f9cb0596ac8f3b76021667", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5419, "~/manage/authors/index?keyword=", 5419, 31, true);
#nullable restore
#line 108 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5450, Model.Author.Keyword, 5450, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5471, "&status=", 5471, 8, true);
#nullable restore
#line 108 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5479, Model.AuthorStatus, 5479, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5498, "&pageSize=", 5498, 10, true);
#nullable restore
#line 108 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5508, Model.Author.PageSize, 5508, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5530, "&pageIndex=", 5530, 11, true);
#nullable restore
#line 108 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 5541, prev, 5541, 5, false);

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
#line 109 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 111 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                                                            Write(Model.Author.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 112 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                              
                                var next = Model.Author.PageIndex + 1;
                                if (next <= Model.Author.PageCount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3599ee381538d72b2a246a2f9cb0596ac8f3b76025676", async() => {
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6073, "~/manage/authors/index?keyword=", 6073, 31, true);
#nullable restore
#line 116 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 6104, Model.Author.Keyword, 6104, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6125, "&status=", 6125, 8, true);
#nullable restore
#line 116 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 6133, Model.AuthorStatus, 6133, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6152, "&pageSize=", 6152, 10, true);
#nullable restore
#line 116 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 6162, Model.Author.PageSize, 6162, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6184, "&pageIndex=", 6184, 11, true);
#nullable restore
#line 116 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
AddHtmlAttributeValue("", 6195, next, 6195, 5, false);

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
#line 117 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 125 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>0 search results.</p>\r\n");
#nullable restore
#line 129 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Authors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Model Delete-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-author"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Author</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-author-name""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-author-confirm""><button type=""button"" class=""btn btn-primary"">Delete Author</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--MODAL Unpublish-->
<div class=""modal");
            WriteLiteral(@""" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
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
    <div class=""modal-dialog"" role=""");
            WriteLiteral(@"document"">
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
        $(""#modal-unpublish-name"").html(n");
            WriteLiteral(@"ame);
        $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishAuthor('"" + id + ""')"");
        $(""#modal-unpublish"").modal(""show"");
    }
    function UnpublishAuthor(id) {
        $.ajax({
            type: ""POST"",
            url: ""/manage/authors/unpublish"",
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
        $(""#modal-publish-button"").attr(""onclick"", ""PublishAuthor('"" + id + ""')"");
        $(""#modal-publish"").modal(""show"");
    }
    function PublishAuthor(id) {
        $.ajax({
          ");
            WriteLiteral(@"  type: ""POST"",
            url: ""/manage/authors/publish"",
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

    function confirmDeleteAuthor(authorId,researchId, Name) {
        $(""#modal-delete-author-name"").html(Name);
        $(""#modal-delete-author-confirm"").attr(""href"", ""/manage/authors/delete/"" + authorId + ""/"" + researchId);
        $(""#modal-delete-author"").modal(""show"");
    }

    $(""#searchKeyword"").keyup(function (event) {
        if (event.keyCode === 13) {
            searchTrigger();
        }
    });

    function searchTrigger() {
        window.location = ""/manage/authors/index?pageIndex=1&keyword="" + $(""#searchKeyword"").val() + ""&status="" + $(""#searchStatus"").val();
  ");
            WriteLiteral("  }\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
