#pragma checksum "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "556dbbce0703156085a2fcd5d3638cbcb7db2fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewPost_Index), @"mvc.1.0.view", @"/Views/ViewPost/Index.cshtml")]
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
#line 1 "D:\C#\MVC\XuanThuLab\Views\_ViewImports.cshtml"
using XuanThuLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\MVC\XuanThuLab\Views\_ViewImports.cshtml"
using XuanThuLab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
using XTLASPNET;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"556dbbce0703156085a2fcd5d3638cbcb7db2fa3", @"/Views/ViewPost/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341e44de942306af2e8c0b8488e2fd9cafe8f80b", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewPost_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-slug", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Paging", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
  
    ViewData["Title"] = "Các chuyên mục";
    Category category = ViewBag.CurrentCategory;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"index-page\">\r\n\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\"><a href=\"/\">Home</a></li>\r\n            <li class=\"breadcrumb-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "556dbbce0703156085a2fcd5d3638cbcb7db2fa35238", async() => {
                WriteLiteral("Blog");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 15 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
             if(category != null) {
                var lis = category.ListParents();
                foreach(var li in lis) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"breadcrumb-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "556dbbce0703156085a2fcd5d3638cbcb7db2fa37501", async() => {
#nullable restore
#line 20 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                                                                   Write(li.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                                                  WriteLiteral(li.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 22 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n    </nav>\r\n\r\n");
#nullable restore
#line 27 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
     if(category != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 28 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
       Write(category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 29 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
        ViewData["Title"] = category.Title;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
     foreach(var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media py-1\">\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0 mb-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "556dbbce0703156085a2fcd5d3638cbcb7db2fa311202", async() => {
#nullable restore
#line 36 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                           WriteLiteral(item.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h5>\r\n                ");
#nullable restore
#line 38 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"author-row\">\r\n                    <strong>");
#nullable restore
#line 40 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                       Write(item.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    <i>");
#nullable restore
#line 41 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
                  Write(item.DateUpdated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 45 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
      

        Func<int?, string> generateUrl = (int? _pagenumber) => {
            if(_pagenumber == 1)
                _pagenumber = null;
            return Url.Link("listpost", new { page = _pagenumber, slug = ViewBag.slugCategory });
        };

        var datapaging = new {
            currentPage = ViewBag.pageNumber,
            countPages = ViewBag.totalPages,
            generateUrl = generateUrl
        };

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "556dbbce0703156085a2fcd5d3638cbcb7db2fa315121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 62 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = datapaging;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Sidebar", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\C#\MVC\XuanThuLab\Views\ViewPost\Index.cshtml"
   Write(await Component.InvokeAsync(CategorySidebar.COMPONENTNAME,
            new CategorySidebar.CategorySidebarData() {
                level = 0,
                categories = ViewBag.categories,
                slugCategory = ViewBag.slugCategory
            }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591