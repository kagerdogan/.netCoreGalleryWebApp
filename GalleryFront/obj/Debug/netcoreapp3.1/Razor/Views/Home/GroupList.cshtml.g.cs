#pragma checksum "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b228bc38c71ba34b46b7957384069b1a095eb2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GroupList), @"mvc.1.0.view", @"/Views/Home/GroupList.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\_ViewImports.cshtml"
using GalleryFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
using Gallery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b228bc38c71ba34b46b7957384069b1a095eb2e", @"/Views/Home/GroupList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc462039c3ecd26acfa2b5d309dbc7b0fd68f79", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GroupList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Group>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
  
    ViewData["Title"] = "Gallery";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b228bc38c71ba34b46b7957384069b1a095eb2e4875", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b228bc38c71ba34b46b7957384069b1a095eb2e5989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<div>
    <table class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <td>
                    ID
                </td>
                <td>
                    Name
                </td>
                <td>
                    Information
                </td>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
             foreach (var el in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                   Write(el.Gid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                   Write(el.Gname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                   Write(el.Ginfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1026, "\"", 1049, 3);
            WriteAttributeValue("", 1036, "Edit(", 1036, 5, true);
#nullable restore
#line 43 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
WriteAttributeValue("", 1041, el.Gid, 1041, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1048, ")", 1048, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1188, "\"", 1213, 3);
            WriteAttributeValue("", 1198, "Delete(", 1198, 7, true);
#nullable restore
#line 46 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
WriteAttributeValue("", 1205, el.Gid, 1205, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1212, ")", 1212, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div id=\"formForArtWork\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b228bc38c71ba34b46b7957384069b1a095eb2e10441", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label>ID</label>
            <input type=""text"" class=""form-control"" id=""inputID"">
        </div>
        <div class=""form-group"">
            <label>Name</label>
            <input type=""text"" class=""form-control"" id=""inputName"">
        </div>
        <div class=""form-group"">
            <label>Info</label>
            <input type=""text"" class=""form-control"" id=""inputInfo"">
        </div>
        <button class=""btn btn-primary"" onclick=""AddGroup()"">Add Group</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<script>\r\n    function Edit(id) {\r\n        var url = \'");
#nullable restore
#line 72 "C:\Users\ACER\Desktop\Gallery V2\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
              Write(Url.Action("EditGroup", "Home", new { id = "ID" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        url = url.replace(""ID"", id);
        window.location.href = url;
    }
    function Delete(id) {
        $.ajax({
            type: 'POST',
            url: '/Home/DeleteGroup',
            data: { id: id },
            success: function (result) {
                console.log(""Başarılı"")
            },
            error: function (ex) {
                console.log(""İşlem Başarısız"")
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
