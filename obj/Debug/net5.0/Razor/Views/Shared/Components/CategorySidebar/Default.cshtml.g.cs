#pragma checksum "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b00fc748ac995572b10ded543ca431399e7f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategorySidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategorySidebar/Default.cshtml")]
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
#line 1 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
using XTLASPNET;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03b00fc748ac995572b10ded543ca431399e7f76", @"/Views/Shared/Components/CategorySidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341e44de942306af2e8c0b8488e2fd9cafe8f80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategorySidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategorySidebar.CategorySidebarData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-slug", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
  
    List<Category> categories = Model.categories;
    int level = Model.level;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
 if (categories.Count > 0)
{
    if (level == 0) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
   Write(Html.Raw("<div class=\"categorysidebar\">"));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03b00fc748ac995572b10ded543ca431399e7f764907", async() => {
                WriteLiteral("Các chủ đề");
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
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 13 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     <ul>\r\n");
#nullable restore
#line 15 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
         foreach (var item in categories)
        {
            var cssClass = (item.Slug == Model.slugCategory) ? "active" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03b00fc748ac995572b10ded543ca431399e7f767338", async() => {
#nullable restore
#line 19 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
                                Write(item.Title);

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
#line 18 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
                                                                    WriteLiteral(item.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
AddHtmlAttributeValue("", 644, cssClass, 644, 9, false);

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
#line 21 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
             if (item.CategoryChildren?.Count > 0) {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
           Write(await Component.InvokeAsync(CategorySidebar.COMPONENTNAME, 
                    new CategorySidebar.CategorySidebarData() {
                        categories = item.CategoryChildren.ToList(),
                        level = Model.level + 1,
                        slugCategory = Model.slugCategory
                    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
                      

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </ul>\r\n");
#nullable restore
#line 33 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"

    if (level == 0) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\C#\MVC\XuanThuLab\Views\Shared\Components\CategorySidebar\Default.cshtml"
                           
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategorySidebar.CategorySidebarData> Html { get; private set; }
    }
}
#pragma warning restore 1591
