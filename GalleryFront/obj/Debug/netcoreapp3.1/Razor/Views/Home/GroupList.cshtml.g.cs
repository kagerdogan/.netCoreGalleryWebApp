#pragma checksum "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e3a187b50cae77877c59207a47eff862263c9e0"
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
#line 1 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\_ViewImports.cshtml"
using GalleryFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
using Gallery.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3a187b50cae77877c59207a47eff862263c9e0", @"/Views/Home/GroupList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc462039c3ecd26acfa2b5d309dbc7b0fd68f79", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GroupList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GroupListViewModel>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
  
    ViewData["Title"] = "Gallery";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e3a187b50cae77877c59207a47eff862263c9e04555", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e3a187b50cae77877c59207a47eff862263c9e05669", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
 foreach (var grp in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>\r\n            ");
#nullable restore
#line 18 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
       Write(grp.Gname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </h2>
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <td>
                        Group ID
                    </td>
                    <td>
                        ArtistName
                    </td>
                    <td>
                        ArtWorkName
                    </td>
                </tr>
            </thead>
            <tbody>
                
                <tr>
                    <td>
                        ");
#nullable restore
#line 38 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                   Write(grp.Gid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                     foreach (var item in grp.ArtistName)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 46 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 49 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                     foreach (var item in grp.ArtWorkName)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 54 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                        <td>\r\n                            <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1412, "\"", 1436, 3);
            WriteAttributeValue("", 1422, "Edit(", 1422, 5, true);
#nullable restore
#line 57 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
WriteAttributeValue("", 1427, grp.Gid, 1427, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1435, ")", 1435, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                        </td>\r\n                        <td>\r\n                            <button class=\"btn btn-primary\" type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1587, "\"", 1613, 3);
            WriteAttributeValue("", 1597, "Delete(", 1597, 7, true);
#nullable restore
#line 60 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
WriteAttributeValue("", 1604, grp.Gid, 1604, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1612, ")", 1612, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                        </td>\r\n                    </tr>\r\n                \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<script>\r\n    function Edit(id) {\r\n        var url = \'");
#nullable restore
#line 88 "C:\Users\ACER\Desktop\.netCoreGalleryWebApp\GalleryFront\Views\Home\GroupList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GroupListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
