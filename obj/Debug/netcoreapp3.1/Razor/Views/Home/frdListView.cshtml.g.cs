#pragma checksum "H:\FriendApplication\Views\Home\frdListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c342f15fbc86a113cde291d508a71f70fb809274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_frdListView), @"mvc.1.0.view", @"/Views/Home/frdListView.cshtml")]
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
#line 1 "H:\FriendApplication\Views\_ViewImports.cshtml"
using FriendApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\FriendApplication\Views\Home\frdListView.cshtml"
using FriendApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c342f15fbc86a113cde291d508a71f70fb809274", @"/Views/Home/frdListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a29b3e6adb57bf894ff1a03c7ea5832eb0dbf3db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_frdListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FriendApplication.Models.frd_create>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c342f15fbc86a113cde291d508a71f70fb8092743924", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c342f15fbc86a113cde291d508a71f70fb8092744221", async() => {
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
                WriteLiteral("\r\n\r\n    <link href=\"https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css\" rel=\"stylesheet\" />\r\n    <link href=\"https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css\" rel=\"stylesheet\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<h1>Friend List View</h1>\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <input type=\"submit\" value=\"Create New\" onclick=\"redirecttonewpage()\" />\r\n    </div>\r\n    \r\n\r\n    <div style=\"width:90%; margin:0 auto;\">\r\n");
#nullable restore
#line 29 "H:\FriendApplication\Views\Home\frdListView.cshtml"
         if (Model != null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>UserId</th>
                    <th>Fname</th>
                    <th>Lname</th>
                    <th>MobileNo</th>
                    <th>Email</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                 foreach (var data in Model) {
                    using (Html.BeginForm("cnfDelete", "Home", new {id = data.UserId}))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 49 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(data.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(data.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(data.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(data.MobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(data.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 55 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = data.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                   Write(Html.ActionLink("Delete", "cnfDelete", new { id = data.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 59 "H:\FriendApplication\Views\Home\frdListView.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 63 "H:\FriendApplication\Views\Home\frdListView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>



    <script>
        function msg(id) {
            alert(""UserId"", id)
            location.href = ""http://localhost:51105/Home/Edit/"" + id
           

        }

        //function return confirm(id) {
        //    alert(""UserId"", id)
        //    $(""UserId"" , id).parents('li').remove()
        //}

        function redirecttonewpage() {
            location.href = ""http://localhost:51105/Home/Create/""
        }
        //$(document).ready(function () {

        //    $(""#FrdList"").DataTable(
        //        {
        //            ""processing"": false,
        //            ""serverSide"": true,
        //            ""ajax"": {
        //                ""url"": ""/Home/getfrdListView"",
        //       ");
                WriteLiteral(@"         ""type"": ""GET"",
        //                ""datatype"": ""json""
        //            },
        //            ""columns"": [
        //                { ""data"": ""UserId"", ""name"": ""UserId"", ""autoWidth"": true },
        //                { ""data"": ""Fname"", ""name"": ""Fname"", ""autoWidth"": true },
        //                { ""data"": ""Lname"", ""name"": ""Lname"", ""autoWidth"": true },
        //                { ""data"": ""MobileNo"", ""name"": ""MobileNo"", ""autoWidth"": true },
        //                { ""data"": ""Email"", ""name"": ""Email"", ""autoWidth"": true },
        //                { ""data"": ""Password"", ""name"": ""Password"", ""autoWidth"": true },
        //            ]
        //        }
        //    )
        //})

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FriendApplication.Models.frd_create>> Html { get; private set; }
    }
}
#pragma warning restore 1591
