#pragma checksum "D:\C#\MVC\XuanThuLab\Views\Components\ViewProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ce0ece818c45a8f123137c7f79144b26d062590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_ViewProduct_Default), @"mvc.1.0.view", @"/Views/Components/ViewProduct/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce0ece818c45a8f123137c7f79144b26d062590", @"/Views/Components/ViewProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341e44de942306af2e8c0b8488e2fd9cafe8f80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_ViewProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card m-4\">\r\n    <div class=\"card-header bg-danger text-light\">");
#nullable restore
#line 3 "D:\C#\MVC\XuanThuLab\Views\Components\ViewProduct\Default.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"card-body\">\r\n        <p>Thông tin ");
#nullable restore
#line 5 "D:\C#\MVC\XuanThuLab\Views\Components\ViewProduct\Default.cshtml"
                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Giá: ");
#nullable restore
#line 6 "D:\C#\MVC\XuanThuLab\Views\Components\ViewProduct\Default.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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