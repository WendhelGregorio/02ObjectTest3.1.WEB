#pragma checksum "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0222b28531a779e8c98a558c93657df17c33be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Users_Create), @"mvc.1.0.view", @"/Areas/Manage/Views/Users/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0222b28531a779e8c98a558c93657df17c33be", @"/Areas/Manage/Views/Users/Create.cshtml")]
    public class Areas_Manage_Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users.CreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/users/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Create.cshtml"
  
    Layout = "~/areas/manage/views/shared/_managelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <form method=\"post\" action=\"/manage/users/create\">\r\n                ");
#nullable restore
#line 12 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\VGD PC 9\Videos\WEBAPPS\GitRootXyrilleMyWebApp\WebAppXyrilleFirstSem.Web\Areas\Manage\Views\Users\Create.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""form-group"">
                    <label class=""control-label"">FirstName</label>
                    <input type=""text"" class=""form-control"" name=""FirstName"" placeholder=""Enter a FirstName"" />
                </div>


                <div class=""form-group"">
                    <label class=""control-label"">LastName</label>
                    <input type=""text"" class=""form-control"" name=""LastName"" placeholder=""Enter a LastName"" />
                </div>

                <div class=""form-group"">
                    <label class=""control-label"">UserName</label>
                    <input type=""text"" class=""form-control"" name=""UserName"" placeholder=""Enter a UserName"" />
                </div>

                <div class=""form-group"">
                    <label class=""control-label"">Address</label>
                    <input type=""text"" class=""form-control"" name=""Address"" placeholder=""Enter a Address"" />
                </div>

                <div class=""form-g");
            WriteLiteral(@"roup"">
                    <label class=""control-label"">PhoneNumber</label>
                    <input type=""text"" class=""form-control"" name=""PhoneNumber"" placeholder=""Enter a PhoneNumber"" />
                </div>


                <div class=""form-group"">
                    <label class=""control-label"">EmailAddress</label>
                    <input type=""email"" class=""form-control"" name=""EmailAddress"" placeholder=""Enter a EmailAddress"" />
                </div>

                <div class=""form-group"">
                    <label class=""control-label"">Password</label>
                    <input type=""password"" class=""form-control"" name=""Password"" placeholder=""Enter a Password"" />

                </div>




                <button type=""submit"" class=""btn btn-primary"">Submit</button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0222b28531a779e8c98a558c93657df17c33be6460", async() => {
                WriteLiteral("Cancel");
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
            WriteLiteral("\r\n\r\n\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users.CreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
